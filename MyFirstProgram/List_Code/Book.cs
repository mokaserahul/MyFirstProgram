using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.List_Code
{
    class Book
    {
        string bookname;
        int price;
        string author;

       
        public string Bookname { get => bookname; set => bookname = value; }
        public int Price { get => price; set => price = value; }
        public string Author { get => author; set => author = value; }

        public Book(string bookname, int price, string author)
        {
            this.Bookname = bookname;
            this.Price = price;
            this.Author = author;
        }
        public Book()
        {

        }

        public override string ToString()
        {
            return $"Bookname:{bookname}  Author:{author}  Price:{price}";
        }
    }
    class BookDetails
    {
        
        static void Main(string[] args)
        {
            
            List<Book> lst = new List<Book>();
            lst.Add(new Book("Java", 900, "Kathy"));
            lst.Add(new Book("C++", 800, "Kanetkar"));
            lst.Add(new Book("C Sharp", 1000, "Balguru"));
            lst.Add(new Book("Python", 700, "Ramesh"));
            lst.Sort();
            foreach(Book b in lst)
            {
                Console.WriteLine(b);
            }
        }
    }

    class Movie:IComparable<Movie>
    {
        string moviename;
        int rating;
        public int CompareTo(Movie m)
        {
            return this.rating.CompareTo(m.rating);
        }
        public Movie()
        {

        }
        public Movie(string moviename, int rating)
        {
            this.Moviename = moviename;
            this.Rating = rating;
        }
        public string Moviename { get => moviename; set => moviename = value; }
        public int Rating { get => rating; set => rating = value; }
       
       
        public override string ToString()
        {
            return $" MovieName:{moviename}  Rating:{rating}";
        }
    }
    class Movie_Details
    {
        static void Main(string[] args)
        {
            List<Movie> lst = new List<Movie>();
            lst.Add(new Movie("Bramhastra", 3));
            lst.Add(new Movie("Shamshera", 2));
            lst.Add(new Movie("Shershaah", 5));
            lst.Add(new Movie("Bhool Bhulaiyya 2", 4));
            lst.Sort();
            foreach(Movie m in lst)
            {
                Console.WriteLine(m);
            }
        }
    }
}
