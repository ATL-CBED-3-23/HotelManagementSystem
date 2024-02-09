using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HotelImage_HotelId",
                table: "HotelImage");

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "HotelImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "HotelUserImage",
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
                    table.PrimaryKey("PK_HotelUserImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelUserImage_AspNetUsers_HotelUserId",
                        column: x => x.HotelUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 5, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 8, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 9, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 9, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "c5647161-8942-49da-b54a-1eeff212fcb0", new DateTime(2024, 2, 9, 20, 20, 36, 9, DateTimeKind.Local).AddTicks(1627), "AQAAAAIAAYagAAAAEGf3TvPnCAb5jIlQUQbX0tpXJON2kmiUEPc1k1vZmIVYezQPUv7LkxS4H7Iw8+fSuA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "a9488e45-9f1a-4497-9969-af93324a7bd2", new DateTime(2024, 2, 9, 20, 20, 36, 130, DateTimeKind.Local).AddTicks(8873), "AQAAAAIAAYagAAAAENhmLvOp5VKjCrqpdpRdQ/b9a9tnVrJ2/93VWfQFd8JUiYOXiIJy75OdOjAv8Sqn9Q==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 239, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 240, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 240, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 240, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 238, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 239, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 239, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 239, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 239, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 239, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 239, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 239, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 20, 20, 36, 239, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.CreateIndex(
                name: "IX_HotelImage_HotelId",
                table: "HotelImage",
                column: "HotelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelUserImage_HotelUserId",
                table: "HotelUserImage",
                column: "HotelUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelUserImage");

            migrationBuilder.DropIndex(
                name: "IX_HotelImage_HotelId",
                table: "HotelImage");

            migrationBuilder.DropColumn(
                name: "File",
                table: "HotelImage");

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 402, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 403, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 403, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 403, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "d15c0193-84e4-49a9-b5f3-c7afd49f1732", new DateTime(2024, 2, 6, 20, 35, 28, 403, DateTimeKind.Local).AddTicks(3585), "AQAAAAIAAYagAAAAEBdV64oX/OaKX68VC0NVJgWHL9piMg0hjSWbK8P4W/HcRlLbA4krDN0rsULHK3Ws9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "724bdc32-80f1-4e48-9c24-15955dd9c1f8", new DateTime(2024, 2, 6, 20, 35, 28, 472, DateTimeKind.Local).AddTicks(7458), "AQAAAAIAAYagAAAAECFqoSqL54iJmE7l4J3dOLyMPhZBrHwFvmh9AENSQdHKfwFXN/eJgaO4ZNhtZgM1aQ==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 6, 20, 35, 28, 536, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.CreateIndex(
                name: "IX_HotelImage_HotelId",
                table: "HotelImage",
                column: "HotelId");
        }
    }
}
