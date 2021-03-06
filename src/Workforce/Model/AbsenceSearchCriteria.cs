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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Workforce.Client.OpenAPIDateConverter;

namespace Workforce.Model
{
    /// <summary>
    /// AbsenceSearchCriteria
    /// </summary>
    [DataContract]
    public partial class AbsenceSearchCriteria :  IEquatable<AbsenceSearchCriteria>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsenceSearchCriteria" /> class.
        /// </summary>
        /// <param name="employeeId">employeeId.</param>
        /// <param name="dateFrom">dateFrom.</param>
        /// <param name="dateTo">dateTo.</param>
        /// <param name="notes">notes.</param>
        public AbsenceSearchCriteria(Guid employeeId = default(Guid), DateTime dateFrom = default(DateTime), DateTime dateTo = default(DateTime), string notes = default(string))
        {
            this.EmployeeId = employeeId;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Gets or Sets EmployeeId
        /// </summary>
        [DataMember(Name="employeeId", EmitDefaultValue=false)]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Gets or Sets DateFrom
        /// </summary>
        [DataMember(Name="dateFrom", EmitDefaultValue=false)]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Gets or Sets DateTo
        /// </summary>
        [DataMember(Name="dateTo", EmitDefaultValue=false)]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbsenceSearchCriteria {\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  DateFrom: ").Append(DateFrom).Append("\n");
            sb.Append("  DateTo: ").Append(DateTo).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as AbsenceSearchCriteria);
        }

        /// <summary>
        /// Returns true if AbsenceSearchCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of AbsenceSearchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbsenceSearchCriteria input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.DateFrom == input.DateFrom ||
                    (this.DateFrom != null &&
                    this.DateFrom.Equals(input.DateFrom))
                ) && 
                (
                    this.DateTo == input.DateTo ||
                    (this.DateTo != null &&
                    this.DateTo.Equals(input.DateTo))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.EmployeeId != null)
                    hashCode = hashCode * 59 + this.EmployeeId.GetHashCode();
                if (this.DateFrom != null)
                    hashCode = hashCode * 59 + this.DateFrom.GetHashCode();
                if (this.DateTo != null)
                    hashCode = hashCode * 59 + this.DateTo.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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
