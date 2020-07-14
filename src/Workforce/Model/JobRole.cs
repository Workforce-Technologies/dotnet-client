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
    /// JobRole
    /// </summary>
    [DataContract]
    public partial class JobRole :  IEquatable<JobRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobRole" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobRole() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobRole" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="department">department.</param>
        /// <param name="departmentId">departmentId (required).</param>
        public JobRole(Guid id = default(Guid), string name = default(string), Department department = default(Department), Guid? departmentId = default(Guid?))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for JobRole and cannot be null");
            // to ensure "departmentId" is required (not null)
            this.DepartmentId = departmentId ?? throw new ArgumentNullException("departmentId is a required property for JobRole and cannot be null");
            this.Id = id;
            this.Department = department;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public Department Department { get; set; }

        /// <summary>
        /// Gets or Sets DepartmentId
        /// </summary>
        [DataMember(Name="departmentId", EmitDefaultValue=true)]
        public Guid? DepartmentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobRole {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
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
            return this.Equals(input as JobRole);
        }

        /// <summary>
        /// Returns true if JobRole instances are equal
        /// </summary>
        /// <param name="input">Instance of JobRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobRole input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.DepartmentId != null)
                    hashCode = hashCode * 59 + this.DepartmentId.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 200.", new [] { "Name" });
            }

            yield break;
        }
    }

}