using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Hotel");

            migrationBuilder.CreateTable(
                name: "AboutApps",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Site = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AppVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutApps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservators",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Hotel",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "Hotel",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HotelUserId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_HotelUserId",
                        column: x => x.HotelUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalSchema: "Hotel",
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", maxLength: 25, nullable: false),
                    Floor = table.Column<int>(type: "int", maxLength: 25, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 100, nullable: false),
                    RoomState = table.Column<int>(type: "int", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalSchema: "Hotel",
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalSchema: "Hotel",
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalSchema: "Hotel",
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    HotelUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_HotelUserId",
                        column: x => x.HotelUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalSchema: "Hotel",
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomImage_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalSchema: "Hotel",
                        principalTable: "Hotels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoomImage_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalSchema: "Hotel",
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "AboutApps",
                columns: new[] { "Id", "AppName", "AppVersion", "Content", "CreatedDate", "IsDeleted", "Site" },
                values: new object[] { 1, "Hotel Management System", "1.0.1", "Hotel Management System Application", new DateTime(2024, 2, 6, 10, 28, 3, 368, DateTimeKind.Local).AddTicks(4363), 0, "www.hms.com" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreateDate", "EntityStatus", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 2, 6, 10, 28, 3, 369, DateTimeKind.Local).AddTicks(3414), 0, "Admin", "ADMIN" },
                    { 2, null, new DateTime(2024, 2, 6, 10, 28, 3, 369, DateTimeKind.Local).AddTicks(4000), 0, "Default", "DEFAULT" },
                    { 3, null, new DateTime(2024, 2, 6, 10, 28, 3, 369, DateTimeKind.Local).AddTicks(4002), 0, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDate", "Email", "EmailConfirmed", "EntityStatus", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "b4f8cc52-7654-4434-8d0b-b2a62fd84767", new DateTime(2024, 2, 6, 10, 28, 3, 369, DateTimeKind.Local).AddTicks(4376), "arzu@gmail.com", false, 0, "Arzu", "Teymurova", false, null, null, null, "AQAAAAIAAYagAAAAENBZEFMNzA6Vr6PkVme4uWzPgMen2BGAmDhq8RuFVrIWSDw7VnElJTYKuiJlps12Hg==", null, false, null, false, "Arzu" },
                    { 2, 0, "4d2d3c77-0940-4cf0-a6ae-afe6939a8add", new DateTime(2024, 2, 6, 10, 28, 3, 438, DateTimeKind.Local).AddTicks(470), "guest@com", false, 0, "Guest", "Guest", false, null, null, null, "AQAAAAIAAYagAAAAENmAJ85xYYsThbucfVze/+Us8VjX3uGucxAqQeZ4aJ7eorJ5LOKLhft2xUIG4+8hTA==", null, false, null, false, "Guest" }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "Countries",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 10, 28, 3, 504, DateTimeKind.Local).AddTicks(9697), 0, "Azerbaijan" },
                    { 2, new DateTime(2024, 2, 6, 10, 28, 3, 504, DateTimeKind.Local).AddTicks(9949), 0, "Turkey" },
                    { 3, new DateTime(2024, 2, 6, 10, 28, 3, 504, DateTimeKind.Local).AddTicks(9951), 0, "Italy" },
                    { 4, new DateTime(2024, 2, 6, 10, 28, 3, 504, DateTimeKind.Local).AddTicks(9952), 0, "Russia" },
                    { 5, new DateTime(2024, 2, 6, 10, 28, 3, 504, DateTimeKind.Local).AddTicks(9953), 0, "France" }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(2258), " 1 King Bed, Smoking, Sea View", 0, "Deluxe Room" },
                    { 2, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(2638), "1 Double Bed", 0, "Family Room" },
                    { 3, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(2640), "1 Bedroom, Terrace, Sea View", 0, "Suite Room" },
                    { 4, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(2641), "1 King Bed, Sea View", 0, "King Room" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreatedDate", "IsDeleted", "Name", "PostalCode" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(227), 0, "Baku", "1000" },
                    { 2, 2, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(679), 0, "Istanbul", "2205" },
                    { 3, 3, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(681), 0, "Roma", "3001" },
                    { 4, 4, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(682), 0, "Moscow", "4140" },
                    { 5, 5, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(683), 0, "Paris", "5005" }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "Hotels",
                columns: new[] { "Id", "Address", "CityId", "CreatedDate", "Email", "IsDeleted", "Grade", "Name", "PhoneNumber", "WebSite" },
                values: new object[,]
                {
                    { 1, "Nizami street,45", 1, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(883), "grandhayat@gmail.com", 0, 5, "Grand Hayat", "+994775005050", "grandh.com" },
                    { 2, "Nasimi District", 1, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(2056), "marriotbaku@gmail.com", 0, 5, "Courtyard by Marriott Baku", "+994775005050", "marriotbaku.com" },
                    { 3, "Sultanahmet", 2, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(2060), "sarikonak@hot.com", 0, 4, "Hotel Sari Konak", "+094775005050", "sarikonakhotel.tr.com" }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "Rooms",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Floor", "HotelId", "Number", "Phone", "Price", "RoomState", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(2968), 0, 3, 1, 100, "1240044444", 150.0, 0, 1 },
                    { 2, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(4381), 0, 2, 2, 128, "1240044444", 250.0, 0, 2 },
                    { 3, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(4389), 0, 4, 3, 246, "1240044444", 350.0, 2, 4 },
                    { 4, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(4391), 0, 4, 3, 238, "1240044444", 400.0, 1, 3 }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "Equipments",
                columns: new[] { "Id", "Count", "CreatedDate", "IsDeleted", "Name", "RoomId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(4678), 0, "Bed", 1 },
                    { 2, 2, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(5217), 0, "Twin Beds", 2 },
                    { 3, 1, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(5220), 0, "Minibar", 4 },
                    { 4, 1, new DateTime(2024, 2, 6, 10, 28, 3, 505, DateTimeKind.Local).AddTicks(5221), 0, " LCD TV", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                schema: "Hotel",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_RoomId",
                schema: "Hotel",
                table: "Equipments",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId",
                schema: "Hotel",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_HotelUserId",
                schema: "Hotel",
                table: "Reservations",
                column: "HotelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                schema: "Hotel",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_HotelId",
                schema: "Hotel",
                table: "Reviews",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_HotelUserId",
                schema: "Hotel",
                table: "Reviews",
                column: "HotelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImage_HotelId",
                table: "RoomImage",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImage_RoomId",
                table: "RoomImage",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                schema: "Hotel",
                table: "Rooms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                schema: "Hotel",
                table: "Rooms",
                column: "RoomTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutApps",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Equipments",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Reservations",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Reservators",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Reviews",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "RoomImage");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Rooms",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Hotels",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "RoomTypes",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "Hotel");
        }
    }
}
