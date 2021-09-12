using Microsoft.EntityFrameworkCore.Migrations;

namespace sample_app.Migrations
{
    public partial class addroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c93a3c8-bca3-4179-9ce0-d47fa354dfd1", "3fc75c94-71ea-4bd1-9a55-24e4c5e3814d", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a24992f-9a6c-4022-9ed0-cb160a0b5b01", "dfaf2796-7052-4f6c-b9e1-fbd1139efb87", "Administrator", "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c93a3c8-bca3-4179-9ce0-d47fa354dfd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a24992f-9a6c-4022-9ed0-cb160a0b5b01");
        }
    }
}
