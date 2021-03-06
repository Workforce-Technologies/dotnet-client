/*
 * Workforce API
 *
 * Public API for the Workforce software
 *
 * The version of the OpenAPI document: v1
 * Contact: adamlonsdale@me.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Workforce.Client.OpenAPIDateConverter;

namespace Workforce.Model
{
    /// <summary>
    /// EmployeeAddressXref
    /// </summary>
    [DataContract(Name = "EmployeeAddressXref")]
    public partial class EmployeeAddressXref : IEquatable<EmployeeAddressXref>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeAddressXref" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="addressId">addressId.</param>
        /// <param name="address">address.</param>
        public EmployeeAddressXref(Guid id = default(Guid), Guid addressId = default(Guid), Address address = default(Address))
        {
            this.Id = id;
            this.AddressId = addressId;
            this.Address = address;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets AddressId
        /// </summary>
        [DataMember(Name = "addressId", EmitDefaultValue = false)]
        public Guid AddressId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeAddressXref {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmployeeAddressXref);
        }

        /// <summary>
        /// Returns true if EmployeeAddressXref instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeAddressXref to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeAddressXref input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AddressId == input.AddressId ||
                    (this.AddressId != null &&
                    this.AddressId.Equals(input.AddressId))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AddressId != null)
                    hashCode = hashCode * 59 + this.AddressId.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
