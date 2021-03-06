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
    /// 控制地暖
    /// </summary>
    [DataContract]
    public partial class RadiantFloor :  IEquatable<RadiantFloor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiantFloor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RadiantFloor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiantFloor" /> class.
        /// </summary>
        /// <param name="Id">ID (required).</param>
        /// <param name="DeviceIdentifier">设备标识字符串 (required).</param>
        /// <param name="Name">名字 (required).</param>
        /// <param name="UserId">账户ID (required).</param>
        /// <param name="HouseId">房间ID.</param>
        public RadiantFloor(int? Id = default(int?), string DeviceIdentifier = default(string), string Name = default(string), int? UserId = default(int?), int? HouseId = default(int?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for RadiantFloor and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "DeviceIdentifier" is required (not null)
            if (DeviceIdentifier == null)
            {
                throw new InvalidDataException("DeviceIdentifier is a required property for RadiantFloor and cannot be null");
            }
            else
            {
                this.DeviceIdentifier = DeviceIdentifier;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for RadiantFloor and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for RadiantFloor and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            this.HouseId = HouseId;
        }
        
        /// <summary>
        /// ID
        /// </summary>
        /// <value>ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// 设备标识字符串
        /// </summary>
        /// <value>设备标识字符串</value>
        [DataMember(Name="device_identifier", EmitDefaultValue=false)]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        /// <value>名字</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 账户ID
        /// </summary>
        /// <value>账户ID</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// 房间ID
        /// </summary>
        /// <value>房间ID</value>
        [DataMember(Name="house_id", EmitDefaultValue=false)]
        public int? HouseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadiantFloor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DeviceIdentifier: ").Append(DeviceIdentifier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  HouseId: ").Append(HouseId).Append("\n");
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
            return this.Equals(input as RadiantFloor);
        }

        /// <summary>
        /// Returns true if RadiantFloor instances are equal
        /// </summary>
        /// <param name="input">Instance of RadiantFloor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadiantFloor input)
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
                    this.DeviceIdentifier == input.DeviceIdentifier ||
                    (this.DeviceIdentifier != null &&
                    this.DeviceIdentifier.Equals(input.DeviceIdentifier))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.HouseId == input.HouseId ||
                    (this.HouseId != null &&
                    this.HouseId.Equals(input.HouseId))
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
                if (this.DeviceIdentifier != null)
                    hashCode = hashCode * 59 + this.DeviceIdentifier.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.HouseId != null)
                    hashCode = hashCode * 59 + this.HouseId.GetHashCode();
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
