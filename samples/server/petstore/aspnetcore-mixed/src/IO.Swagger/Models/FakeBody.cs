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
    public partial class FakeBody : IEquatable<FakeBody>
    { 
        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>

        [Range(10, 100)]
        [DataMember(Name="integer")]
        public int? Integer { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>

        [Range(20, 200)]
        [DataMember(Name="int32")]
        public int? Int32 { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>

        [DataMember(Name="int64")]
        public long? Int64 { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [Required]

        [Range(32, 543)]
        [DataMember(Name="number")]
        public decimal? Number { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>

        [DataMember(Name="float")]
        public float? _Float { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [Required]

        [Range(67, 123)]
        [DataMember(Name="double")]
        public double? _Double { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [RegularExpression("/[a-z]/i")]
        [DataMember(Name="string")]
        public string _String { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [Required]
        [RegularExpression("/^[A-Z].*/")]
        [DataMember(Name="pattern_without_delimiter")]
        public string PatternWithoutDelimiter { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [Required]

        [DataMember(Name="byte")]
        public byte[] _Byte { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>

        [DataMember(Name="binary")]
        public byte[] Binary { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>

        [DataMember(Name="date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>

        [DataMember(Name="dateTime")]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>

        [DataMember(Name="password")]
        public string Password { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>

        [DataMember(Name="callback")]
        public string Callback { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FakeBody {\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  _Float: ").Append(_Float).Append("\n");
            sb.Append("  _Double: ").Append(_Double).Append("\n");
            sb.Append("  _String: ").Append(_String).Append("\n");
            sb.Append("  PatternWithoutDelimiter: ").Append(PatternWithoutDelimiter).Append("\n");
            sb.Append("  _Byte: ").Append(_Byte).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Callback: ").Append(Callback).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FakeBody)obj);
        }

        /// <summary>
        /// Returns true if FakeBody instances are equal
        /// </summary>
        /// <param name="other">Instance of FakeBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FakeBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Integer == other.Integer ||
                    Integer != null &&
                    Integer.Equals(other.Integer)
                ) && 
                (
                    Int32 == other.Int32 ||
                    Int32 != null &&
                    Int32.Equals(other.Int32)
                ) && 
                (
                    Int64 == other.Int64 ||
                    Int64 != null &&
                    Int64.Equals(other.Int64)
                ) && 
                (
                    Number == other.Number ||
                    Number != null &&
                    Number.Equals(other.Number)
                ) && 
                (
                    _Float == other._Float ||
                    _Float != null &&
                    _Float.Equals(other._Float)
                ) && 
                (
                    _Double == other._Double ||
                    _Double != null &&
                    _Double.Equals(other._Double)
                ) && 
                (
                    _String == other._String ||
                    _String != null &&
                    _String.Equals(other._String)
                ) && 
                (
                    PatternWithoutDelimiter == other.PatternWithoutDelimiter ||
                    PatternWithoutDelimiter != null &&
                    PatternWithoutDelimiter.Equals(other.PatternWithoutDelimiter)
                ) && 
                (
                    _Byte == other._Byte ||
                    _Byte != null &&
                    _Byte.Equals(other._Byte)
                ) && 
                (
                    Binary == other.Binary ||
                    Binary != null &&
                    Binary.Equals(other.Binary)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    DateTime == other.DateTime ||
                    DateTime != null &&
                    DateTime.Equals(other.DateTime)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
                ) && 
                (
                    Callback == other.Callback ||
                    Callback != null &&
                    Callback.Equals(other.Callback)
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
                    if (Integer != null)
                    hashCode = hashCode * 59 + Integer.GetHashCode();
                    if (Int32 != null)
                    hashCode = hashCode * 59 + Int32.GetHashCode();
                    if (Int64 != null)
                    hashCode = hashCode * 59 + Int64.GetHashCode();
                    if (Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();
                    if (_Float != null)
                    hashCode = hashCode * 59 + _Float.GetHashCode();
                    if (_Double != null)
                    hashCode = hashCode * 59 + _Double.GetHashCode();
                    if (_String != null)
                    hashCode = hashCode * 59 + _String.GetHashCode();
                    if (PatternWithoutDelimiter != null)
                    hashCode = hashCode * 59 + PatternWithoutDelimiter.GetHashCode();
                    if (_Byte != null)
                    hashCode = hashCode * 59 + _Byte.GetHashCode();
                    if (Binary != null)
                    hashCode = hashCode * 59 + Binary.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (DateTime != null)
                    hashCode = hashCode * 59 + DateTime.GetHashCode();
                    if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                    if (Callback != null)
                    hashCode = hashCode * 59 + Callback.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FakeBody left, FakeBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FakeBody left, FakeBody right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
