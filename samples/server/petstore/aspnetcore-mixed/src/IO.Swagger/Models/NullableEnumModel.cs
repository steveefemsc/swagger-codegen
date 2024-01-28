/*
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class NullableEnumModel : IEquatable<NullableEnumModel>
    { 
        /// <summary>
        /// Gets or Sets EnumProp
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum EnumPropEnum
        {
            /// <summary>
            /// Enum AEnum for a
            /// </summary>
            [EnumMember(Value = "a")]
            AEnum = 0,
            /// <summary>
            /// Enum BEnum for b
            /// </summary>
            [EnumMember(Value = "b")]
            BEnum = 1,
            /// <summary>
            /// Enum NullEnum for null
            /// </summary>
            [EnumMember(Value = null)]
            NullEnum = 2        }

        /// <summary>
        /// Gets or Sets EnumProp
        /// </summary>

        [DataMember(Name="enumProp")]
        public EnumPropEnum? EnumProp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NullableEnumModel {\n");
            sb.Append("  EnumProp: ").Append(EnumProp).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((NullableEnumModel)obj);
        }

        /// <summary>
        /// Returns true if NullableEnumModel instances are equal
        /// </summary>
        /// <param name="other">Instance of NullableEnumModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NullableEnumModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EnumProp == other.EnumProp ||
                    EnumProp != null &&
                    EnumProp.Equals(other.EnumProp)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (EnumProp != null)
                    hashCode = hashCode * 59 + EnumProp.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NullableEnumModel left, NullableEnumModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NullableEnumModel left, NullableEnumModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
