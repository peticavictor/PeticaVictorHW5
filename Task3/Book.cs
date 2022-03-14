using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Task3
{
    class Book
    {
        private String name;
        public Book(String name)
        {
            this.name = name;
        }
        public static List<Book> books = new List<Book>();

        public static List<Book> operator +(List<Book> books, Book book)
        {
            books.Add(book);
            return books;
        }
        public static List<Book> operator -(List<Book> books, Book book)
        {
            books.Remove(book);
            return books;
        }
        public override string ToString()
        {
            return this.name;
        }
        static void Main(string[] args)
        {
            Book.books = books + new Book("Erkul Puaro");
         
            // automatically overloaded
            Book.books += new Book("War and Peace");
            Book.books += new Book("Robinson Crusoe");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine(Book.books.Count);
        }
    }
}
