using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class sa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 28, 932, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 19, 56, 28, 934, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 19, 56, 28, 934, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 19, 56, 28, 934, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "af597c5f-517c-456e-9de0-2e89ff423aee", new DateTime(2024, 2, 20, 19, 56, 28, 935, DateTimeKind.Local).AddTicks(36), "AQAAAAIAAYagAAAAEFHcXXTM7UV0hymSOMqVWFFiyXXv8vOzhGpUX8ovIGNoFx1JSDBAO1aRZXNjml/TNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "a529d37e-60ed-4f95-98a6-a4493687f3b9", new DateTime(2024, 2, 20, 19, 56, 29, 9, DateTimeKind.Local).AddTicks(2048), "AQAAAAIAAYagAAAAECcuLM2rSM2lcyhaCXOUGGYHoqgpP6gGY59TQibjYESVd7XxlYFeJLM2X6b3jFVYVw==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 78, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 78, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 78, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 78, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 77, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 78, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 78, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 56, 29, 78, DateTimeKind.Local).AddTicks(1537));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 815, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 817, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 818, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 818, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "218f8a11-c770-4345-9ca4-fac71bd3044e", new DateTime(2024, 2, 20, 19, 33, 27, 818, DateTimeKind.Local).AddTicks(2019), "AQAAAAIAAYagAAAAEMzzRTQaW+hew6ni5jliSPvD4SVAo8klO1yG7jgdUaA0vneF4UoMmf8AZlIhrouYhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "1ee207a4-3a15-4b55-93e6-32e8bc8392f1", new DateTime(2024, 2, 20, 19, 33, 27, 897, DateTimeKind.Local).AddTicks(6909), "AQAAAAIAAYagAAAAEGYkND4EXLtl1Ni1HenesGjcEBryDg3zxjzbAMvM6BSO6eu19n6n14B4ZpO2AVJ2CA==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 968, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 19, 33, 27, 969, DateTimeKind.Local).AddTicks(2308));
        }
    }
}
