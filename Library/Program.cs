namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Books book1 = new Books(01, "White Nights", "Dostoevsky", 6789, "Fiction", 5, 3);
            Books book2 = new Books(02, "War and Peace", "Tolstoy", 1234, "Historical Fiction", 10, 7);
            Books book3 = new Books(03, "The Great Gatsby", "F. Scott Fitzgerald", 5678, "Classic", 8, 5);
            Books book4 = new Books(04, "1984", "George Orwell", 9101, "Dystopian", 6, 2);
            Books book5 = new Books(05, "To Kill a Mockingbird", "Harper Lee", 1121, "Southern Gothic", 4, 1);

            User user1 = new User(01, "Alice Smith", "alice@gmail.com", "123-456-7890", "123 Elm St, Springfield");
            User user2 = new User(02, "Bob Johnson", "bob@gmail.com", "987-654-3210", "456 Oak St, Springfield");
            User user3 = new User(03, "Charlie Brown", "brown@gmail.com", "555-123-4567", "789 Pine St, Springfield");

        }
     
    }
}