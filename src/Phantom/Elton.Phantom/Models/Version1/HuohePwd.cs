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
    /// 删除密码
    /// </summary>
    [DataContract]
    public partial class HuohePwd :  IEquatable<HuohePwd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HuohePwd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HuohePwd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HuohePwd" /> class.
        /// </summary>
        /// <param name="Id">密码ID (required).</param>
        /// <param name="HuoheLockId">门锁ID (required).</param>
        /// <param name="Pwd">密码 (required).</param>
        /// <param name="Name">名称 (required).</param>
        /// <param name="Mobile">手机号 (required).</param>
        /// <param name="PwdNo">密码编号 (required).</param>
        public HuohePwd(int? Id = default(int?), int? HuoheLockId = default(int?), string Pwd = default(string), string Name = default(string), int? Mobile = default(int?), string PwdNo = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for HuohePwd and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "HuoheLockId" is required (not null)
            if (HuoheLockId == null)
            {
                throw new InvalidDataException("HuoheLockId is a required property for HuohePwd and cannot be null");
            }
            else
            {
                this.HuoheLockId = HuoheLockId;
            }
            // to ensure "Pwd" is required (not null)
            if (Pwd == null)
            {
                throw new InvalidDataException("Pwd is a required property for HuohePwd and cannot be null");
            }
            else
            {
                this.Pwd = Pwd;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for HuohePwd and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Mobile" is required (not null)
            if (Mobile == null)
            {
                throw new InvalidDataException("Mobile is a required property for HuohePwd and cannot be null");
            }
            else
            {
                this.Mobile = Mobile;
            }
            // to ensure "PwdNo" is required (not null)
            if (PwdNo == null)
            {
                throw new InvalidDataException("PwdNo is a required property for HuohePwd and cannot be null");
            }
            else
            {
                this.PwdNo = PwdNo;
            }
        }
        
        /// <summary>
        /// 密码ID
        /// </summary>
        /// <value>密码ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// 门锁ID
        /// </summary>
        /// <value>门锁ID</value>
        [DataMember(Name="huohe_lock_id", EmitDefaultValue=false)]
        public int? HuoheLockId { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        /// <value>密码</value>
        [DataMember(Name="pwd", EmitDefaultValue=false)]
        public string Pwd { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        /// <value>名称</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value>手机号</value>
        [DataMember(Name="mobile", EmitDefaultValue=false)]
        public int? Mobile { get; set; }

        /// <summary>
        /// 密码编号
        /// </summary>
        /// <value>密码编号</value>
        [DataMember(Name="pwd_no", EmitDefaultValue=false)]
        public string PwdNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HuohePwd {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  HuoheLockId: ").Append(HuoheLockId).Append("\n");
            sb.Append("  Pwd: ").Append(Pwd).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  PwdNo: ").Append(PwdNo).Append("\n");
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
            return this.Equals(input as HuohePwd);
        }

        /// <summary>
        /// Returns true if HuohePwd instances are equal
        /// </summary>
        /// <param name="input">Instance of HuohePwd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HuohePwd input)
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
                    this.HuoheLockId == input.HuoheLockId ||
                    (this.HuoheLockId != null &&
                    this.HuoheLockId.Equals(input.HuoheLockId))
                ) && 
                (
                    this.Pwd == input.Pwd ||
                    (this.Pwd != null &&
                    this.Pwd.Equals(input.Pwd))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.PwdNo == input.PwdNo ||
                    (this.PwdNo != null &&
                    this.PwdNo.Equals(input.PwdNo))
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
                if (this.HuoheLockId != null)
                    hashCode = hashCode * 59 + this.HuoheLockId.GetHashCode();
                if (this.Pwd != null)
                    hashCode = hashCode * 59 + this.Pwd.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Mobile != null)
                    hashCode = hashCode * 59 + this.Mobile.GetHashCode();
                if (this.PwdNo != null)
                    hashCode = hashCode * 59 + this.PwdNo.GetHashCode();
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
