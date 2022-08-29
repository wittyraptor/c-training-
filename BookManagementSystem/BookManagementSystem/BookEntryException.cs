using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BookManagementSystem
{
   public class BookEntryException : Exception
    {

    }
   
    public class Book_ID_Exception : Exception
    {
        public Book_ID_Exception(String message) : base(message)
        {

        }

    }

    public class TestBookID
    {
        public static void validateBookID(int book_id)
        {
            if(book_id < 9999 )
            {
                throw new Book_ID_Exception("Book id should contain 5 digits");
            }

        }
    }

    

  public  class bookNameException : Exception
    {
        public bookNameException(string message) : base(message)
        {

        }
    }

    public class testBookNameException
    {
        public static void validateBookName(string name)
        {
            if(name.Length <1 )
            {
                throw new bookNameException("Book Name cannot be null");
            }
        }

    }

   public class bookLoTException : Exception
    {
        public bookLoTException(string message) : base(message)
        {

        }
    }

public class testBookLoT
    {
        public static void validateBookLoT(string Lot)
        {
            string[] LoTs = { ".NET", "Java", "IMS", "V&V", "BI", "RDBMS" };

            if (!(LoTs.Contains(Lot) )){
                throw new bookLoTException("LoT doesnot belong to predifined rules");
            }
        }

    }
}
