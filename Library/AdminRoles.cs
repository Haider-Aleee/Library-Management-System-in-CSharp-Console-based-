using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class AdminRoles
    {
        public int BookId;
        public string ?Title;
        public string ?Author;
        public int ISBN;
        public string ?Genre;
        int TotalCopies;
        int AvailableCopies;

        private List<Books> bookList = new List<Books>();
        private List<Student> studentList = new List<Student>();
        private List<Books> issuedBooksList = new List<Books>();
        public void AddNewBook()
        {
            Console.WriteLine("Enter Book ID:");
            BookId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Title:");
            Title = Console.ReadLine();
            Console.WriteLine("Enter Book Author:");
            Author = Console.ReadLine();
            Console.WriteLine("Enter Book ISBN:");
            ISBN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Genre:");
            Genre = Console.ReadLine();
            Console.WriteLine("Enter Total Copies:");
            TotalCopies = Convert.ToInt32(Console.ReadLine());

            AvailableCopies = TotalCopies; // Initially, all copies are available

            Books book = new Books(BookId, Title, Author, ISBN, Genre, TotalCopies, AvailableCopies);
            
            bookList.Add(book);

            Console.WriteLine($"Book '{book.Title}' by {book.Author} added successfully with ID {book.Id}.");

        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter Book Title to remove:");
            Title = Console.ReadLine();
            foreach (Books book in bookList)
            {
                if(book.Title == Title)
                {
                    bookList.Remove(book);
                    Console.WriteLine($"Book '{book.Title}' removed successfully.");
                    return;
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }

        }

        public void UpdateBookDetails()
        {
            Console.WriteLine("Enter Book name to update:");
            Title = Console.ReadLine();
            foreach (Books book in bookList)
            {
                if (book.Title == Title)
                {
                    Console.WriteLine("Enter new Title:");
                    book.Title = Console.ReadLine();
                    Console.WriteLine("Enter new Author:");
                    book.Author = Console.ReadLine();
                    Console.WriteLine("Enter new ISBN:");
                    book.ISBN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter new Genre:");
                    book.Genre = Console.ReadLine();
                    Console.WriteLine("Enter new Total Copies:");
                    book.TotalCopies = Convert.ToInt32(Console.ReadLine());
                    book.AvailableCopies = book.TotalCopies;
                    Console.WriteLine($"Book '{book.Title}' updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("List of all books available right now in the library: ");
            foreach (Books book in bookList)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Total Copies: {book.TotalCopies}, Available Copies: {book.AvailableCopies}");
            }
        }

        public void IssueBook()
        {
            Console.WriteLine("Enter Book Title to issue:");
            Title = Console.ReadLine();
            Console.WriteLine("Enter Student ID:");
            int StudentId= Convert.ToInt32(Console.ReadLine());

            foreach (Books book in bookList)
            {
                if (book.Title == Title)
                {
                    if (book.AvailableCopies > 0)
                    {
                        foreach (Student student in studentList)
                        {
                            if (student.StudentId == StudentId)
                            {
                                book.AvailableCopies--;
                                issuedBooksList.Add(book);
                                Console.WriteLine($"Book '{book.Title}' issued to Student ID: {student.StudentId}");
                                break;
                            }
                        }
                      
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, no copies of '{book.Title}' are available for issue.");
                    }
                    return;
                }
            }

        }

        public void ViewAllIssuedBooks()
        {
            foreach (Books book in issuedBooksList)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Total Copies: {book.TotalCopies}, Available Copies: {book.AvailableCopies}");
            }
        }

        public void SystemSummary()
        {
            Console.WriteLine("Library System Summary:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Details of all books:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Total Books: " + bookList.Count);
            ViewAllBooks();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Details of all students:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Total Students: " + studentList.Count);
            ViewAllStudents();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Details of all issued books:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Total Issued Books: " + issuedBooksList.Count);
            ViewAllIssuedBooks();
            Console.WriteLine("--------------------------------------------------");
        }

        public void ViewAllStudents()
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Email: {student.Email}");
            }
        }
    }
}
