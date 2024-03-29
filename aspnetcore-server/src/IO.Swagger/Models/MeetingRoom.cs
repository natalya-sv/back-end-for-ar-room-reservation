/*
 * Room Reservation API
 *
 * A Simple IP Address API
 *
 * OpenAPI spec version: 0.1.9
 * 
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
    public partial class MeetingRoom : IEquatable<MeetingRoom>
    { 
        /// <summary>
        /// Gets or Sets MeetingRoomId
        /// </summary>
        [DataMember(Name="meetingRoomId")]
        public int? MeetingRoomId { get; private set; }

        /// <summary>
        /// Gets or Sets MeetingRoomName
        /// </summary>
        [DataMember(Name="meetingRoomName")]
        public string MeetingRoomName { get; set; }

        /// <summary>
        /// Gets or Sets MeetingRoomEmail
        /// </summary>
        [DataMember(Name="meetingRoomEmail")]
        public string MeetingRoomEmail { get; set; }

        /// <summary>
        /// Gets or Sets MeetingRoomLocation
        /// </summary>
        [DataMember(Name="meetingRoomLocation")]
        public Location MeetingRoomLocation { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="locationId")]
        public int? LocationId { get; set; }

        /// <summary>
        /// Gets or Sets MeetingRoomImage
        /// </summary>
        [DataMember(Name="meetingRoomImage")]
        public MeetingRoomImage MeetingRoomImage { get; set; }

        /// <summary>
        /// Gets or Sets MeetingRoomReservations
        /// </summary>
        [DataMember(Name="meetingRoomReservations")]
        public List<MeetingRoomReservation> MeetingRoomReservations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingRoom {\n");
            sb.Append("  MeetingRoomId: ").Append(MeetingRoomId).Append("\n");
            sb.Append("  MeetingRoomName: ").Append(MeetingRoomName).Append("\n");
            sb.Append("  MeetingRoomEmail: ").Append(MeetingRoomEmail).Append("\n");
            sb.Append("  MeetingRoomLocation: ").Append(MeetingRoomLocation).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  MeetingRoomImage: ").Append(MeetingRoomImage).Append("\n");
            sb.Append("  MeetingRoomReservations: ").Append(MeetingRoomReservations).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MeetingRoom)obj);
        }

        /// <summary>
        /// Returns true if MeetingRoom instances are equal
        /// </summary>
        /// <param name="other">Instance of MeetingRoom to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingRoom other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MeetingRoomId == other.MeetingRoomId ||
                    MeetingRoomId != null &&
                    MeetingRoomId.Equals(other.MeetingRoomId)
                ) && 
                (
                    MeetingRoomName == other.MeetingRoomName ||
                    MeetingRoomName != null &&
                    MeetingRoomName.Equals(other.MeetingRoomName)
                ) && 
                (
                    MeetingRoomEmail == other.MeetingRoomEmail ||
                    MeetingRoomEmail != null &&
                    MeetingRoomEmail.Equals(other.MeetingRoomEmail)
                ) && 
                (
                    MeetingRoomLocation == other.MeetingRoomLocation ||
                    MeetingRoomLocation != null &&
                    MeetingRoomLocation.Equals(other.MeetingRoomLocation)
                ) && 
                (
                    LocationId == other.LocationId ||
                    LocationId != null &&
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    MeetingRoomImage == other.MeetingRoomImage ||
                    MeetingRoomImage != null &&
                    MeetingRoomImage.Equals(other.MeetingRoomImage)
                ) && 
                (
                    MeetingRoomReservations == other.MeetingRoomReservations ||
                    MeetingRoomReservations != null &&
                    MeetingRoomReservations.SequenceEqual(other.MeetingRoomReservations)
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
                    if (MeetingRoomId != null)
                    hashCode = hashCode * 59 + MeetingRoomId.GetHashCode();
                    if (MeetingRoomName != null)
                    hashCode = hashCode * 59 + MeetingRoomName.GetHashCode();
                    if (MeetingRoomEmail != null)
                    hashCode = hashCode * 59 + MeetingRoomEmail.GetHashCode();
                    if (MeetingRoomLocation != null)
                    hashCode = hashCode * 59 + MeetingRoomLocation.GetHashCode();
                    if (LocationId != null)
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    if (MeetingRoomImage != null)
                    hashCode = hashCode * 59 + MeetingRoomImage.GetHashCode();
                    if (MeetingRoomReservations != null)
                    hashCode = hashCode * 59 + MeetingRoomReservations.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MeetingRoom left, MeetingRoom right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MeetingRoom left, MeetingRoom right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
