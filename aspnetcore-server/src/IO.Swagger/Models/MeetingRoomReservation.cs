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
    public partial class MeetingRoomReservation : IEquatable<MeetingRoomReservation>
    { 
        /// <summary>
        /// Gets or Sets MeetingRoomReservationId
        /// </summary>
        [DataMember(Name="meetingRoomReservationId")]
        public int? MeetingRoomReservationId { get; private set; }

        /// <summary>
        /// Gets or Sets MeetingDate
        /// </summary>
        [DataMember(Name="meetingDate")]
        public DateTime? MeetingDate { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime")]
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime")]
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Gets or Sets MeetingTopic
        /// </summary>
        [DataMember(Name="meetingTopic")]
        public string MeetingTopic { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user")]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets MeetingRoom
        /// </summary>
        [DataMember(Name="meetingRoom")]
        public MeetingRoom MeetingRoom { get; set; }

        /// <summary>
        /// Gets or Sets MeetingRoomId
        /// </summary>
        [DataMember(Name="meetingRoomId")]
        public int? MeetingRoomId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingRoomReservation {\n");
            sb.Append("  MeetingRoomReservationId: ").Append(MeetingRoomReservationId).Append("\n");
            sb.Append("  MeetingDate: ").Append(MeetingDate).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  MeetingTopic: ").Append(MeetingTopic).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  MeetingRoom: ").Append(MeetingRoom).Append("\n");
            sb.Append("  MeetingRoomId: ").Append(MeetingRoomId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MeetingRoomReservation)obj);
        }

        /// <summary>
        /// Returns true if MeetingRoomReservation instances are equal
        /// </summary>
        /// <param name="other">Instance of MeetingRoomReservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingRoomReservation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MeetingRoomReservationId == other.MeetingRoomReservationId ||
                    MeetingRoomReservationId != null &&
                    MeetingRoomReservationId.Equals(other.MeetingRoomReservationId)
                ) && 
                (
                    MeetingDate == other.MeetingDate ||
                    MeetingDate != null &&
                    MeetingDate.Equals(other.MeetingDate)
                ) && 
                (
                    StartTime == other.StartTime ||
                    StartTime != null &&
                    StartTime.Equals(other.StartTime)
                ) && 
                (
                    EndTime == other.EndTime ||
                    EndTime != null &&
                    EndTime.Equals(other.EndTime)
                ) && 
                (
                    MeetingTopic == other.MeetingTopic ||
                    MeetingTopic != null &&
                    MeetingTopic.Equals(other.MeetingTopic)
                ) && 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
                ) && 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    MeetingRoom == other.MeetingRoom ||
                    MeetingRoom != null &&
                    MeetingRoom.Equals(other.MeetingRoom)
                ) && 
                (
                    MeetingRoomId == other.MeetingRoomId ||
                    MeetingRoomId != null &&
                    MeetingRoomId.Equals(other.MeetingRoomId)
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
                    if (MeetingRoomReservationId != null)
                    hashCode = hashCode * 59 + MeetingRoomReservationId.GetHashCode();
                    if (MeetingDate != null)
                    hashCode = hashCode * 59 + MeetingDate.GetHashCode();
                    if (StartTime != null)
                    hashCode = hashCode * 59 + StartTime.GetHashCode();
                    if (EndTime != null)
                    hashCode = hashCode * 59 + EndTime.GetHashCode();
                    if (MeetingTopic != null)
                    hashCode = hashCode * 59 + MeetingTopic.GetHashCode();
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (MeetingRoom != null)
                    hashCode = hashCode * 59 + MeetingRoom.GetHashCode();
                    if (MeetingRoomId != null)
                    hashCode = hashCode * 59 + MeetingRoomId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MeetingRoomReservation left, MeetingRoomReservation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MeetingRoomReservation left, MeetingRoomReservation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
