using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Fix3 : Migration
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
                value: new DateTime(2024, 2, 3, 19, 1, 16, 4, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 21, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 21, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 21, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "d63e509c-dcd7-4d0e-9542-b29df85a1964", new DateTime(2024, 2, 3, 19, 1, 16, 21, DateTimeKind.Local).AddTicks(8523), "AQAAAAIAAYagAAAAEHRT0sOA6yWMnDwfy3bNDhcrFOHc1qkhfWXISWrhyHbXZjVuZ+H5VfIngbcYcyMoAg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateDate", "Email", "EmailConfirmed", "EntityStatus", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 2, 0, "ce7e9666-7de2-4411-b518-c66ce570f5b4", new DateTime(2024, 2, 3, 19, 1, 16, 96, DateTimeKind.Local).AddTicks(170), "guest@com", false, 0, "Guest", "Guest", false, null, null, null, "AQAAAAIAAYagAAAAEOeWzNfcXCN/iFb4WQcxRF8EWIdlKtPwK2kA1uthOqcaR2WIkEV6QXp+ACBhaxTOxQ==", null, false, null, false, "Guest" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 168, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 168, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 168, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 168, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 168, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 168, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 1, 16, 169, DateTimeKind.Local).AddTicks(5198));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "AboutApps",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 146, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 147, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 147, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 147, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "0a111469-7d79-40be-b94d-3b8e070ad840", new DateTime(2024, 2, 3, 18, 58, 54, 147, DateTimeKind.Local).AddTicks(9179), "AQAAAAIAAYagAAAAEF6K7UwdQzs0D7jxmUBmQLLzksN6Oq21Bs83O/vg6zEc2HUdN0hItOMOM39XxwFZqQ==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 18, 58, 54, 219, DateTimeKind.Local).AddTicks(7460));
        }
    }
}
