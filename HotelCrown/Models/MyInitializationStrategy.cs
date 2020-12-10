using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Models
{
    public class MyInitializationStrategy : CreateDatabaseIfNotExists<HotelCrownContext>
    {
        protected override void Seed(HotelCrownContext context)
        {
            Service service1 = new Service
            {
                ServiceName = "Meal",
                UnitPrice = 75,
                Quantity = 3
            };

            Service service2 = new Service
            {
                ServiceName = "Massage",
                UnitPrice = 100,
                Quantity = 1
            };

            Service service3 = new Service
            {
                ServiceName = "Sauna",
                UnitPrice = 60,
                Quantity = 2
            };

            Room room1 = new Room
            {
                RoomNo = 101,
                Capacity = "Single",
                Price = 250,
            };

            Room room2 = new Room
            {
                RoomNo = 201,
                Capacity = "Double",
                Price = 350,
            };

            Room room3 = new Room
            {
                RoomNo = 301,
                Capacity = "Triple",
                Price = 450,
            };

            Customer customer1 = new Customer
            {
                FullName = "Richard Swinburne",
                IdentityNumber = 19266,
                PhoneNumber = 6886,
                BirthDate = new DateTime(1956, 8, 9),
                Gender = Gender.Erkek,
                Description = "Philosophy overload!"
            };

            Customer customer2 = new Customer
            {
                FullName = "Julie Swinburne",
                IdentityNumber = 19269,
                PhoneNumber = 8668,
                BirthDate = new DateTime(1965, 9, 8),
                Gender = Gender.Kadın,
                Description = "Swinburne overload!"
            };

            Customer customer3 = new Customer
            {
                FullName = "Alvin Plantinga",
                IdentityNumber = 19669,
                PhoneNumber = 9669,
                BirthDate = new DateTime(1966, 9, 6),
                Gender = Gender.Erkek,
                Description = "This guy knows..."
            };


            Feature feature1 = new Feature
            {
                FeatureName = "Jakuzi"
            };

            Feature feature2 = new Feature
            {
                FeatureName = "Kasa"
            };

            Feature feature3 = new Feature
            {
                FeatureName = "Deniz Manzarası"
            };

            ReservationService reservationService1 = new ReservationService
            {
                ServiceName = "Meal"
            };

            ReservationService reservationService2 = new ReservationService
            {
                ServiceName = "Massage"
            };

            ReservationService reservationService3 = new ReservationService
            {
                ServiceName = "Sauna"
            };

            Reservation reservation1 = new Reservation
            {
                CheckInDate = new DateTime(2020, 1, 18),
                CheckOutDate = new DateTime(2020, 2, 5),
                CheckedInTime = new DateTime(2020, 1, 26),
                CheckedOutTime = new DateTime(2020, 2, 4),
                CheckedIn = "Yes",
                CheckedOut = "Yes"
            };

            Reservation reservation2 = new Reservation

            {
                CheckInDate = new DateTime(2020, 6, 8),
                CheckOutDate = new DateTime(2020, 7, 15),
                CheckedInTime = new DateTime(2020, 6, 16),
                CheckedOutTime = new DateTime(2020, 7, 9),
                CheckedIn = "Yes",
                CheckedOut = "Yes"
            };

            Reservation reservation3 = new Reservation

            {
                CheckInDate = new DateTime(2020, 8, 19),
                CheckOutDate = new DateTime(2020, 9, 28),
                CheckedInTime = new DateTime(2020, 8, 20),
                CheckedOutTime = new DateTime(2020, 9, 27),
                CheckedIn = "Yes",
                CheckedOut = "Yes"
            };

            context.Features.Add(new Feature
            {
                FeatureName = "Jakuzi",
                Rooms = new List<Room>()
                {
                    room1,
                    room2
                }
            });

            //context.Customers.Add(new Customer
            //{
            //    FullName = "William Lane Craig",
            //    IdentityNumber = 6169,
            //    PhoneNumber = 978654,
            //    BirthDate = new DateTime(1967, 6, 9),
            //    Gender = Gender.Erkek,
            //    Description = "Cosmology Overload!",
            //    Reservations = new List<Reservation>()
            //    {
            //        reservation1
            //    }
            //});

            //context.Rooms.Add(new Room
            //{
            //    RoomNo = 101,
            //    Capacity = "Single",
            //    Price = 250,
            //    Features = new List<Feature>() { feature1, feature2 },
            //    Reservations = new List<Reservation>()
            //    {
            //        reservation2,
            //        reservation3
            //    }
            //});
            //context.Rooms.Add(new Room
            //{
            //    RoomNo = 2,
            //    Capacity = "Double",
            //    Price = 1500,
            //    Features = new List<Feature>() { feature1, feature2, feature3 },

            //    Reservations = new List<Reservation>()
            //    {
            //        reservation1
            //    }
            //});

            context.Services.AddRange(new Service[] { service1, service2, service3 });
            context.Customers.AddRange(new Customer[] { customer1, customer2, customer3 });
            context.ReservationServices.AddRange(new ReservationService[] { reservationService1, reservationService2, reservationService3 });
            context.Rooms.AddRange(new Room[] { room1, room2, room3 });
            context.Reservations.Add(new Reservation
            {
                RoomId = 1,
                CheckInDate = new DateTime(2020, 11, 25),
                CheckOutDate = new DateTime(2020, 12, 4),
                CheckedInTime = new DateTime(2020, 11, 26),
                CheckedOutTime = new DateTime(2020, 12, 4),
                CheckedIn = "Yes",
                CheckedOut = "Yes",
                Customers = new List<Customer>() { customer1 },
                Room = room1,
                ReservationServices = new List<ReservationService>() { reservationService1 }
            });

            //context.Services.Add(new Service
            //{
            //    ServiceName = "Meal",
            //    UnitPrice = 75,
            //    Quantity = 2,
            //    ReservationService = reservationService1
            //});

            //context.ReservationServices.Add(new ReservationService
            //{
            //    ServiceName = "Meal",
            //    ReservationId = 1,
            //    ServiceId = 1,
            //    Reservation = reservation1,
            //    Services = new List<Service>() { service1 }
            //});
        }
    }
}
