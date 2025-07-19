namespace Library
{
    public class Program
    {
        private static List<Admin> admins = new List<Admin>();
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library Management System!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Please select your role:");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Student");
            Console.WriteLine("---------------------------------------------------");
            int role= Convert.ToInt32(Console.ReadLine());
            string anotherOperation;
            if (role == 1)
            {
                do
                {
                    RegisterAdmin();
                    Console.WriteLine("Welcome Admin!");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Select which operation you want to perform:");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("1. Add New Book");
                    Console.WriteLine("2. Remove Book");
                    Console.WriteLine("3. Update a Book's Details");
                    Console.WriteLine("4. View All Available Books");
                    Console.WriteLine("5. Issue a Book");
                    Console.WriteLine("6. View All Issued Books");
                    Console.WriteLine("7. View System Summary");
                    Console.WriteLine("8. Add New Student");
                    Console.WriteLine("9. Remove Student");
                    Console.WriteLine("10. View All Students");
                    Console.WriteLine("11. Search Book By Title");
                    Console.WriteLine("12. Search for a Student");
                    Console.WriteLine("13. Exit");
                    Console.WriteLine("---------------------------------------------------");

                    int operation = Convert.ToInt32(Console.ReadLine());
                    AdminRoles adminRoles = new AdminRoles();

                    switch (operation)
                    {
                        case 1:
                            adminRoles.AddNewBook();
                            break;
                        case 2:
                            adminRoles.RemoveBook();
                            break;
                        case 3:
                            adminRoles.UpdateBookDetails();
                            break;
                        case 4:
                            adminRoles.ViewAllBooks();
                            break;
                        case 5:
                            adminRoles.IssueBook();
                            break;
                        case 6:
                            adminRoles.ViewAllIssuedBooks();
                            break;
                        case 7:
                            adminRoles.SystemSummary();
                            break;
                        case 8:
                            adminRoles.AddNewStudent();
                            break;
                        case 9:
                            adminRoles.RemoveStudent();
                            break;
                        case 10:
                            adminRoles.ViewAllStudents();
                            break;
                        case 11:
                            adminRoles.SearchBookByTitle();
                            break;
                        case 12:
                            adminRoles.SearchStudentById();
                            break;
                        case 13:
                            Console.WriteLine("Exiting the system. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid operation selected.");
                            break;
                    }
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Want to perform another operation? (yes/no)");
                    anotherOperation = Console.ReadLine().ToLower();
                } while (anotherOperation == "yes" || anotherOperation == "y");
                Console.WriteLine("Thank you for using the Library Management System!");
            }
            else if (role == 2)
            {
                do
                {
                    AdminRoles adminRoles = new AdminRoles();
                    adminRoles.AddNewStudent();
                    StudentRoles studentRoles = new StudentRoles();
                    Console.WriteLine("Welcome Student!");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Select which operation you want to perform:");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("1. View Available Books");
                    Console.WriteLine("2. Borrow a Book");
                    Console.WriteLine("3. Return Borrowed Book");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("---------------------------------------------------");
                    int studentOperation = Convert.ToInt32(Console.ReadLine());
                    switch (studentOperation)
                    {
                        case 1:
                            studentRoles.ViewAvailableBooks(adminRoles.bookList);
                            break;
                        case 2:
                            studentRoles.BorrowABook();
                            break;
                        case 3:
                            studentRoles.ReturnBorrowedBook(adminRoles.issuedBooksList, adminRoles.bookList);
                            break;
                        case 4:
                            Console.WriteLine("Exiting the system. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid operation selected.");
                            break;
                    }

                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Want to perform another operation? (yes/no)");
                    anotherOperation = Console.ReadLine().ToLower();

                } while(anotherOperation=="yes" || anotherOperation=="y");
            }
            else
            {
                Console.WriteLine("Invalid role selected.");
            }

        }

        public static void RegisterAdmin()
        {
            Console.WriteLine("Enter Admin ID:");
            int AdminId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Admin Name:");
            string AdminName = Console.ReadLine();
            Console.WriteLine("Enter Admin Email:");
            string AdminEmail = Console.ReadLine();
            
            Admin newAdmin = new Admin(AdminId, AdminName, AdminEmail);
            admins.Add(newAdmin);

        }

    }
}