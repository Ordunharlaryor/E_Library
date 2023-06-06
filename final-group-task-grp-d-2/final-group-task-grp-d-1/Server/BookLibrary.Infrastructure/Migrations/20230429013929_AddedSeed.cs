using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookLibrary.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("236d168f-f2c5-47a2-b90d-cc5a04657e2d"), "Fiction" },
                    { new Guid("9f508a4e-a364-4c03-aa1b-95c709c19e41"), "Non-Fiction" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("4a8702ad-f738-4bd9-8813-4e052ddb39f2"), new Guid("9f508a4e-a364-4c03-aa1b-95c709c19e41"), "Science" },
                    { new Guid("5f3a82dc-0e72-405c-b921-04cbf01a3e43"), new Guid("236d168f-f2c5-47a2-b90d-cc5a04657e2d"), "Romance" },
                    { new Guid("9898f53a-040e-4442-b15e-7d0d23f85116"), new Guid("9f508a4e-a364-4c03-aa1b-95c709c19e41"), "History" },
                    { new Guid("b2f47482-983c-4da6-a1c2-d85a556d6906"), new Guid("236d168f-f2c5-47a2-b90d-cc5a04657e2d"), "Mystery" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ISBN", "ImageUrl", "Publisher", "SubCategoryId", "Title", "YearPublisher" },
                values: new object[,]
                {
                    { new Guid("02a1ae48-e6f9-41fa-9364-e0ec189e4ad9"), "Douglas Adams", "9780330508117", "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg", "Pan Books", new Guid("4a8702ad-f738-4bd9-8813-4e052ddb39f2"), "The Hitchhiker's Guide to the Galaxy", new DateTime(1979, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1628e6db-489b-49c0-9b8b-4dd6c36fcdfd"), "Howard Zinn", "9780062397348", "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg", "Harper Perennial Modern Classics", new Guid("9898f53a-040e-4442-b15e-7d0d23f85116"), "A People's History of the United States", new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d5983ae-55a5-4a25-be43-a4c597ad165f"), "Frank Herbert", "9780441013593", "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg", "Chilton Books", new Guid("4a8702ad-f738-4bd9-8813-4e052ddb39f2"), "Dune", new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ee12438-087f-4021-b7ba-53658f58a03a"), "Jane Austen", "9780141439518", "https://images-na.ssl-images-amazon.com/images/I/81oDm6v%2B7HL.jpg", "Penguin Classics", new Guid("5f3a82dc-0e72-405c-b921-04cbf01a3e43"), "Pride and Prejudice", new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("437e84cb-c32a-48d3-b52a-e5a7ee97be8f"), "Howard Zinn", "9780062397348", "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg", "Harper Perennial Modern Classics", new Guid("9898f53a-040e-4442-b15e-7d0d23f85116"), "A People's History of the United States", new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("920305b6-bc36-45f6-94d2-7f674ce41164"), "Paula Hawkins", "9781594634024", "https://images-na.ssl-images-amazon.com/images/I/91mx%2BXxEm1L.jpg", "Riverhead Books", new Guid("b2f47482-983c-4da6-a1c2-d85a556d6906"), "The Girl on the Train", new DateTime(2015, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("934f9aff-b26e-4ec4-addf-2a0412ad6fe2"), "Dan Brown", "9780307474278", "https://images-na.ssl-images-amazon.com/images/I/81c%2BdN5SbNL.jpg", "Anchor", new Guid("b2f47482-983c-4da6-a1c2-d85a556d6906"), "The Da Vinci Code", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e09760b4-329d-4435-beb4-ae51dcede312"), "Charlotte Bronte", "9780141441146", "https://images-na.ssl-images-amazon.com/images/I/51E6fm04DIL._SX322_BO1,204,203,200_.jpg", "Penguin Classics", new Guid("5f3a82dc-0e72-405c-b921-04cbf01a3e43"), "Jane Eyre", new DateTime(1847, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("02a1ae48-e6f9-41fa-9364-e0ec189e4ad9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1628e6db-489b-49c0-9b8b-4dd6c36fcdfd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d5983ae-55a5-4a25-be43-a4c597ad165f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3ee12438-087f-4021-b7ba-53658f58a03a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("437e84cb-c32a-48d3-b52a-e5a7ee97be8f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("920305b6-bc36-45f6-94d2-7f674ce41164"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("934f9aff-b26e-4ec4-addf-2a0412ad6fe2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e09760b4-329d-4435-beb4-ae51dcede312"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a8702ad-f738-4bd9-8813-4e052ddb39f2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5f3a82dc-0e72-405c-b921-04cbf01a3e43"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9898f53a-040e-4442-b15e-7d0d23f85116"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b2f47482-983c-4da6-a1c2-d85a556d6906"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("236d168f-f2c5-47a2-b90d-cc5a04657e2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f508a4e-a364-4c03-aa1b-95c709c19e41"));
        }
    }
}
