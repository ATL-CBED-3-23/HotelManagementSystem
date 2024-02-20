using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class salamaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Rooms_RoomId",
                schema: "Hotel",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_RoomId",
                schema: "Hotel",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "RoomId",
                schema: "Hotel",
                table: "Equipments");

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

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentRoom_RoomsId",
                schema: "Hotel",
                table: "EquipmentRoom",
                column: "RoomsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentRoom",
                schema: "Hotel");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                schema: "Hotel",
                table: "Equipments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedDate", "RoomId" },
                values: new object[] { new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(6236), 1 });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "RoomId" },
                values: new object[] { new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(6891), 2 });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "RoomId" },
                values: new object[] { new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(6895), 4 });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "RoomId" },
                values: new object[] { new DateTime(2024, 2, 20, 14, 17, 20, 534, DateTimeKind.Local).AddTicks(6897), 3 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_RoomId",
                schema: "Hotel",
                table: "Equipments",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Rooms_RoomId",
                schema: "Hotel",
                table: "Equipments",
                column: "RoomId",
                principalSchema: "Hotel",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
