using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Fix4 : Migration
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
                value: new DateTime(2024, 2, 3, 19, 2, 7, 486, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 487, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 487, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 487, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "de815a0f-0883-41dc-aa88-7bf65f18db44", new DateTime(2024, 2, 3, 19, 2, 7, 487, DateTimeKind.Local).AddTicks(2681), "AQAAAAIAAYagAAAAENPDHLTSHJoDgqy7taIz3JTEkdSzFomM3l7Dn9TwNBDmIkOLM8z1+Q74udlep6rHzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "abb63bee-0213-411a-b5bb-15590e57f1ae", new DateTime(2024, 2, 3, 19, 2, 7, 568, DateTimeKind.Local).AddTicks(3346), "AQAAAAIAAYagAAAAELZkZE4Ui49RQCHYlXJM4JrwNjL1/6IphbmOGt4TtT64ftIy5f2fimyRyu6UD8Rhog==" });

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                schema: "Hotel",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 2, 7, 642, DateTimeKind.Local).AddTicks(5418));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "ce7e9666-7de2-4411-b518-c66ce570f5b4", new DateTime(2024, 2, 3, 19, 1, 16, 96, DateTimeKind.Local).AddTicks(170), "AQAAAAIAAYagAAAAEOeWzNfcXCN/iFb4WQcxRF8EWIdlKtPwK2kA1uthOqcaR2WIkEV6QXp+ACBhaxTOxQ==" });

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
    }
}
