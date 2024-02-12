using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 249, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 250, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 250, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 250, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "Status" },
                values: new object[] { "d1bc3da1-6936-423c-9a01-ad18018be477", new DateTime(2024, 2, 12, 20, 13, 13, 250, DateTimeKind.Local).AddTicks(3379), "AQAAAAIAAYagAAAAEHAzzcUBvVrNDJvQVRn4pQ3KJS5uSCk8TSUBG0e89s7vL2nJ0JgumyaKcHuJcYZY6g==", false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "Status" },
                values: new object[] { "5da10e26-c4d7-4240-a97e-7af5f6f02658", new DateTime(2024, 2, 12, 20, 13, 13, 316, DateTimeKind.Local).AddTicks(9928), "AQAAAAIAAYagAAAAECn3/io1g5RX46yJng0l0PHr0kAmISiG90U6n8tmmFl3lPFhDLNI9Hkp0tHOWmRC9Q==", false });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 389, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 13, 13, 390, DateTimeKind.Local).AddTicks(3100));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 5, 887, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 12, 20, 0, 5, 889, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 12, 20, 0, 5, 889, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 12, 20, 0, 5, 889, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "73785acd-cd4a-4517-b867-a2ab9e31d2d1", new DateTime(2024, 2, 12, 20, 0, 5, 889, DateTimeKind.Local).AddTicks(5164), "AQAAAAIAAYagAAAAEGNZxXfo0CO1gfnJ3N0WMvWmSfK1erMXsI39ykkj6TjkoRdkrMtZDfOr3N6/VwvCQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "d0ba8843-f0b8-4b64-a90b-e227644cd9ca", new DateTime(2024, 2, 12, 20, 0, 5, 958, DateTimeKind.Local).AddTicks(8156), "AQAAAAIAAYagAAAAELnHZbCohk8ceDkseu0b4jest8Zg0l6pxF+kfVFjihS2v/fVS0DIPYBfBnv3xidB4w==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 20, 0, 6, 31, DateTimeKind.Local).AddTicks(6271));
        }
    }
}
