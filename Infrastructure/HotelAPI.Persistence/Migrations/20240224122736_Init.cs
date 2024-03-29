﻿using System;
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
                name: "ApplicationErrors",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationErrors", x => x.Id);
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
                    NetworkStatus = table.Column<int>(type: "int", nullable: false),
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
                name: "Equipments",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
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
                name: "HotelUserImages",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelUserImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelUserImages_AspNetUsers_HotelUserId",
                        column: x => x.HotelUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLoginHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HotelUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLoginHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLoginHistory_AspNetUsers_HotelUserId",
                        column: x => x.HotelUserId,
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
                name: "HotelImages",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelImages_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalSchema: "Hotel",
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelRatings",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelRatings_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalSchema: "Hotel",
                        principalTable: "Hotels",
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
                name: "EquipmentRoom",
                schema: "Hotel",
                columns: table => new
                {
                    EquipmentsId = table.Column<int>(type: "int", nullable: false),
                    RoomsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentRoom", x => new { x.EquipmentsId, x.RoomsId });
                    table.ForeignKey(
                        name: "FK_EquipmentRoom_Equipments_EquipmentsId",
                        column: x => x.EquipmentsId,
                        principalSchema: "Hotel",
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentRoom_Rooms_RoomsId",
                        column: x => x.RoomsId,
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
                name: "RoomImages",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomImages_Rooms_RoomId",
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
                values: new object[] { 1, "Hotel Management System", "1.0.1", "Hotel Management System Application", new DateTime(2024, 2, 24, 16, 27, 35, 857, DateTimeKind.Local).AddTicks(9717), 0, "www.hms.com" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreateDate", "EntityStatus", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 2, 24, 16, 27, 35, 858, DateTimeKind.Local).AddTicks(8374), 0, "Admin", "ADMIN" },
                    { 2, null, new DateTime(2024, 2, 24, 16, 27, 35, 858, DateTimeKind.Local).AddTicks(8988), 0, "Default", "DEFAULT" },
                    { 3, null, new DateTime(2024, 2, 24, 16, 27, 35, 858, DateTimeKind.Local).AddTicks(8991), 0, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDate", "Email", "EmailConfirmed", "EntityStatus", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NetworkStatus", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "4a0491b6-6e6d-4c7c-8f40-05e5c0df9a20", new DateTime(2024, 2, 24, 16, 27, 35, 858, DateTimeKind.Local).AddTicks(9364), "arzu@gmail.com", false, 0, "Arzu", "Teymurova", false, null, 0, null, null, "AQAAAAIAAYagAAAAEEGr16Jkafnrel1ILCC5tWb/K3zGJKXna5qIvcRcL21aLlLUs2Rg4VNs+tRbD/vhnA==", null, false, null, false, "Arzu" },
                    { 2, 0, "14bca1f8-3af6-446d-9da0-820ab613657d", new DateTime(2024, 2, 24, 16, 27, 35, 934, DateTimeKind.Local).AddTicks(1625), "guest@com", false, 0, "Guest", "Guest", false, null, 0, null, null, "AQAAAAIAAYagAAAAED0FWIXyvhvbUB8kKEcfLAItUEROo/N59e0guUmBFHEGlRTsUDh74nFwJ2ngdImp1g==", null, false, null, false, "Guest" }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "Countries",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(4912), 0, "Azerbaijan" },
                    { 2, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(5209), 0, "Turkey" },
                    { 3, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(5212), 0, "Italy" },
                    { 4, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(5213), 0, "Russia" },
                    { 5, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(5213), 0, "France" }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "Equipments",
                columns: new[] { "Id", "Count", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(9454), 0, "Bed" },
                    { 2, 2, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(9728), 0, "Twin Beds" },
                    { 3, 1, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(9729), 0, "Minibar" },
                    { 4, 1, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(9730), 0, " LCD TV" }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(7888), " 1 King Bed, Smoking, Sea View", 0, "Deluxe Room" },
                    { 2, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(8150), "1 Double Bed", 0, "Family Room" },
                    { 3, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(8152), "1 Bedroom, Terrace, Sea View", 0, "Suite Room" },
                    { 4, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(8153), "1 King Bed, Sea View", 0, "King Room" }
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
                    { 1, 1, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(5467), 0, "Baku", "1000" },
                    { 2, 2, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(6236), 0, "Istanbul", "2205" },
                    { 3, 3, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(6238), 0, "Roma", "3001" },
                    { 4, 4, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(6240), 0, "Moscow", "4140" },
                    { 5, 5, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(6241), 0, "Paris", "5005" }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "Hotels",
                columns: new[] { "Id", "Address", "CityId", "CreatedDate", "Email", "IsDeleted", "Grade", "Name", "PhoneNumber", "WebSite" },
                values: new object[,]
                {
                    { 1, "Nizami street,45", 1, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(6503), "grandhayat@gmail.com", 0, 5, "Grand Hayat", "+994775005050", "grandh.com" },
                    { 2, "Nasimi District", 1, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(7703), "marriotbaku@gmail.com", 0, 5, "Courtyard by Marriott Baku", "+994775005050", "marriotbaku.com" },
                    { 3, "Sultanahmet", 2, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(7706), "sarikonak@hot.com", 0, 4, "Hotel Sari Konak", "+094775005050", "sarikonakhotel.tr.com" }
                });

            migrationBuilder.InsertData(
                schema: "Hotel",
                table: "Rooms",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Floor", "HotelId", "Number", "Phone", "Price", "RoomState", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(8378), 0, 3, 1, 100, "1240044444", 150.0, 0, 1 },
                    { 2, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(9264), 0, 2, 2, 128, "1240044444", 250.0, 0, 2 },
                    { 3, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(9267), 0, 4, 3, 246, "1240044444", 350.0, 2, 4 },
                    { 4, new DateTime(2024, 2, 24, 16, 27, 36, 10, DateTimeKind.Local).AddTicks(9268), 0, 4, 3, 238, "1240044444", 400.0, 1, 3 }
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
                name: "IX_EquipmentRoom_RoomsId",
                schema: "Hotel",
                table: "EquipmentRoom",
                column: "RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelImages_HotelId",
                schema: "Hotel",
                table: "HotelImages",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRatings_HotelId",
                schema: "Hotel",
                table: "HotelRatings",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId",
                schema: "Hotel",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelUserImages_HotelUserId",
                schema: "Hotel",
                table: "HotelUserImages",
                column: "HotelUserId");

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
                name: "IX_RoomImages_RoomId",
                schema: "Hotel",
                table: "RoomImages",
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

            migrationBuilder.CreateIndex(
                name: "IX_UserLoginHistory_HotelUserId",
                table: "UserLoginHistory",
                column: "HotelUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutApps",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "ApplicationErrors",
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
                name: "EquipmentRoom",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "HotelImages",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "HotelRatings",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "HotelUserImages",
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
                name: "RoomImages",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "UserLoginHistory");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Equipments",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Rooms",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
