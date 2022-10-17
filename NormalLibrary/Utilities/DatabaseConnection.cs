﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalLibrary
{
    internal class DatabaseConnection
    {
        private static readonly string link = @"Data Source=DESKTOP-BAMD39I\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
        private static SqlConnection CreateConnection()
        {
            return new SqlConnection(link);
        }
        public static DataTable GetDataTable(string sql)
        {
            SqlConnection connecting = CreateConnection();
            connecting.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connecting);
            DataTable storage = new DataTable();
            adapter.Fill(storage);
            connecting.Close();
            adapter.Dispose();
            return storage;
        }
        public static List<Book> GetBookList(string sql) {
            SqlConnection connecting = CreateConnection();
            connecting.Open();
            SqlCommand command = new SqlCommand(sql, connecting);
            List<Book> list_book = new List<Book>();
            using (var rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Book new_book = new Book()
                    {
                        BookId = int.Parse(rdr["BookId"].ToString().Trim()),
                        BookName = rdr["BookName"].ToString().Trim(),
                        BookNumberOfPages = int.Parse(rdr["BookNumberOfPages"].ToString().Trim()),
                        BookProductDate = rdr["BookProductDate"].ToString().Trim(),
                        BookNumberOfCopies = int.Parse(rdr["BookNumberOfCopies"].ToString().Trim()),
                        BookDescription = rdr["BookDescription"].ToString().Trim(),
                        BookFee = float.Parse(rdr["BookFee"].ToString().Trim()),
                        BookImage = rdr["BookImage"].ToString().Trim(),


                    };
                    list_book.Add(new_book);
                }
                rdr.Close();
            }
            connecting.Close();
            return list_book;
        }
        public static List<Genre> GetGenreList(string sql)
        {
            SqlConnection connecting = CreateConnection();
            connecting.Open();
            SqlCommand command = new SqlCommand(sql, connecting);
            List<Genre> list_genre = new List<Genre>();
            using (var rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Genre new_genre = new Genre()
                    {
                        GenreId = int.Parse(rdr["GenreId"].ToString().Trim()),
                        GenreName = rdr["GenreName"].ToString().Trim(),
                    };
                    list_genre.Add(new_genre);
                }
                rdr.Close();
            }
            connecting.Close();
            return list_genre;
        }
        public static List<Author> GetAuthorList(string sql)
        {
            SqlConnection connecting = CreateConnection();
            connecting.Open();
            SqlCommand command = new SqlCommand(sql, connecting);
            List<Author> list_author = new List<Author>();
            using (var rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Author new_genre = new Author()
                    {
                        AuthorId = int.Parse(rdr["AuthorId"].ToString().Trim()),
                        AuthorName = rdr["AuthorName"].ToString().Trim(),
                    };
                    list_author.Add(new_genre);
                }
                rdr.Close();
            }
            connecting.Close();
            return list_author;
        }
        public static List<Publisher> GetPublisherList(string sql)
        {
            SqlConnection connecting = CreateConnection();
            connecting.Open();
            SqlCommand command = new SqlCommand(sql, connecting);
            List<Publisher> list_publisher = new List<Publisher>();
            using (var rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Publisher new_publisher = new Publisher()
                    {
                        PublisherId = int.Parse(rdr["PublisherId"].ToString().Trim()),
                        PublisherName = rdr["PublisherName"].ToString().Trim(),
                    };
                    list_publisher.Add(new_publisher);
                }
                rdr.Close();
            }
            connecting.Close();
            return list_publisher;
        }
        public static List<User> GetUserList(string sql)
        {
            SqlConnection connecting = CreateConnection();
            connecting.Open();
            SqlCommand command = new SqlCommand(sql, connecting);
            List<User> list_user = new List<User>();
            using (var rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    User new_user = new User()
                    {
                        UserId = int.Parse(rdr["UserId"].ToString().Trim()),
                        UserName = rdr["UserName"].ToString().Trim(),
                        UserRoles = int.Parse(rdr["UserRoles"].ToString().Trim()),
                        UserPassword = rdr["UserPassword"].ToString().Trim(),
                        ProfileId = int.Parse(rdr["ProfileId"].ToString().Trim()),
                        UserApproved = int.Parse(rdr["UserApproved"].ToString().Trim()),

                    };
                    list_user.Add(new_user);
                }
                rdr.Close();
            }
            connecting.Close();
            return list_user;
        }
        public static UserProfile GetUserProfile(string sql)
        {
            SqlConnection connecting = CreateConnection();
            connecting.Open();
            SqlCommand command = new SqlCommand(sql, connecting);
            UserProfile new_profile = new UserProfile();
            using (var rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    UserProfile profile = new UserProfile()
                    {
                        ProfileId = int.Parse(rdr["UserId"].ToString().Trim()),
                        ProfileFirstName = rdr["ProfileFirstName"].ToString().Trim(),
                        ProfileLastName = rdr["ProfileLastName"].ToString().Trim(),
                        ProfileSchoolId = rdr["ProfileSchoolId"].ToString().Trim(),
                        ProfileAddress = rdr["ProfileAddress"].ToString().Trim(),
                        ProfilePhoneNumber = rdr["ProfilePhoneNumber"].ToString().Trim(),
                        ProfileEmail = rdr["ProfileEmail"].ToString().Trim(),
                    };
                    new_profile = profile;
                }
                rdr.Close();
            }
            connecting.Close();
            return new_profile;
        }
        public static bool CheckUserLogin(string user_name, string user_password) {
            SqlConnection connecting = CreateConnection();
            connecting.Open();
            string sql = "SELECT Count([UserId]) FROM [Library].[dbo].[User] WHERE [UserName] = '" + user_name + "' AND [UserPassword] = '"+ user_password + "'; ";
            SqlCommand command = new SqlCommand(sql, connecting);
            Int32 count = (Int32)command.ExecuteScalar();
            if (count > 0) {
                string new_sql = "SELECT * FROM [Library].[dbo].[User] WHERE [UserName] = '" + user_name + "' AND [UserPassword] = '" + user_password + "'; ";
                SqlCommand new_command = new SqlCommand(new_sql, connecting);
                using (var rdr = new_command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        User new_user = new User()
                        {
                            UserId = int.Parse(rdr["UserId"].ToString().Trim()),
                            UserName = rdr["UserName"].ToString().Trim(),
                            UserRoles = int.Parse(rdr["UserRoles"].ToString().Trim()),
                            UserPassword = rdr["UserPassword"].ToString().Trim(),
                            ProfileId = int.Parse(rdr["ProfileId"].ToString().Trim()),
                            UserApproved = int.Parse(rdr["UserApproved"].ToString().Trim()),
                        };
                        Program.login_user = new_user;
                    }
                    rdr.Close();
                }
                connecting.Close();
                return true;
            }
            else
            {
                connecting.Close();
                return false;
            }
        }
        public static void CreateCommand(string sql)
        {
            SqlConnection connecting = CreateConnection();
            connecting.Open();
            SqlCommand command = new SqlCommand(sql, connecting);
            command.ExecuteNonQuery();
            connecting.Close();
            command.Dispose();
        }
    }
}