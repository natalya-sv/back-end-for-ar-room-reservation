using IO.Swagger.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IO.Swagger.Database
{
	public class Initializer
	{
		public static void Initialize(ProjectContext context)
		{
			context.Database.EnsureCreated();
			if (context.MeetingRoomReservations.Any())
			{
				return;
			}

			//add images
			var sleepImage = File.ReadAllBytes("images/imageOne.jpg");
			var liveImage = File.ReadAllBytes("images/imageTwo.jpg");
			var hallImage = File.ReadAllBytes("images/imageThree.jpg");
			var cities = new City[]
			{
				new City { CityName="CityOne"},
				new City { CityName="CityTwo"},
				new City { CityName="CityThree"},
				new City { CityName="CityFour"},
				new City { CityName="CityFive"},
			};

			context.Cities.AddRange(cities);
			context.SaveChanges();

			var locations = new Location[5];

			for (var i = 0; i < 5; i++)
			{
				locations[i] = new Location { City = cities[i] };
			}

			context.Locations.AddRange(locations);
			context.SaveChanges();

			var spots = new WorkingSpot[40];

			var spotPosition = 0;
			for (var i = 0; i < 5; i++)
			{
				for (var j = 0; j < 8; j++)
				{
					var spot = new WorkingSpot { LocationId = locations[i].LocationId };
					spots[spotPosition] = spot;
					spotPosition++;
				}
			}
			context.WorkingSpots.AddRange(spots);
			context.SaveChanges();

			var jobs = new Job[]
			{
				new Job { JobTitle= "Doctor"},
				new Job { JobTitle= "Teacher"},
				new Job { JobTitle= "Driver"}
			};
			context.Jobs.AddRange(jobs);
			context.SaveChanges();

			var users = new User[]
			{
				new User { Name = "Person", Surname = "PersonName", Email = "p@email", Job = jobs[0],Password = "123456"},
				new User { Name = "Person", Surname = "PersonName", Email = "r@email", Job = jobs[1], Password = "987654"},
				new User { Name = "Person", Surname = "PersonName", Email = "s@eail", Job = jobs[2], Password= "qwerty" }
			};
			context.Users.AddRange(users);
			context.SaveChanges();

			var workingSpotReservations = new WorkingSpotReservation[]
			{
				new WorkingSpotReservation {  ReservationDate= DateTime.Now,WorkingSpotId=spots[0].WorkingSpotId,  UserId = users[0].UserId},
				new WorkingSpotReservation {  ReservationDate=DateTime.Now, WorkingSpotId=spots[1].WorkingSpotId,  UserId = users[1].UserId},
				new WorkingSpotReservation {  ReservationDate=DateTime.Now,WorkingSpotId=spots[2].WorkingSpotId,  UserId = users[2].UserId}
			};
			context.WorkingSpotReservations.AddRange(workingSpotReservations);
			context.SaveChanges();

			var images = new List<MeetingRoomImage> {

				new MeetingRoomImage {  Name = "sleep.jpg",Image = sleepImage, ImageWidth = 79,},
				new MeetingRoomImage {  Name = "live.jpg", Image = liveImage, ImageWidth = 58},
				new MeetingRoomImage {  Name = "hall.jpg", Image = hallImage, ImageWidth = 58}

			};

			var meetingRooms = new List<MeetingRoom>
			 {
				new MeetingRoom { MeetingRoomName = "Sleeping Room", MeetingRoomEmail = "sleep@email.com", LocationId = locations[0].LocationId, MeetingRoomImage = images[0]},
				new MeetingRoom { MeetingRoomName = "Hall", MeetingRoomEmail = "hall@email.com", LocationId = locations[1].LocationId, MeetingRoomImage = images[2]},
				new MeetingRoom { MeetingRoomName = "Living Room", MeetingRoomEmail = "live@email.com", LocationId = locations[2].LocationId, MeetingRoomImage = images[1]}
			 };
			context.MeetingRooms.AddRange(meetingRooms);
			context.SaveChanges();

			var reservations = new List<MeetingRoomReservation>
			{
				new MeetingRoomReservation { MeetingDate = DateTime.Now.Date,StartTime =  new TimeSpan(10,30,0),EndTime = new TimeSpan(11,30,0),UserId =  users[0].UserId,  MeetingTopic = "Discussion 1",MeetingRoomId = 1 },
				new MeetingRoomReservation { MeetingDate = DateTime.Now.Date,StartTime = new TimeSpan(15,30,0),EndTime = new TimeSpan(16,30,0), UserId =  users[1].UserId, MeetingTopic = "Discussion 2",MeetingRoomId = 2 },
				new MeetingRoomReservation { MeetingDate = DateTime.Now.Date,StartTime =  new TimeSpan(12,30,0),EndTime = new TimeSpan(13,30,0), UserId = users[2].UserId,  MeetingTopic = "Discussion 3",MeetingRoomId = 3},
			};

			context.MeetingRoomReservations.AddRange(reservations);
			context.SaveChanges();
		}
	}
}
