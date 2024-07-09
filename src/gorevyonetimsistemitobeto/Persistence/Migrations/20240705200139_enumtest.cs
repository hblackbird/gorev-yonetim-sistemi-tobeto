using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class enumtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f11fcf78-0b61-44c1-b2d3-4e10ade71d0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("501236b7-86f9-4b22-8758-740eecf4e92f"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("04945c5c-591f-467e-9ba5-fedffaf85d19"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 179, 251, 130, 152, 203, 145, 114, 105, 187, 75, 15, 63, 3, 251, 79, 85, 175, 123, 82, 36, 93, 167, 12, 28, 93, 119, 238, 177, 174, 29, 145, 165, 241, 48, 144, 183, 160, 232, 155, 15, 230, 115, 126, 231, 127, 172, 74, 251, 180, 53, 115, 169, 66, 24, 131, 21, 111, 31, 95, 83, 55, 52, 159, 236 }, new byte[] { 9, 192, 77, 221, 83, 174, 32, 31, 106, 252, 150, 37, 163, 98, 70, 131, 97, 148, 238, 78, 147, 223, 188, 238, 11, 134, 154, 105, 139, 64, 118, 86, 90, 76, 240, 29, 126, 133, 172, 96, 209, 60, 122, 91, 192, 203, 87, 120, 70, 149, 181, 49, 235, 13, 193, 20, 11, 35, 23, 50, 214, 227, 55, 100, 38, 146, 57, 224, 41, 223, 59, 108, 124, 123, 160, 21, 202, 216, 36, 76, 26, 153, 192, 132, 151, 71, 189, 170, 235, 209, 149, 100, 141, 158, 129, 104, 242, 224, 184, 40, 182, 58, 242, 220, 231, 246, 25, 105, 198, 150, 157, 203, 18, 147, 92, 63, 103, 153, 19, 194, 124, 189, 20, 156, 196, 188, 82, 235 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("18d6c8a4-6bfc-438e-b576-e3ee67abb3a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("04945c5c-591f-467e-9ba5-fedffaf85d19") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("18d6c8a4-6bfc-438e-b576-e3ee67abb3a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04945c5c-591f-467e-9ba5-fedffaf85d19"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("501236b7-86f9-4b22-8758-740eecf4e92f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 83, 59, 249, 20, 111, 12, 179, 220, 194, 140, 199, 173, 236, 128, 169, 201, 218, 12, 19, 73, 50, 25, 245, 251, 148, 61, 225, 161, 237, 20, 1, 20, 70, 9, 241, 24, 210, 181, 17, 166, 215, 19, 22, 121, 76, 216, 122, 9, 220, 103, 40, 152, 91, 84, 237, 139, 195, 125, 239, 204, 44, 170, 213, 118 }, new byte[] { 89, 98, 57, 249, 242, 185, 175, 211, 209, 56, 3, 152, 203, 13, 204, 15, 69, 154, 245, 211, 51, 74, 189, 36, 218, 66, 1, 153, 167, 39, 5, 88, 102, 68, 131, 199, 228, 181, 190, 178, 195, 140, 25, 106, 63, 41, 67, 213, 38, 113, 8, 47, 97, 121, 157, 94, 140, 79, 20, 232, 44, 72, 55, 211, 196, 221, 62, 61, 168, 29, 81, 25, 57, 70, 98, 137, 91, 221, 111, 226, 141, 57, 35, 143, 57, 186, 55, 0, 119, 80, 249, 178, 125, 78, 104, 62, 19, 197, 119, 165, 3, 47, 214, 137, 212, 45, 222, 6, 217, 158, 36, 62, 114, 128, 89, 72, 50, 122, 94, 159, 128, 177, 104, 109, 51, 253, 211, 255 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("f11fcf78-0b61-44c1-b2d3-4e10ade71d0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("501236b7-86f9-4b22-8758-740eecf4e92f") });
        }
    }
}
