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
    /// 获取当前用户的某个通用模块
    /// </summary>
    [DataContract]
    public partial class GenericModule :  IEquatable<GenericModule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericModule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenericModule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericModule" /> class.
        /// </summary>
        /// <param name="Id">通用模块的ID (required).</param>
        /// <param name="DeviceIdentifier">设备标识字符串 cf. 总则§2.3 (required).</param>
        /// <param name="Name">通用模块的名字 (required).</param>
        /// <param name="Position">排序用的序号.</param>
        /// <param name="DeviceIp">通用模块的设备地址.</param>
        /// <param name="RouterId">通用模块的路由ID.</param>
        /// <param name="HouseId">通用模块的房子ID.</param>
        /// <param name="Connectivity">在线状态说明 cf. 总则§? (required).</param>
        /// <param name="Vid">厂商标识符 (required).</param>
        /// <param name="Pid">设备标识符 (required).</param>
        /// <param name="CreatedAt">记录的创建日期.</param>
        /// <param name="UpdatedAt">记录的更新日期.</param>
        /// <param name="DeathQrCode">设备的死亡二维码，即删除后的设备会获得的一个二维码，这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用.</param>
        public GenericModule(int? Id = default(int?), string DeviceIdentifier = default(string), string Name = default(string), int? Position = default(int?), int? DeviceIp = default(int?), int? RouterId = default(int?), int? HouseId = default(int?), string Connectivity = default(string), int? Vid = default(int?), int? Pid = default(int?), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?), QrCode DeathQrCode = default(QrCode))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for GenericModule and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "DeviceIdentifier" is required (not null)
            if (DeviceIdentifier == null)
            {
                throw new InvalidDataException("DeviceIdentifier is a required property for GenericModule and cannot be null");
            }
            else
            {
                this.DeviceIdentifier = DeviceIdentifier;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for GenericModule and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Connectivity" is required (not null)
            if (Connectivity == null)
            {
                throw new InvalidDataException("Connectivity is a required property for GenericModule and cannot be null");
            }
            else
            {
                this.Connectivity = Connectivity;
            }
            // to ensure "Vid" is required (not null)
            if (Vid == null)
            {
                throw new InvalidDataException("Vid is a required property for GenericModule and cannot be null");
            }
            else
            {
                this.Vid = Vid;
            }
            // to ensure "Pid" is required (not null)
            if (Pid == null)
            {
                throw new InvalidDataException("Pid is a required property for GenericModule and cannot be null");
            }
            else
            {
                this.Pid = Pid;
            }
            this.Position = Position;
            this.DeviceIp = DeviceIp;
            this.RouterId = RouterId;
            this.HouseId = HouseId;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.DeathQrCode = DeathQrCode;
        }
        
        /// <summary>
        /// 通用模块的ID
        /// </summary>
        /// <value>通用模块的ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// 设备标识字符串 cf. 总则§2.3
        /// </summary>
        /// <value>设备标识字符串 cf. 总则§2.3</value>
        [DataMember(Name="device_identifier", EmitDefaultValue=false)]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 通用模块的名字
        /// </summary>
        /// <value>通用模块的名字</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 排序用的序号
        /// </summary>
        /// <value>排序用的序号</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// 通用模块的设备地址
        /// </summary>
        /// <value>通用模块的设备地址</value>
        [DataMember(Name="device_ip", EmitDefaultValue=false)]
        public int? DeviceIp { get; set; }

        /// <summary>
        /// 通用模块的路由ID
        /// </summary>
        /// <value>通用模块的路由ID</value>
        [DataMember(Name="router_id", EmitDefaultValue=false)]
        public int? RouterId { get; set; }

        /// <summary>
        /// 通用模块的房子ID
        /// </summary>
        /// <value>通用模块的房子ID</value>
        [DataMember(Name="house_id", EmitDefaultValue=false)]
        public int? HouseId { get; set; }

        /// <summary>
        /// 在线状态说明 cf. 总则§?
        /// </summary>
        /// <value>在线状态说明 cf. 总则§?</value>
        [DataMember(Name="connectivity", EmitDefaultValue=false)]
        public string Connectivity { get; set; }

        /// <summary>
        /// 厂商标识符
        /// </summary>
        /// <value>厂商标识符</value>
        [DataMember(Name="vid", EmitDefaultValue=false)]
        public int? Vid { get; set; }

        /// <summary>
        /// 设备标识符
        /// </summary>
        /// <value>设备标识符</value>
        [DataMember(Name="pid", EmitDefaultValue=false)]
        public int? Pid { get; set; }

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
        /// 设备的死亡二维码，即删除后的设备会获得的一个二维码，这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用
        /// </summary>
        /// <value>设备的死亡二维码，即删除后的设备会获得的一个二维码，这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用</value>
        [DataMember(Name="death_qr_code", EmitDefaultValue=false)]
        public QrCode DeathQrCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericModule {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DeviceIdentifier: ").Append(DeviceIdentifier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  DeviceIp: ").Append(DeviceIp).Append("\n");
            sb.Append("  RouterId: ").Append(RouterId).Append("\n");
            sb.Append("  HouseId: ").Append(HouseId).Append("\n");
            sb.Append("  Connectivity: ").Append(Connectivity).Append("\n");
            sb.Append("  Vid: ").Append(Vid).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DeathQrCode: ").Append(DeathQrCode).Append("\n");
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
            return this.Equals(input as GenericModule);
        }

        /// <summary>
        /// Returns true if GenericModule instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericModule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericModule input)
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
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.DeviceIp == input.DeviceIp ||
                    (this.DeviceIp != null &&
                    this.DeviceIp.Equals(input.DeviceIp))
                ) && 
                (
                    this.RouterId == input.RouterId ||
                    (this.RouterId != null &&
                    this.RouterId.Equals(input.RouterId))
                ) && 
                (
                    this.HouseId == input.HouseId ||
                    (this.HouseId != null &&
                    this.HouseId.Equals(input.HouseId))
                ) && 
                (
                    this.Connectivity == input.Connectivity ||
                    (this.Connectivity != null &&
                    this.Connectivity.Equals(input.Connectivity))
                ) && 
                (
                    this.Vid == input.Vid ||
                    (this.Vid != null &&
                    this.Vid.Equals(input.Vid))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
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
                ) && 
                (
                    this.DeathQrCode == input.DeathQrCode ||
                    (this.DeathQrCode != null &&
                    this.DeathQrCode.Equals(input.DeathQrCode))
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
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.DeviceIp != null)
                    hashCode = hashCode * 59 + this.DeviceIp.GetHashCode();
                if (this.RouterId != null)
                    hashCode = hashCode * 59 + this.RouterId.GetHashCode();
                if (this.HouseId != null)
                    hashCode = hashCode * 59 + this.HouseId.GetHashCode();
                if (this.Connectivity != null)
                    hashCode = hashCode * 59 + this.Connectivity.GetHashCode();
                if (this.Vid != null)
                    hashCode = hashCode * 59 + this.Vid.GetHashCode();
                if (this.Pid != null)
                    hashCode = hashCode * 59 + this.Pid.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DeathQrCode != null)
                    hashCode = hashCode * 59 + this.DeathQrCode.GetHashCode();
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
