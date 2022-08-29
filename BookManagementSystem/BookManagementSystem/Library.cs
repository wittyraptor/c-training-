using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagementSystem
{
    class Library
    {
        public string  Name, ISBN, Publisher, Language, LoT, Summary;
        public int Book_ID, Price,Number_of_pages;

        public void setBookValues()
        {
            Console.WriteLine("...............Welcome..........\n Enter the Book Details:");
            Console.WriteLine("Enter Book ID");
            try
            {   
                int book_id= Convert.ToInt32(Console.ReadLine());
                TestBookID.validateBookID(book_id);
                this.Book_ID = book_id;
            }
            catch(Book_ID_Exception e)
            {
                Console.WriteLine(e);
            }
            //this.Book_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Name");

            try
            {
                string name= Console.ReadLine();
                testBookNameException.validateBookName(name);
                this.Name = name;
            }
            catch(bookNameException e)
            {
                Console.WriteLine(e);
            }
           // this.Name = Console.ReadLine();

            Console.WriteLine("Enter Book ISBN");
            this.ISBN = Console.ReadLine();

            Console.WriteLine("Enter Book Price");
            this.Price =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Book Publisher");
            this.Publisher = Console.ReadLine();

            Console.WriteLine("Enter Number of Pages in the Book");
            this.Number_of_pages = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Language");
           string language = Console.ReadLine();
            if (String.IsNullOrEmpty(language))
            {
                this.Language = "English";
            }
            else
            {
                this.Language = language;

            }


            Console.WriteLine("Enter Book LoT");
            try
            {
                string lot = Console.ReadLine();
                testBookLoT.validateBookLoT(lot);
                this.LoT = lot;
            }
            catch(bookLoTException e)
            {
                Console.WriteLine(e);
            }
           // this.LoT = Console.ReadLine();

            Console.WriteLine("Enter Book Summary");
            this.Summary = Console.ReadLine();

        }

        public void displayBookValues()
        {
            Console.WriteLine("----------- Book details are : ---------");
            Console.WriteLine("Book ID : " + this.Book_ID+
                                            "\n Book Name : "+this.Name+
                                            " \n Book ISBN : "+this.ISBN+
                                            "\n Book Price : "+this.Price+
                                            "\n Book Publisher : "+this.Publisher+
                                            "\n Number of Pages in the Book : "+this.Number_of_pages+
                                            "\n Language : "+this.Language+
                                            "\n LoT : "+this.LoT+
                                            "\n Summary : "+this.Summary);


        }
    }
}
