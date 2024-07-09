using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class yeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorevs_Users_UserId",
                table: "Gorevs");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("18d6c8a4-6bfc-438e-b576-e3ee67abb3a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04945c5c-591f-467e-9ba5-fedffaf85d19"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Gorevs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("622d4ed3-9f32-4d10-be36-befca1f9bc1e"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 193, 75, 113, 29, 31, 35, 230, 67, 106, 33, 77, 13, 181, 214, 128, 120, 253, 112, 41, 153, 70, 138, 203, 168, 202, 78, 122, 64, 240, 192, 156, 203, 242, 164, 127, 168, 216, 113, 20, 35, 110, 124, 140, 185, 152, 180, 130, 161, 32, 63, 76, 146, 0, 114, 130, 153, 207, 158, 7, 113, 21, 145, 93, 211 }, new byte[] { 145, 75, 228, 197, 228, 0, 217, 190, 115, 168, 64, 20, 188, 175, 192, 205, 24, 208, 0, 79, 50, 227, 53, 202, 255, 202, 8, 50, 38, 106, 222, 101, 253, 255, 106, 224, 131, 124, 253, 176, 155, 32, 226, 142, 28, 128, 156, 137, 87, 241, 89, 16, 102, 88, 26, 177, 255, 124, 184, 125, 167, 201, 70, 82, 9, 87, 173, 204, 94, 193, 138, 61, 5, 2, 26, 42, 133, 3, 197, 39, 2, 26, 59, 215, 73, 155, 166, 69, 18, 176, 192, 33, 26, 105, 120, 92, 25, 156, 231, 24, 6, 105, 152, 174, 249, 54, 55, 63, 120, 194, 219, 64, 118, 34, 66, 39, 40, 35, 48, 208, 43, 22, 2, 75, 139, 40, 189, 227 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("b768f3db-ec5b-4c7b-b9a4-3c116d118e8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("622d4ed3-9f32-4d10-be36-befca1f9bc1e") });

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevs_Users_UserId",
                table: "Gorevs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorevs_Users_UserId",
                table: "Gorevs");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b768f3db-ec5b-4c7b-b9a4-3c116d118e8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("622d4ed3-9f32-4d10-be36-befca1f9bc1e"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Gorevs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("04945c5c-591f-467e-9ba5-fedffaf85d19"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 179, 251, 130, 152, 203, 145, 114, 105, 187, 75, 15, 63, 3, 251, 79, 85, 175, 123, 82, 36, 93, 167, 12, 28, 93, 119, 238, 177, 174, 29, 145, 165, 241, 48, 144, 183, 160, 232, 155, 15, 230, 115, 126, 231, 127, 172, 74, 251, 180, 53, 115, 169, 66, 24, 131, 21, 111, 31, 95, 83, 55, 52, 159, 236 }, new byte[] { 9, 192, 77, 221, 83, 174, 32, 31, 106, 252, 150, 37, 163, 98, 70, 131, 97, 148, 238, 78, 147, 223, 188, 238, 11, 134, 154, 105, 139, 64, 118, 86, 90, 76, 240, 29, 126, 133, 172, 96, 209, 60, 122, 91, 192, 203, 87, 120, 70, 149, 181, 49, 235, 13, 193, 20, 11, 35, 23, 50, 214, 227, 55, 100, 38, 146, 57, 224, 41, 223, 59, 108, 124, 123, 160, 21, 202, 216, 36, 76, 26, 153, 192, 132, 151, 71, 189, 170, 235, 209, 149, 100, 141, 158, 129, 104, 242, 224, 184, 40, 182, 58, 242, 220, 231, 246, 25, 105, 198, 150, 157, 203, 18, 147, 92, 63, 103, 153, 19, 194, 124, 189, 20, 156, 196, 188, 82, 235 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("18d6c8a4-6bfc-438e-b576-e3ee67abb3a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("04945c5c-591f-467e-9ba5-fedffaf85d19") });

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevs_Users_UserId",
                table: "Gorevs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
