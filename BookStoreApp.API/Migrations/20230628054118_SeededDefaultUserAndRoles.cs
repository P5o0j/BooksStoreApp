using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUserAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07934896-5d35-4486-9a53-ba7bea04b961", null, "User", "USER" },
                    { "7daeb359-87c8-439d-aae3-e8409c51467e", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f9128b3-add1-43f6-9682-5b0f51f8dade", 0, "37465b7c-6966-42f0-9434-50a660b543ff", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEDFwhX+ZQt2Csjzcbe2gKJukRZccT5FTp8shtTQexdEJSHcRS6V7MP0banAamCGbzw==", null, false, "0b7eed24-f99b-4317-b05d-4cd3181528b7", false, "user@bookstore.com" },
                    { "fedd73e8-6dcf-46e7-addf-2fb4f5ddafdd", 0, "7365fb96-a539-4122-bba5-f816a804a35c", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEPE12tdtMlcCq05ZCyDf64zrd8L+zwskLoyvGJK1sMC/iab2q3ZkgIizxU3fOdRD5Q==", null, false, "ba937ec3-3465-4e9b-8fbd-0ce7bc39f3c0", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "07934896-5d35-4486-9a53-ba7bea04b961", "0f9128b3-add1-43f6-9682-5b0f51f8dade" },
                    { "7daeb359-87c8-439d-aae3-e8409c51467e", "fedd73e8-6dcf-46e7-addf-2fb4f5ddafdd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07934896-5d35-4486-9a53-ba7bea04b961", "0f9128b3-add1-43f6-9682-5b0f51f8dade" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7daeb359-87c8-439d-aae3-e8409c51467e", "fedd73e8-6dcf-46e7-addf-2fb4f5ddafdd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07934896-5d35-4486-9a53-ba7bea04b961");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7daeb359-87c8-439d-aae3-e8409c51467e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f9128b3-add1-43f6-9682-5b0f51f8dade");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedd73e8-6dcf-46e7-addf-2fb4f5ddafdd");
        }
    }
}
