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
    /// 删除当前用户（开发者）的某客户端应用
    /// </summary>
    [DataContract]
    public partial class ClientApp :  IEquatable<ClientApp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientApp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApp" /> class.
        /// </summary>
        /// <param name="Id">客户端的ID (required).</param>
        /// <param name="Name">客户端应用的名字 (required).</param>
        /// <param name="Description">客户端应用简短介绍.</param>
        /// <param name="AppId">键.</param>
        /// <param name="AppSecret">密.</param>
        /// <param name="CreatedAt">记录的创建日期.</param>
        /// <param name="UpdatedAt">记录的更新日期.</param>
        public ClientApp(int? Id = default(int?), string Name = default(string), string Description = default(string), string AppId = default(string), string AppSecret = default(string), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ClientApp and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ClientApp and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Description = Description;
            this.AppId = AppId;
            this.AppSecret = AppSecret;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// 客户端的ID
        /// </summary>
        /// <value>客户端的ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// 客户端应用的名字
        /// </summary>
        /// <value>客户端应用的名字</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 客户端应用简短介绍
        /// </summary>
        /// <value>客户端应用简短介绍</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// 键
        /// </summary>
        /// <value>键</value>
        [DataMember(Name="app_id", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 密
        /// </summary>
        /// <value>密</value>
        [DataMember(Name="app_secret", EmitDefaultValue=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// 记录的创建日期
        /// </summary>
        /// <value>记录的创建日期</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 记录的更新日期
        /// </summary>
        /// <value>记录的更新日期</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientApp {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  AppSecret: ").Append(AppSecret).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as ClientApp);
        }

        /// <summary>
        /// Returns true if ClientApp instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientApp input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.AppSecret == input.AppSecret ||
                    (this.AppSecret != null &&
                    this.AppSecret.Equals(input.AppSecret))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppSecret != null)
                    hashCode = hashCode * 59 + this.AppSecret.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
