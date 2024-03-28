using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFuel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1b1a4496-4e10-49fb-9cbb-383c742097d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12404964-c666-43da-9fc0-1f2f3bff53da"));

            migrationBuilder.AddColumn<Guid>(
                name: "FuelId",
                table: "Models",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Admin", null },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Read", null },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Write", null },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Create", null },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Update", null },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("0ab9ee3b-2c98-4128-a4fe-f1af306ccdd8"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 119, 174, 41, 227, 152, 175, 144, 168, 208, 231, 242, 252, 15, 131, 13, 157, 251, 199, 66, 32, 214, 11, 139, 218, 226, 164, 162, 33, 99, 235, 143, 78, 35, 226, 54, 28, 101, 135, 204, 122, 218, 245, 76, 24, 144, 132, 3, 40, 252, 162, 225, 170, 166, 108, 162, 220, 220, 210, 176, 217, 189, 199, 109, 184 }, new byte[] { 230, 177, 251, 49, 201, 251, 209, 3, 212, 8, 144, 52, 142, 53, 82, 13, 120, 19, 62, 70, 196, 57, 223, 139, 185, 49, 225, 217, 88, 63, 226, 129, 154, 31, 65, 16, 32, 162, 44, 118, 149, 185, 138, 75, 38, 149, 218, 151, 235, 8, 62, 41, 138, 132, 99, 196, 57, 18, 148, 215, 184, 81, 19, 22, 23, 208, 68, 92, 144, 243, 239, 180, 126, 229, 230, 64, 85, 33, 1, 158, 109, 144, 21, 17, 145, 3, 12, 148, 193, 24, 1, 25, 160, 27, 83, 203, 64, 145, 82, 246, 186, 21, 130, 246, 48, 241, 207, 28, 19, 3, 218, 22, 201, 149, 150, 199, 184, 99, 5, 221, 120, 209, 188, 195, 159, 223, 121, 43 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("976e0637-0c41-4667-9054-c67ed9a41f90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("0ab9ee3b-2c98-4128-a4fe-f1af306ccdd8") });

            migrationBuilder.CreateIndex(
                name: "IX_Models_FuelId",
                table: "Models",
                column: "FuelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropIndex(
                name: "IX_Models_FuelId",
                table: "Models");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("976e0637-0c41-4667-9054-c67ed9a41f90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ab9ee3b-2c98-4128-a4fe-f1af306ccdd8"));

            migrationBuilder.DropColumn(
                name: "FuelId",
                table: "Models");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("12404964-c666-43da-9fc0-1f2f3bff53da"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 13, 126, 118, 130, 231, 57, 172, 54, 120, 152, 25, 131, 182, 16, 33, 68, 0, 243, 184, 208, 206, 76, 23, 93, 235, 10, 146, 26, 47, 4, 31, 212, 72, 134, 131, 102, 67, 140, 17, 150, 55, 213, 68, 246, 52, 21, 222, 205, 54, 48, 223, 245, 1, 99, 36, 152, 67, 1, 219, 15, 84, 173, 149, 137 }, new byte[] { 166, 167, 77, 36, 229, 67, 63, 223, 94, 207, 199, 179, 111, 220, 4, 33, 240, 42, 138, 87, 15, 133, 66, 22, 187, 186, 245, 102, 103, 177, 65, 131, 217, 64, 138, 184, 123, 1, 59, 121, 236, 217, 49, 192, 20, 219, 250, 45, 83, 179, 117, 189, 235, 58, 51, 53, 78, 107, 251, 185, 120, 71, 174, 217, 195, 156, 22, 3, 112, 242, 57, 205, 210, 246, 128, 97, 84, 222, 120, 9, 86, 108, 105, 132, 157, 128, 102, 229, 172, 182, 188, 137, 142, 116, 154, 102, 152, 157, 207, 80, 128, 99, 202, 116, 130, 131, 136, 63, 162, 70, 38, 18, 230, 246, 250, 200, 181, 74, 119, 221, 3, 95, 5, 227, 223, 116, 55, 22 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1b1a4496-4e10-49fb-9cbb-383c742097d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("12404964-c666-43da-9fc0-1f2f3bff53da") });
        }
    }
}
