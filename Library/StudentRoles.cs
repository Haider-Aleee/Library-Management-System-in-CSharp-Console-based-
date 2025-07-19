using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class StudentRoles
    {
        public int Id;
        AdminRoles adminRoles = new AdminRoles();
        public void ViewAvailableBooks(List<Books> bookList)
        {
            Console.WriteLine("Available Books:");
            foreach (var book in bookList)
            {
                if (book.AvailableCopies > 0)
                {
                    Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available Copies: {book.AvailableCopies}");
                }
            }
        }

        public void BorrowABook()
        {
            Console.WriteLine("Tell admin the following details: ");
            adminRoles.IssueBook();
        }

        public void ReturnBorrowedBook(List<Books> issuedBooksList, List<Books> bookList)
        {
            Console.WriteLine("Enter the ID of the book: ");
            Id= Convert.ToInt32(Console.ReadLine());
            foreach (Books book in issuedBooksList)
            {
                if(book.Id==Id)
                {
                    issuedBooksList.Remove(book);
                    bookList.Add(book);
                }
            }
            Console.WriteLine($"Book with ID {Id} returned successfully.");
        }
    }
}
