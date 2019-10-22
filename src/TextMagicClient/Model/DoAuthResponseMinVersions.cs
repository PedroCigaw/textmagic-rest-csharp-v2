/* 
 * TextMagic API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = TextMagicClient.Client.SwaggerDateConverter;

namespace TextMagicClient.Model
{
    /// <summary>
    /// DoAuthResponseMinVersions
    /// </summary>
    [DataContract]
    public partial class DoAuthResponseMinVersions :  IEquatable<DoAuthResponseMinVersions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoAuthResponseMinVersions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DoAuthResponseMinVersions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoAuthResponseMinVersions" /> class.
        /// </summary>
        /// <param name="ios">ios (required).</param>
        /// <param name="android">android (required).</param>
        /// <param name="desktop">desktop (required).</param>
        public DoAuthResponseMinVersions(int? ios = default(int?), int? android = default(int?), int? desktop = default(int?))
        {
            // to ensure "ios" is required (not null)
            if (ios == null)
            {
                throw new InvalidDataException("ios is a required property for DoAuthResponseMinVersions and cannot be null");
            }
            else
            {
                this.Ios = ios;
            }
            // to ensure "android" is required (not null)
            if (android == null)
            {
                throw new InvalidDataException("android is a required property for DoAuthResponseMinVersions and cannot be null");
            }
            else
            {
                this.Android = android;
            }
            // to ensure "desktop" is required (not null)
            if (desktop == null)
            {
                throw new InvalidDataException("desktop is a required property for DoAuthResponseMinVersions and cannot be null");
            }
            else
            {
                this.Desktop = desktop;
            }
        }
        
        /// <summary>
        /// Gets or Sets Ios
        /// </summary>
        [DataMember(Name="ios", EmitDefaultValue=false)]
        public int? Ios { get; set; }

        /// <summary>
        /// Gets or Sets Android
        /// </summary>
        [DataMember(Name="android", EmitDefaultValue=false)]
        public int? Android { get; set; }

        /// <summary>
        /// Gets or Sets Desktop
        /// </summary>
        [DataMember(Name="desktop", EmitDefaultValue=false)]
        public int? Desktop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DoAuthResponseMinVersions {\n");
            sb.Append("  Ios: ").Append(Ios).Append("\n");
            sb.Append("  Android: ").Append(Android).Append("\n");
            sb.Append("  Desktop: ").Append(Desktop).Append("\n");
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
            return this.Equals(input as DoAuthResponseMinVersions);
        }

        /// <summary>
        /// Returns true if DoAuthResponseMinVersions instances are equal
        /// </summary>
        /// <param name="input">Instance of DoAuthResponseMinVersions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoAuthResponseMinVersions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ios == input.Ios ||
                    (this.Ios != null &&
                    this.Ios.Equals(input.Ios))
                ) && 
                (
                    this.Android == input.Android ||
                    (this.Android != null &&
                    this.Android.Equals(input.Android))
                ) && 
                (
                    this.Desktop == input.Desktop ||
                    (this.Desktop != null &&
                    this.Desktop.Equals(input.Desktop))
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
                if (this.Ios != null)
                    hashCode = hashCode * 59 + this.Ios.GetHashCode();
                if (this.Android != null)
                    hashCode = hashCode * 59 + this.Android.GetHashCode();
                if (this.Desktop != null)
                    hashCode = hashCode * 59 + this.Desktop.GetHashCode();
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
