// Use pipeline as CloudWAtch event target

import codecommit = require('@aws-cdk/aws-codecommit');
import codecommitPipeline = require('@aws-cdk/aws-codecommit-codepipeline');
import codepipeline = require('@aws-cdk/aws-codepipeline');
import sns = require('@aws-cdk/aws-sns');
import cdk = require('@aws-cdk/cdk');
import codebuildPipeline = require('../lib');

const app = new cdk.App(process.argv);

const stack = new cdk.Stack(app, 'aws-cdk-pipeline-event-target');

const pipeline = new codepipeline.Pipeline(stack, 'MyPipeline');
const sourceStage = new codepipeline.Stage(pipeline, 'Source');
const buildStage = new codepipeline.Stage(pipeline, 'Build');

const repository = new codecommit.Repository(stack, 'CodeCommitRepo', { repositoryName: 'foo' });
const project = new codebuildPipeline.PipelineProject(stack, 'BuildProject');

const sourceAction = new codecommitPipeline.PipelineSource(sourceStage, 'CodeCommitSource', { artifactName: 'Source', repository });
new codebuildPipeline.PipelineBuildAction(buildStage, 'CodeBuildAction', { inputArtifact: sourceAction.artifact, project });

const topic = new sns.Topic(stack, 'MyTopic');
topic.subscribeEmail('benisrae', 'benisrae@amazon.com');

pipeline.onStateChange('OnPipelineStateChange').addTarget(topic, {
    textTemplate: 'Pipeline <pipeline> changed state to <state>',
    pathsMap: {
        pipeline: '$.detail.pipeline',
        state: '$.detail.state'
    }
});

sourceStage.onStateChange('OnSourceStateChange', topic);

sourceAction.onStateChange('OnActionStateChange', topic).addEventPattern({
    detail: { state: [ 'STARTED' ] }
});

process.stdout.write(app.run());
