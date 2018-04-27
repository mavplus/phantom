#region License

//   Copyright 2014 Elton FAN (eltonfan@live.cn, http://elton.io)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Elton.Phantom.Models.Version1
{
    /// <summary>
    /// 刷新一个令牌
    /// </summary>
    [DataContract]
    public partial class Token :  IEquatable<Token>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        [JsonConstructor]
        protected Token() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="AccessToken">访问令牌 cf. RFC6749 (required).</param>
        /// <param name="TokenType">设备的名字 cf. RFC6749 (required).</param>
        /// <param name="RefreshToken">刷新令牌 cf. RFC6749 (required).</param>
        /// <param name="ExpiresIn">几秒后过期 cf. RFC6749 (required).</param>
        /// <param name="UserAgent">客户端.</param>
        /// <param name="Timestamp">utc的时间戳 (单位: 秒).</param>
        public Token(string AccessToken = default, string TokenType = default, string RefreshToken = default, int? ExpiresIn = default, string UserAgent = default, int? Timestamp = default)
        {
            // to ensure "AccessToken" is required (not null)
            this.AccessToken = AccessToken ?? throw new InvalidDataException("AccessToken is a required property for Token and cannot be null");
            // to ensure "TokenType" is required (not null)
            this.TokenType = TokenType ?? throw new InvalidDataException("TokenType is a required property for Token and cannot be null");
            // to ensure "RefreshToken" is required (not null)
            this.RefreshToken = RefreshToken ?? throw new InvalidDataException("RefreshToken is a required property for Token and cannot be null");
            // to ensure "ExpiresIn" is required (not null)
            this.ExpiresIn = ExpiresIn ?? throw new InvalidDataException("ExpiresIn is a required property for Token and cannot be null");

            this.UserAgent = UserAgent;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// 访问令牌 cf. RFC6749
        /// </summary>
        /// <value>访问令牌 cf. RFC6749</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 设备的名字 cf. RFC6749
        /// </summary>
        /// <value>设备的名字 cf. RFC6749</value>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// 刷新令牌 cf. RFC6749
        /// </summary>
        /// <value>刷新令牌 cf. RFC6749</value>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 几秒后过期 cf. RFC6749
        /// </summary>
        /// <value>几秒后过期 cf. RFC6749</value>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 客户端
        /// </summary>
        /// <value>客户端</value>
        [Obsolete]
        [DataMember(Name="user_agent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// utc的时间戳 (单位: 秒)
        /// </summary>
        /// <value>utc的时间戳 (单位: 秒)</value>
        [Obsolete]
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Token {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as Token);
        }

        /// <summary>
        /// Returns true if Token instances are equal
        /// </summary>
        /// <param name="input">Instance of Token to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Token input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.ExpiresIn != null)
                    hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        //
        // https://github.com/HuanTeng/huanteng.github.io/blob/master/oauth.md
        // 刷新一个令牌。文档有误，以下两个字段不存在：
        // user_agent
        // timestamp

        /// <summary>
        /// 客户端
        /// </summary>
        //[JsonProperty("user_agent")]
        //public string UserAgent { get; set; }
        /// <summary>
        /// utc的时间戳(单位: 秒)
        /// </summary>
        //[JsonProperty("timestamp")]
        //public int Timestamp { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public int CreatedAt { get; set; }

        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scopes { get; set; }
    }
}
