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
                Name="User",
                NormalizedName = "USER"
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

        };

        private static List<IdentityUserRole<int>> identityUserRoles = new List<IdentityUserRole<int>>()
        {
            new IdentityUserRole<int>()
            {
               UserId = 1,
               RoleId=1,
            }

        };

        private static List<Country> countries = new List<Country>()
        {
            new Country()
            {
                Id = 1,
                Name="Azerbaijan"
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
        };

        private static List<RoomType> roomTypes = new List<RoomType>()
        {
            new RoomType()
            {
                Id=1,
                Name="VIP",
                Description="Comfortable equipments, scenery",
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
        };

        private static List<Equipment> equipments = new List<Equipment>()
        {
            new Equipment()
            {
                Id=1,
                Name="Bed",
                Count=2,
                RoomId=1
            },
            new Equipment()
            {
                Id=2,
                Name="Minibar",
                Count=1,
                RoomId=1
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
