using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class gorevupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b768f3db-ec5b-4c7b-b9a4-3c116d118e8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("622d4ed3-9f32-4d10-be36-befca1f9bc1e"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("813650d6-292e-4646-b2c1-d60f39e57214"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 254, 28, 0, 3, 246, 12, 186, 206, 94, 60, 85, 55, 240, 108, 41, 214, 178, 30, 149, 9, 179, 72, 105, 190, 123, 158, 110, 47, 133, 251, 119, 38, 35, 207, 150, 9, 131, 165, 86, 154, 133, 22, 205, 133, 153, 156, 167, 95, 66, 137, 134, 247, 134, 61, 1, 102, 43, 84, 198, 160, 81, 202, 174, 213 }, new byte[] { 172, 17, 114, 212, 33, 40, 174, 243, 1, 4, 94, 126, 195, 6, 178, 142, 145, 241, 108, 99, 146, 40, 99, 14, 153, 64, 83, 36, 51, 250, 0, 195, 246, 237, 80, 128, 195, 53, 99, 30, 53, 139, 126, 99, 32, 167, 111, 90, 109, 85, 87, 227, 216, 219, 237, 121, 75, 12, 247, 209, 232, 195, 182, 197, 246, 142, 25, 101, 234, 48, 234, 42, 132, 249, 68, 61, 242, 235, 197, 199, 232, 143, 87, 74, 20, 46, 211, 101, 124, 247, 208, 251, 58, 54, 118, 194, 165, 127, 83, 88, 242, 21, 26, 63, 143, 140, 50, 33, 24, 122, 227, 67, 7, 57, 109, 159, 104, 248, 61, 83, 89, 135, 53, 55, 209, 209, 38, 98 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1044fb6e-8f69-4003-8603-012f5ff081a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("813650d6-292e-4646-b2c1-d60f39e57214") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1044fb6e-8f69-4003-8603-012f5ff081a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("813650d6-292e-4646-b2c1-d60f39e57214"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("622d4ed3-9f32-4d10-be36-befca1f9bc1e"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 193, 75, 113, 29, 31, 35, 230, 67, 106, 33, 77, 13, 181, 214, 128, 120, 253, 112, 41, 153, 70, 138, 203, 168, 202, 78, 122, 64, 240, 192, 156, 203, 242, 164, 127, 168, 216, 113, 20, 35, 110, 124, 140, 185, 152, 180, 130, 161, 32, 63, 76, 146, 0, 114, 130, 153, 207, 158, 7, 113, 21, 145, 93, 211 }, new byte[] { 145, 75, 228, 197, 228, 0, 217, 190, 115, 168, 64, 20, 188, 175, 192, 205, 24, 208, 0, 79, 50, 227, 53, 202, 255, 202, 8, 50, 38, 106, 222, 101, 253, 255, 106, 224, 131, 124, 253, 176, 155, 32, 226, 142, 28, 128, 156, 137, 87, 241, 89, 16, 102, 88, 26, 177, 255, 124, 184, 125, 167, 201, 70, 82, 9, 87, 173, 204, 94, 193, 138, 61, 5, 2, 26, 42, 133, 3, 197, 39, 2, 26, 59, 215, 73, 155, 166, 69, 18, 176, 192, 33, 26, 105, 120, 92, 25, 156, 231, 24, 6, 105, 152, 174, 249, 54, 55, 63, 120, 194, 219, 64, 118, 34, 66, 39, 40, 35, 48, 208, 43, 22, 2, 75, 139, 40, 189, 227 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("b768f3db-ec5b-4c7b-b9a4-3c116d118e8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("622d4ed3-9f32-4d10-be36-befca1f9bc1e") });
        }
    }
}
