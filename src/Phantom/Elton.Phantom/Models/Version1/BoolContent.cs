/* 
 * Version 1
 *
 * This is version 1 document
 *
 * OpenAPI spec version: 0.0.2
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
using SwaggerDateConverter = Elton.Phantom.Models.SwaggerDateConverter;

namespace Elton.Phantom.Models.Version1
{
    /// <summary>
    /// 获取当前用户的某个通用模块的某个布尔量
    /// </summary>
    [DataContract]
    public partial class BoolContent :  IEquatable<BoolContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoolContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BoolContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoolContent" /> class.
        /// </summary>
        /// <param name="Content">内容，true或者false (required).</param>
        public BoolContent(bool? Content = default(bool?))
        {
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for BoolContent and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
        }
        
        /// <summary>
        /// 内容，true或者false
        /// </summary>
        /// <value>内容，true或者false</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public bool? Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoolContent {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as BoolContent);
        }

        /// <summary>
        /// Returns true if BoolContent instances are equal
        /// </summary>
        /// <param name="input">Instance of BoolContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoolContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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
