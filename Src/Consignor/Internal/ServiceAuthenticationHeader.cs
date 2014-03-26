using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace Consignor.Internal
{
    [DataContract(Namespace = "SoapAuthenticator")]
    internal class ServiceAuthenticationHeader
    {
        [DataMember(Order = 0)] public string Username { get; set; }
        [DataMember(Order = 1)] public string Password { get; set; }
        [DataMember(Order = 2)] public bool? IsEncrypted { get; set; }
    }
}