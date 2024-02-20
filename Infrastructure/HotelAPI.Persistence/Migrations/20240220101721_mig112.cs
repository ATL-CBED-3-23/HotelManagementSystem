using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig112 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRatings_AspNetUsers_UserId",
                schema: "Hotel",
                table: "HotelRatings");

            migrationBuilder.DropIndex(
                name: "IX_HotelRatings_UserId",
                schema: "Hotel",
                table: "HotelRatings");

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 344, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 346, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 346, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 346, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "dbdc549a-2eef-49ef-91fa-f2eb7e5ad4b6", new DateTime(2024, 2, 20, 14, 17, 20, 346, DateTimeKind.Local).AddTicks(2625), "AQAAAAIAAYagAAAAEP0syiInaf7gLlsiD/U88czOjy9ectXroua45n9eRQBwmLbZMPfh8lCU6VMU27NipQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "f66d5f18-a98b-4884-ba3b-996ca082c501", new DateTime(2024, 2, 20, 14, 17, 20, 448, DateTimeKind.Local).AddTicks(3968), "AQAAAAIAAYagAAAAEKM92pNYyAq05IyxnPnM6gNhlZYkZOAsjS1zaHMwcadmYFIne2u4nvIKHawH8o44nw==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 533, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 533, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 533, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 533, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 533, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(5911));
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

            migrationBuilder.CreateIndex(
                name: "IX_HotelRatings_UserId",
                schema: "Hotel",
                table: "HotelRatings",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRatings_AspNetUsers_UserId",
                schema: "Hotel",
                table: "HotelRatings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
