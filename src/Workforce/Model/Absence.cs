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
    /// Absence
    /// </summary>
    [DataContract(Name = "Absence")]
    public partial class Absence : IEquatable<Absence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Absence" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="absenceType">absenceType.</param>
        /// <param name="dateFrom">dateFrom.</param>
        /// <param name="dateTo">dateTo.</param>
        /// <param name="employeeId">employeeId.</param>
        /// <param name="notes">notes.</param>
        public Absence(Guid id = default(Guid), string absenceType = default(string), DateTime dateFrom = default(DateTime), DateTime dateTo = default(DateTime), Guid employeeId = default(Guid), string notes = default(string))
        {
            this.Id = id;
            this.AbsenceType = absenceType;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.EmployeeId = employeeId;
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets AbsenceType
        /// </summary>
        [DataMember(Name = "absenceType", EmitDefaultValue = true)]
        public string AbsenceType { get; set; }

        /// <summary>
        /// Gets or Sets DateFrom
        /// </summary>
        [DataMember(Name = "dateFrom", EmitDefaultValue = false)]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Gets or Sets DateTo
        /// </summary>
        [DataMember(Name = "dateTo", EmitDefaultValue = false)]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeId
        /// </summary>
        [DataMember(Name = "employeeId", EmitDefaultValue = false)]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Absence {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AbsenceType: ").Append(AbsenceType).Append("\n");
            sb.Append("  DateFrom: ").Append(DateFrom).Append("\n");
            sb.Append("  DateTo: ").Append(DateTo).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
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
            return this.Equals(input as Absence);
        }

        /// <summary>
        /// Returns true if Absence instances are equal
        /// </summary>
        /// <param name="input">Instance of Absence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Absence input)
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
                    this.AbsenceType == input.AbsenceType ||
                    (this.AbsenceType != null &&
                    this.AbsenceType.Equals(input.AbsenceType))
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
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AbsenceType != null)
                    hashCode = hashCode * 59 + this.AbsenceType.GetHashCode();
                if (this.DateFrom != null)
                    hashCode = hashCode * 59 + this.DateFrom.GetHashCode();
                if (this.DateTo != null)
                    hashCode = hashCode * 59 + this.DateTo.GetHashCode();
                if (this.EmployeeId != null)
                    hashCode = hashCode * 59 + this.EmployeeId.GetHashCode();
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
            // AbsenceType (string) maxLength
            if(this.AbsenceType != null && this.AbsenceType.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AbsenceType, length must be less than 20.", new [] { "AbsenceType" });
            }

            yield break;
        }
    }

}
