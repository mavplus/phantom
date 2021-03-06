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
    /// ScenarioContentItem
    /// </summary>
    [DataContract]
    public partial class ScenarioContentItem :  IEquatable<ScenarioContentItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioContentItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScenarioContentItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioContentItem" /> class.
        /// </summary>
        /// <param name="Id">ID (required).</param>
        /// <param name="ScenarioId">情景ID (required).</param>
        /// <param name="Type">类别，目前可填写ScenarioContentItems::Bulb或ScenarioContentItems::EcoTower或ScenarioContentItems::GenericModule或ScenarioContentItems::MeterSwitchModule (required).</param>
        /// <param name="DeviceType">设备类型.</param>
        /// <param name="DeviceName">SCI对应设备名及id (required).</param>
        /// <param name="TurnedOn">目标开／关状态 (required).</param>
        /// <param name="BulbId">目标灯泡的ID (required).</param>
        /// <param name="Brightness">目标灯泡的目标亮度.</param>
        /// <param name="Hue">目标灯泡的目标色温.</param>
        /// <param name="EcoTowerId">目标EcoTower的ID.</param>
        /// <param name="TargetTemperature">目标EcoTower的目标温度.</param>
        /// <param name="Mode">窗帘的mode.</param>
        /// <param name="GenericModuleId">目标通用模块的id.</param>
        /// <param name="Info">通用模块指令的json数据.</param>
        /// <param name="Stash">App要求的暂存数据.</param>
        /// <param name="DoorAccessId">门禁id.</param>
        public ScenarioContentItem(int? Id = default(int?), int? ScenarioId = default(int?), string Type = default(string), string DeviceType = default(string), string DeviceName = default(string), bool? TurnedOn = default(bool?), int? BulbId = default(int?), float? Brightness = default(float?), float? Hue = default(float?), int? EcoTowerId = default(int?), int? TargetTemperature = default(int?), int? Mode = default(int?), int? GenericModuleId = default(int?), string Info = default(string), string Stash = default(string), int? DoorAccessId = default(int?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ScenarioContentItem and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "ScenarioId" is required (not null)
            if (ScenarioId == null)
            {
                throw new InvalidDataException("ScenarioId is a required property for ScenarioContentItem and cannot be null");
            }
            else
            {
                this.ScenarioId = ScenarioId;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ScenarioContentItem and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "DeviceName" is required (not null)
            if (DeviceName == null)
            {
                throw new InvalidDataException("DeviceName is a required property for ScenarioContentItem and cannot be null");
            }
            else
            {
                this.DeviceName = DeviceName;
            }
            // to ensure "TurnedOn" is required (not null)
            if (TurnedOn == null)
            {
                throw new InvalidDataException("TurnedOn is a required property for ScenarioContentItem and cannot be null");
            }
            else
            {
                this.TurnedOn = TurnedOn;
            }
            // to ensure "BulbId" is required (not null)
            if (BulbId == null)
            {
                throw new InvalidDataException("BulbId is a required property for ScenarioContentItem and cannot be null");
            }
            else
            {
                this.BulbId = BulbId;
            }
            this.DeviceType = DeviceType;
            this.Brightness = Brightness;
            this.Hue = Hue;
            this.EcoTowerId = EcoTowerId;
            this.TargetTemperature = TargetTemperature;
            this.Mode = Mode;
            this.GenericModuleId = GenericModuleId;
            this.Info = Info;
            this.Stash = Stash;
            this.DoorAccessId = DoorAccessId;
        }
        
        /// <summary>
        /// ID
        /// </summary>
        /// <value>ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// 情景ID
        /// </summary>
        /// <value>情景ID</value>
        [DataMember(Name="scenario_id", EmitDefaultValue=false)]
        public int? ScenarioId { get; set; }

        /// <summary>
        /// 类别，目前可填写ScenarioContentItems::Bulb或ScenarioContentItems::EcoTower或ScenarioContentItems::GenericModule或ScenarioContentItems::MeterSwitchModule
        /// </summary>
        /// <value>类别，目前可填写ScenarioContentItems::Bulb或ScenarioContentItems::EcoTower或ScenarioContentItems::GenericModule或ScenarioContentItems::MeterSwitchModule</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        /// <value>设备类型</value>
        [DataMember(Name="device_type", EmitDefaultValue=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// SCI对应设备名及id
        /// </summary>
        /// <value>SCI对应设备名及id</value>
        [DataMember(Name="device_name", EmitDefaultValue=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// 目标开／关状态
        /// </summary>
        /// <value>目标开／关状态</value>
        [DataMember(Name="turned_on", EmitDefaultValue=false)]
        public bool? TurnedOn { get; set; }

        /// <summary>
        /// 目标灯泡的ID
        /// </summary>
        /// <value>目标灯泡的ID</value>
        [DataMember(Name="bulb_id", EmitDefaultValue=false)]
        public int? BulbId { get; set; }

        /// <summary>
        /// 目标灯泡的目标亮度
        /// </summary>
        /// <value>目标灯泡的目标亮度</value>
        [DataMember(Name="brightness", EmitDefaultValue=false)]
        public float? Brightness { get; set; }

        /// <summary>
        /// 目标灯泡的目标色温
        /// </summary>
        /// <value>目标灯泡的目标色温</value>
        [DataMember(Name="hue", EmitDefaultValue=false)]
        public float? Hue { get; set; }

        /// <summary>
        /// 目标EcoTower的ID
        /// </summary>
        /// <value>目标EcoTower的ID</value>
        [DataMember(Name="eco_tower_id", EmitDefaultValue=false)]
        public int? EcoTowerId { get; set; }

        /// <summary>
        /// 目标EcoTower的目标温度
        /// </summary>
        /// <value>目标EcoTower的目标温度</value>
        [DataMember(Name="target_temperature", EmitDefaultValue=false)]
        public int? TargetTemperature { get; set; }

        /// <summary>
        /// 窗帘的mode
        /// </summary>
        /// <value>窗帘的mode</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public int? Mode { get; set; }

        /// <summary>
        /// 目标通用模块的id
        /// </summary>
        /// <value>目标通用模块的id</value>
        [DataMember(Name="generic_module_id", EmitDefaultValue=false)]
        public int? GenericModuleId { get; set; }

        /// <summary>
        /// 通用模块指令的json数据
        /// </summary>
        /// <value>通用模块指令的json数据</value>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public string Info { get; set; }

        /// <summary>
        /// App要求的暂存数据
        /// </summary>
        /// <value>App要求的暂存数据</value>
        [DataMember(Name="stash", EmitDefaultValue=false)]
        public string Stash { get; set; }

        /// <summary>
        /// 门禁id
        /// </summary>
        /// <value>门禁id</value>
        [DataMember(Name="door_access_id", EmitDefaultValue=false)]
        public int? DoorAccessId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScenarioContentItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  TurnedOn: ").Append(TurnedOn).Append("\n");
            sb.Append("  BulbId: ").Append(BulbId).Append("\n");
            sb.Append("  Brightness: ").Append(Brightness).Append("\n");
            sb.Append("  Hue: ").Append(Hue).Append("\n");
            sb.Append("  EcoTowerId: ").Append(EcoTowerId).Append("\n");
            sb.Append("  TargetTemperature: ").Append(TargetTemperature).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  GenericModuleId: ").Append(GenericModuleId).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Stash: ").Append(Stash).Append("\n");
            sb.Append("  DoorAccessId: ").Append(DoorAccessId).Append("\n");
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
            return this.Equals(input as ScenarioContentItem);
        }

        /// <summary>
        /// Returns true if ScenarioContentItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioContentItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioContentItem input)
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
                    this.ScenarioId == input.ScenarioId ||
                    (this.ScenarioId != null &&
                    this.ScenarioId.Equals(input.ScenarioId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) && 
                (
                    this.TurnedOn == input.TurnedOn ||
                    (this.TurnedOn != null &&
                    this.TurnedOn.Equals(input.TurnedOn))
                ) && 
                (
                    this.BulbId == input.BulbId ||
                    (this.BulbId != null &&
                    this.BulbId.Equals(input.BulbId))
                ) && 
                (
                    this.Brightness == input.Brightness ||
                    (this.Brightness != null &&
                    this.Brightness.Equals(input.Brightness))
                ) && 
                (
                    this.Hue == input.Hue ||
                    (this.Hue != null &&
                    this.Hue.Equals(input.Hue))
                ) && 
                (
                    this.EcoTowerId == input.EcoTowerId ||
                    (this.EcoTowerId != null &&
                    this.EcoTowerId.Equals(input.EcoTowerId))
                ) && 
                (
                    this.TargetTemperature == input.TargetTemperature ||
                    (this.TargetTemperature != null &&
                    this.TargetTemperature.Equals(input.TargetTemperature))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.GenericModuleId == input.GenericModuleId ||
                    (this.GenericModuleId != null &&
                    this.GenericModuleId.Equals(input.GenericModuleId))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.Stash == input.Stash ||
                    (this.Stash != null &&
                    this.Stash.Equals(input.Stash))
                ) && 
                (
                    this.DoorAccessId == input.DoorAccessId ||
                    (this.DoorAccessId != null &&
                    this.DoorAccessId.Equals(input.DoorAccessId))
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
                if (this.ScenarioId != null)
                    hashCode = hashCode * 59 + this.ScenarioId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.DeviceName != null)
                    hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.TurnedOn != null)
                    hashCode = hashCode * 59 + this.TurnedOn.GetHashCode();
                if (this.BulbId != null)
                    hashCode = hashCode * 59 + this.BulbId.GetHashCode();
                if (this.Brightness != null)
                    hashCode = hashCode * 59 + this.Brightness.GetHashCode();
                if (this.Hue != null)
                    hashCode = hashCode * 59 + this.Hue.GetHashCode();
                if (this.EcoTowerId != null)
                    hashCode = hashCode * 59 + this.EcoTowerId.GetHashCode();
                if (this.TargetTemperature != null)
                    hashCode = hashCode * 59 + this.TargetTemperature.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.GenericModuleId != null)
                    hashCode = hashCode * 59 + this.GenericModuleId.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.Stash != null)
                    hashCode = hashCode * 59 + this.Stash.GetHashCode();
                if (this.DoorAccessId != null)
                    hashCode = hashCode * 59 + this.DoorAccessId.GetHashCode();
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
