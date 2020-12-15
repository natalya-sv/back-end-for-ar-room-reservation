using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Models
{
	public class NewMeetingRoomReservation
	{
        public int MeetingRoomId;
        public DateTime MeetingDate;
        public TimeSpan StartTime;
        public TimeSpan EndTime;
        public int UserId;
        public string MeetingTopic;
	}
}
