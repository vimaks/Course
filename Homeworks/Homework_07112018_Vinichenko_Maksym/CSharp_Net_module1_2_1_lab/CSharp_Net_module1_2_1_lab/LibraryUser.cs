using System;

namespace CSharp_Net_module1_2_1_lab
{

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser



    // 2) declare class LibraryUser, it implements ILibraryUser
    public class LibraryUser : ILibraryUser
    {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        public string FirstName { get; }
        public string LastName { get; }
        public int Id { get; }
        public string Phone { get; set; }
        public int BookLimit { get; }



        // 4) declare field (bookList) as a string array
        private string[] bookList = new string[0];

        // 5) declare indexer BookList for array bookList
        public string this[int index]
        {
            get
            {
                return bookList[index];
            }
            set
            {
                bookList[index] = value;
            }
        }

            // 6) declare constructors: default and parameter
        public LibraryUser()
        {
            bookList = new string[0];
            FirstName = "InknownUser";
            LastName = "InknownUser";
            Phone = "InknownNumber";
            Id = 0;
        }

        public LibraryUser(string firstName, string lastName, string phone, int id)
        {
            bookList = new string[0];
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Id = id;
        }


        // 7) declare methods: 

        //AddBook() – add new book to array bookList

        //RemoveBook() – remove book from array bookList

        //BookInfo() – returns book info by index

        //BooksCout() – returns current count of books
        public void AddBook(string book)
        {
            Array.Resize(ref bookList, bookList.Length + 1);
            bookList[bookList.Length - 1] = book;
        }

        public void RemoveBook(string book)
        {
            int removeIndex = 0;
            for (int i = 0; i < bookList.Length; i++)
            {
                if (bookList[i] == book)
                    removeIndex = i;
            }

            string[] newBookList = new string[bookList.Length - 1];

            for (int i = 0; i < removeIndex; i++)
            {
                newBookList[i] = bookList[i];
            }

            for (int i = removeIndex + 1; i < newBookList.Length; i++)
            {
                newBookList[i] = bookList[i];
            }
            bookList = newBookList;
        }

        public string BookInfo(int bookIndex)
        {
            return bookList[bookIndex];
        }

        public int BooksCount()
        {
            return bookList.Length;
        }
    }

}
