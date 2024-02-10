using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileType",
                table: "HotelImage");

            migrationBuilder.RenameColumn(
                name: "File",
                table: "HotelImage",
                newName: "FileBase64");

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 229, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 231, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 231, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 231, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "34a8eb4a-3d52-4a88-bb2e-e885658f0600", new DateTime(2024, 2, 10, 17, 21, 3, 231, DateTimeKind.Local).AddTicks(5751), "AQAAAAIAAYagAAAAEOf+l54H9Oo1OPINWxqkbG31W16TO+g0RRxLlTicstLHArfgT5fcDv/b4k62/rn2ew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "51d5455b-17ee-4d47-92db-b3e86c8ba410", new DateTime(2024, 2, 10, 17, 21, 3, 308, DateTimeKind.Local).AddTicks(1231), "AQAAAAIAAYagAAAAEB4shojP116knz5qCdYo4dRgCoNvYTaUeYYjCUm0iMMyi+o1C3YJyezFSRjPHJIVJw==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 21, 3, 380, DateTimeKind.Local).AddTicks(8720));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileBase64",
                table: "HotelImage",
                newName: "File");

            migrationBuilder.AddColumn<int>(
                name: "FileType",
                table: "HotelImage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 282, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 283, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 283, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 283, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "0f11f510-2af7-4cb8-8744-e769c79eb950", new DateTime(2024, 2, 10, 16, 44, 50, 283, DateTimeKind.Local).AddTicks(8033), "AQAAAAIAAYagAAAAEPERAHGkH4rRq2zSLCcC8qcwJbJ1AHu1GItGkmRE/pRWwpAXK1Vps5Up59yPB4YWbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "90902cbe-5eb7-4a43-ae5b-6d84821590b0", new DateTime(2024, 2, 10, 16, 44, 50, 359, DateTimeKind.Local).AddTicks(7095), "AQAAAAIAAYagAAAAENnL7PGNnzMsz3+Ac67ZJoEnIySPPlHA2GmGftIFSo3ZhPxgxI2fFNSv8s3NMdwGfA==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 16, 44, 50, 432, DateTimeKind.Local).AddTicks(7980));
        }
    }
}
