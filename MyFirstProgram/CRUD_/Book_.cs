using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MyFirstProgram.CRUD_
{
    class Book_
    {
        const string cons = "server=LAPTOP-221G36GK\\SQLEXPRESS;Database=hcl;Integrated Security=true";
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(cons);
                return con;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        static void ViewAllBooks()
        {

            SqlConnection c = null;

            try
            {
                c = GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("select * from book", c);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("***************View All Books*******************");
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }
        static void AddBook()
        {
            SqlConnection c = null;

            try
            {
                Console.WriteLine("********************Add New Book**********************");
                c = GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("insert into book values(@id,@bknm,@aid)", c);
                Console.WriteLine("Enter bookid");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter author id");
                int aid = int.Parse(Console.ReadLine());

                cmd.Parameters.AddWithValue("@id", bid);
                cmd.Parameters.AddWithValue("@bknm", bookname);
                cmd.Parameters.AddWithValue("@aid", aid);
                int count = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }
        static void deleteBook()
        {

            Console.WriteLine("Enter bookid u want to delete");
            int bid = int.Parse(Console.ReadLine());
            SqlConnection c = null;
            try
            {
                Console.WriteLine("********************Delete Book**********************");
                c = GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("delete from book where bookid=@id", c);
                cmd.Parameters.AddWithValue("@id", bid);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Deleted successfully: " + count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }
        static void updateBook()
        {
            SqlConnection c = null;

            try
            {
                Console.WriteLine("********************Edit Book**********************");
                c = GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("update book set bookname=@bknm,authorid=@aid where bookid=@id", c);
                Console.WriteLine("Enter bookid you want update");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter new bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter new author id");
                int aid =int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@id", bid);
                cmd.Parameters.AddWithValue("@bknm", bookname);
                cmd.Parameters.AddWithValue("@aid", aid);
                int count = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }

        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("************************");
                Console.WriteLine("1---View all books");
                Console.WriteLine("2---Add book");
                Console.WriteLine("3---Delete a Book");
                Console.WriteLine("4---Update a book");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ViewAllBooks();
                        break;
                    case 2:
                        AddBook();
                        break;
                    case 3:
                        deleteBook();
                        break;
                    case 4:
                        updateBook();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine("If you want to stop type n");
                string ch = Console.ReadLine();

                if (ch == "n")
                    break;
            } while (true);
        }
    }
}
