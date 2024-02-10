using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationError",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationError", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 5, 836, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 10, 17, 50, 5, 840, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 10, 17, 50, 5, 840, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 10, 17, 50, 5, 840, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "5215c8c1-a08e-4fa9-8e8e-a3aab8c7eaf3", new DateTime(2024, 2, 10, 17, 50, 5, 840, DateTimeKind.Local).AddTicks(9141), "AQAAAAIAAYagAAAAEPRX6gdOsT/PqjBavmwFwAc56do27WE11PipKAylDG0Tlsa1BTEJTi2AnF7R54fsEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "66dee977-a851-4744-a9e0-f1d46f904349", new DateTime(2024, 2, 10, 17, 50, 5, 980, DateTimeKind.Local).AddTicks(8197), "AQAAAAIAAYagAAAAELCt/PNfyE4wpd35z5rAKDVNoS6hbK5EK/oHeygYalMF1nSDl7aPLdEz9EX0ICwFAg==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 98, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 98, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 98, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 98, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 97, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 98, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 98, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 98, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 17, 50, 6, 98, DateTimeKind.Local).AddTicks(2933));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationError");

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
    }
}
