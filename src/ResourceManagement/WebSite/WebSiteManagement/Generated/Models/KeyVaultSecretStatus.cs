// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for KeyVaultSecretStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KeyVaultSecretStatus
    {
        [EnumMember(Value = "Initialized")]
        Initialized,
        [EnumMember(Value = "WaitingOnCertificateOrder")]
        WaitingOnCertificateOrder,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "CertificateOrderFailed")]
        CertificateOrderFailed,
        [EnumMember(Value = "OperationNotPermittedOnKeyVault")]
        OperationNotPermittedOnKeyVault,
        [EnumMember(Value = "AzureServiceUnauthorizedToAccessKeyVault")]
        AzureServiceUnauthorizedToAccessKeyVault,
        [EnumMember(Value = "KeyVaultDoesNotExist")]
        KeyVaultDoesNotExist,
        [EnumMember(Value = "KeyVaultSecretDoesNotExist")]
        KeyVaultSecretDoesNotExist,
        [EnumMember(Value = "UnknownError")]
        UnknownError,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}
