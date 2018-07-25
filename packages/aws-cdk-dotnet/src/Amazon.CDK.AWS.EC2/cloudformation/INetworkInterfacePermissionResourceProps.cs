using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EC2.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfacepermission.html </remarks>
    [JsiiInterface(typeof(INetworkInterfacePermissionResourceProps), "@aws-cdk/aws-ec2.cloudformation.NetworkInterfacePermissionResourceProps")]
    public interface INetworkInterfacePermissionResourceProps
    {
        /// <summary>``AWS::EC2::NetworkInterfacePermission.AwsAccountId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfacepermission.html#cfn-ec2-networkinterfacepermission-awsaccountid </remarks>
        [JsiiProperty("awsAccountId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object AwsAccountId
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::NetworkInterfacePermission.NetworkInterfaceId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfacepermission.html#cfn-ec2-networkinterfacepermission-networkinterfaceid </remarks>
        [JsiiProperty("networkInterfaceId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object NetworkInterfaceId
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::NetworkInterfacePermission.Permission``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfacepermission.html#cfn-ec2-networkinterfacepermission-permission </remarks>
        [JsiiProperty("permission", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Permission
        {
            get;
            set;
        }
    }
}