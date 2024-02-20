using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Persistence.AppDbContext.SeedData
{

    public static class SeedDefaultData
    {
        private static AboutApp aboutApp = new AboutApp()
        {
            Id = 1,
            AppName = "Hotel Management System",
            Site = "www.hms.com",
            AppVersion = "1.0.1",
            Content = "Hotel Management System Application"
        };

        private static List<HotelUserRole> roles = new List<HotelUserRole>()
        {
            new HotelUserRole(){
                Id = 1,
                Name="Admin",
                NormalizedName="ADMIN"
            },
            new HotelUserRole(){
                Id = 2,
                Name="Default",
                NormalizedName = "DEFAULT"
            },
            new HotelUserRole(){
                Id = 3,
                Name="Staff",
                NormalizedName = "STAFF"
            },


        };

        private static List<HotelUser> users = new List<HotelUser>()
        {
            new HotelUser(){
                Id = 1,
                FirstName="Arzu",
                LastName="Teymurova",
                UserName="Arzu",
                PasswordHash= new PasswordHasher<IdentityUser>().HashPassword(null,"12345"),
                Email="arzu@gmail.com",

            },
            new HotelUser()
            {
                Id=2,
                FirstName="Guest",
                LastName="Guest",
                UserName="Guest",
                PasswordHash=new PasswordHasher<IdentityUser>().HashPassword(null,"12345"),
                Email="guest@com"

            }


        };

        private static List<IdentityUserRole<int>> identityUserRoles = new List<IdentityUserRole<int>>()
        {
            new IdentityUserRole<int>()
            {
               UserId = 1,
               RoleId=1,
            },

        new IdentityUserRole<int>()
        {
            UserId=1,
            RoleId=2
        },
        new IdentityUserRole<int>()
        {
            UserId=1,
            RoleId=3,
        },
        new IdentityUserRole<int>()
        {
            UserId=2,
            RoleId=2
        }

        };

        private static List<Country> countries = new List<Country>()
        {
            new Country()
            {
                Id = 1,
                Name="Azerbaijan"
            },
            new Country()
            {
                Id = 2,
                Name="Turkey"
            },
            new Country()
            {
                Id = 3,
                Name="Italy"
            },
            new Country()
            {
                Id = 4,
                Name="Russia"
            },
            new Country()
            {
                Id= 5,
                Name="France"
            }
        };

        private static List<City> cities = new List<City>()
        {
            new City()
            {
                Id = 1,
                Name="Baku",
                CountryId=1,
                PostalCode="1000"
            },
            new City() {
                Id = 2,
                Name="Istanbul",
                CountryId=2,
                PostalCode="2205"
            },
            new City()
            {
                Id=3,
                Name="Roma",
                CountryId=3,
                PostalCode="3001"
            },
            new City() {
                Id = 4,
                Name="Moscow",
                CountryId=4,
                PostalCode="4140"
            },
            new City()
            {
                Id=5,
                Name="Paris",
                CountryId=5,
                PostalCode="5005"
            }
        };

        private static List<Hotel> hotels = new List<Hotel>()
        {
            new Hotel()
            {
                Id = 1,
                Name="Grand Hayat",
                Address="Nizami street,45",
                Email="grandhayat@gmail.com",
                PhoneNumber="+994775005050",
                WebSite="grandh.com",
                Grade=Grade.FiveStar,
                CityId=1,


            },
            new Hotel()
            {
                Id = 2,
                Name="Courtyard by Marriott Baku",
                Address="Nasimi District",
                Email="marriotbaku@gmail.com",
                PhoneNumber="+994775005050",
                WebSite="marriotbaku.com",
                Grade=Grade.FiveStar,
                CityId=1,


            },
            new Hotel()
            {
                Id = 3,
                Name="Hotel Sari Konak",
                Address="Sultanahmet",
                Email="sarikonak@hot.com",
                PhoneNumber="+094775005050",
                WebSite="sarikonakhotel.tr.com",
                Grade=Grade.FourStar,
                CityId=2,
            }
        };

        private static List<RoomType> roomTypes = new List<RoomType>()
        {
            new RoomType()
            {
                Id=1,
                Name="Deluxe Room",
                Description=" 1 King Bed, Smoking, Sea View",
            },
            new RoomType()
            {
                Id=2,
                Name="Family Room",
                Description="1 Double Bed"

            },
            new RoomType()
            {
                Id=3,
                Name="Suite Room",
                Description="1 Bedroom, Terrace, Sea View"

            },
            new RoomType()
            {
                Id=4,
                Name="King Room",
                Description="1 King Bed, Sea View"

            }
        };

        private static List<Room> rooms = new List<Room>()
        {
            new Room()
            {
                Id = 1,
                Number=100,
                Floor=3,
                Phone="1240044444",
                Price=150,
                RoomState=RoomState.Available,
                RoomTypeId=1,
                HotelId=1,
            },
            new Room()
            {
                Id = 2,
                Number=128,
                Floor=2,
                Phone="1240044444",
                Price=250,
                RoomState=RoomState.Available,
                RoomTypeId=2,
                HotelId=2,
            },
            new Room()
            {
                Id = 3,
                Number=246,
                Floor=4,
                Phone="1240044444",
                Price=350,
                RoomState=RoomState.Reserved,
                RoomTypeId=4,
                HotelId=3,
            },
             new Room()
            {
                Id = 4,
                Number=238,
                Floor=4,
                Phone="1240044444",
                Price=400,
                RoomState=RoomState.NoAvailable,
                RoomTypeId=3,
                HotelId=3,
            }
        };

        private static List<Equipment> equipments = new List<Equipment>()
        {
            new Equipment()
            {
                Id=1,
                Name="Bed",
                Count=2,
               
            },
            new Equipment()
            {
                Id=2,
                Name="Twin Beds",
                Count=2,
                
            },
            new Equipment()
            {
                Id=3,
                Name="Minibar",
                Count=1,
               
            },
            new Equipment()
            {
                Id=4,
                Name=" LCD TV",
                Count=1,
              
            }
        };


        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutApp>().HasData(aboutApp);

            modelBuilder.Entity<HotelUserRole>().HasData(roles);
            modelBuilder.Entity<HotelUser>().HasData(users);
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(identityUserRoles);

            modelBuilder.Entity<Country>().HasData(countries);
            modelBuilder.Entity<City>().HasData(cities);
            modelBuilder.Entity<Hotel>().HasData(hotels);
            modelBuilder.Entity<Room>().HasData(rooms);
            modelBuilder.Entity<RoomType>().HasData(roomTypes);
            modelBuilder.Entity<Equipment>().HasData(equipments);


        }
    }
}
