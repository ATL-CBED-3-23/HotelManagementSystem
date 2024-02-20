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
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Hotel",
                table: "HotelRatings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                schema: "Hotel",
                table: "HotelRatings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 11, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 12, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 12, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 12, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "96843345-a993-4032-8ccc-20b710c510a7", new DateTime(2024, 2, 20, 13, 55, 13, 12, DateTimeKind.Local).AddTicks(8509), "AQAAAAIAAYagAAAAEKzeIM8fDNu/SgfhY7011AEzgRfewmYLMaCishGJ0S48QTqppiQyKM3IciqyNjoBOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "c78bbcc8-8c33-41fc-94ab-b3f2c9c92e4c", new DateTime(2024, 2, 20, 13, 55, 13, 86, DateTimeKind.Local).AddTicks(4478), "AQAAAAIAAYagAAAAEJXX+hBLSm/hqG10gznCLwbQdXJ3mAqW8U/reC/8CAw/NJTcK1VNHBruhoGLDcHqsQ==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 157, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 55, 13, 158, DateTimeKind.Local).AddTicks(4442));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "Hotel",
                table: "HotelRatings");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                schema: "Hotel",
                table: "HotelRatings");

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 191, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 193, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 193, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 193, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "027a63d0-9bb3-4a10-ae58-f025270937a4", new DateTime(2024, 2, 20, 13, 21, 22, 193, DateTimeKind.Local).AddTicks(7235), "AQAAAAIAAYagAAAAEJw2YqvDE/4Foc92IeG5Vf/7o6t5a4kUqb/jh3KidHDatYrrGdA4agFlsbt4uspdZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "d2b56ee4-4152-47c6-b647-a82644306dad", new DateTime(2024, 2, 20, 13, 21, 22, 270, DateTimeKind.Local).AddTicks(6810), "AQAAAAIAAYagAAAAEL8S14L9JxeuhQN4aYR7KDKTJnbxvjqBOKQDH0zt79JoKgautvUCC9OV2KJ5UU8lAw==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 346, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 346, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 346, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 346, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 345, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 346, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 346, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 13, 21, 22, 346, DateTimeKind.Local).AddTicks(830));
        }
    }
}
