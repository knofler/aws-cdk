using Amazon.CDK;
using Amazon.CDK.AWS.CloudFront.cloudformation.StreamingDistributionResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.CloudFront.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html </remarks>
    public class StreamingDistributionResourceProps : DeputyBase, IStreamingDistributionResourceProps
    {
        /// <summary>``AWS::CloudFront::StreamingDistribution.StreamingDistributionConfig``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html#cfn-cloudfront-streamingdistribution-streamingdistributionconfig </remarks>
        [JsiiProperty("streamingDistributionConfig", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-cloudfront.cloudformation.StreamingDistributionResource.StreamingDistributionConfigProperty\"}]}}", true)]
        public object StreamingDistributionConfig
        {
            get;
            set;
        }

        /// <summary>``AWS::CloudFront::StreamingDistribution.Tags``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-streamingdistribution.html#cfn-cloudfront-streamingdistribution-tags </remarks>
        [JsiiProperty("tags", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/cdk.Tag\"}]}}}}]}}", true)]
        public object Tags
        {
            get;
            set;
        }
    }
}