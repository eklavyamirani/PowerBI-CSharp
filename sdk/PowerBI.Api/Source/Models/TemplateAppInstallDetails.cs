// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI Template App Install Details
    /// </summary>
    public partial class TemplateAppInstallDetails
    {
        /// <summary>
        /// Initializes a new instance of the TemplateAppInstallDetails class.
        /// </summary>
        public TemplateAppInstallDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemplateAppInstallDetails class.
        /// </summary>
        /// <param name="appId">Unique application Id.</param>
        /// <param name="packageKey">Application version secure key</param>
        /// <param name="ownerTenantId">Application owner's tenant object
        /// Id</param>
        /// <param name="config">Automated install configuration.</param>
        public TemplateAppInstallDetails(System.Guid appId, string packageKey, System.Guid ownerTenantId, TemplateAppConfigurationRequest config = default(TemplateAppConfigurationRequest))
        {
            AppId = appId;
            PackageKey = packageKey;
            OwnerTenantId = ownerTenantId;
            Config = config;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique application Id.
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public System.Guid AppId { get; set; }

        /// <summary>
        /// Gets or sets application version secure key
        /// </summary>
        [JsonProperty(PropertyName = "packageKey")]
        public string PackageKey { get; set; }

        /// <summary>
        /// Gets or sets application owner's tenant object Id
        /// </summary>
        [JsonProperty(PropertyName = "ownerTenantId")]
        public System.Guid OwnerTenantId { get; set; }

        /// <summary>
        /// Gets or sets automated install configuration.
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public TemplateAppConfigurationRequest Config { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PackageKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PackageKey");
            }
        }
    }
}
