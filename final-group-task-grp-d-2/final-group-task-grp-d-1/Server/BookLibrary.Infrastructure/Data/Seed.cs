using BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Data;
public static class DbInitializer
{
    public static void Initialize(ModelBuilder modelBuilder)
    {
        //context.Database.Migrate();

        // Add categories
        var categories = new List<Category>
            {
                new Category { Name = "Fiction" },
                new Category { Name = "Non-Fiction" }
            };
        foreach (var category in categories)
        {
            modelBuilder.Entity<Category>().HasData(category);
        }

        // Add subcategories
        var subcategories = new List<SubCategory>
            {
                new SubCategory { Name = "Romance", CategoryId = categories[0].Id },
                new SubCategory { Name = "Mystery", CategoryId = categories[0].Id },
                new SubCategory { Name = "History", CategoryId = categories[1].Id },
                new SubCategory { Name = "Science", CategoryId = categories[1].Id }
            };
        foreach (var subCategory in subcategories)
        {
            modelBuilder.Entity<SubCategory>().HasData(subCategory);
        }

        // Add books
        var books = new List<Book>
        {
            new Book
            {
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Publisher = "Penguin Classics",
                ISBN = "9780141439518",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81oDm6v%2B7HL.jpg",
                YearPublisher = new DateTime(1813, 1, 28),
                SubCategoryId = subcategories[0].Id
            },
            new Book
            {
                Title = "Jane Eyre",
                Author = "Charlotte Bronte",
                Publisher = "Penguin Classics",
                ISBN = "9780141441146",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51E6fm04DIL._SX322_BO1,204,203,200_.jpg",
                YearPublisher = new DateTime(1847, 10, 16),
                SubCategoryId = subcategories[0].Id
            },
            new Book
            {
                Title = "The Da Vinci Code",
                Author = "Dan Brown",
                Publisher = "Anchor",
                ISBN = "9780307474278",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81c%2BdN5SbNL.jpg",
                YearPublisher = new DateTime(2003, 3, 18),
                SubCategoryId = subcategories[1].Id
            },
            new Book
            {
                Title = "The Girl on the Train",
                Author = "Paula Hawkins",
                Publisher = "Riverhead Books",
                ISBN = "9781594634024",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91mx%2BXxEm1L.jpg",
                YearPublisher = new DateTime(2015, 1, 13),
                SubCategoryId = subcategories[1].Id
            },
            new Book
            {
                Title = "A People's History of the United States",
                Author = "Howard Zinn",
                Publisher = "Harper Perennial Modern Classics",
                ISBN = "9780062397348",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg",
                YearPublisher = new DateTime(1980, 11, 17),
                SubCategoryId = subcategories[2].Id
            },
            new Book 
            {
                Title = "A People's History of the United States",
                Author = "Howard Zinn",
                Publisher = "Harper Perennial Modern Classics",
                ISBN = "9780062397348",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg",
                YearPublisher = new DateTime(1980, 11, 17),
                SubCategoryId = subcategories[2].Id
            },
            new Book
            {
                Title = "Dune",
                Author = "Frank Herbert",
                Publisher = "Chilton Books",
                ISBN = "9780441013593",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg",
                YearPublisher = new DateTime(1965, 8, 1),
                SubCategoryId = subcategories[3].Id
            },
            new Book
            {
                Title = "The Hitchhiker's Guide to the Galaxy",
                Author = "Douglas Adams",
                Publisher = "Pan Books",
                ISBN = "9780330508117",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg",
                YearPublisher = new DateTime(1979, 10, 12),
                SubCategoryId = subcategories[3].Id
            }
        };
        foreach (var book in books)
        {
            modelBuilder.Entity<Book>().HasData(book);
        }
    }
}
