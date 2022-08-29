using System;
using System.Collections;
using System.Collections.Generic;
namespace BookManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
           List<Library> books = new List<Library>();
           

            while (flag)
            {
                Library b1 = new Library();
                Console.WriteLine("Enter the choice: \n 1 --> Entry Book Details" +
               "\n 2 --> Display Book Details \n 3 ---> Remove Book \n 4 --> Exit \n Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        b1.setBookValues();
                        books.Add(b1);
                        break;
                    case 2:
                        foreach (var i in books) { 
                        i.displayBookValues();
                }
                        break;
                    case 3:
                        Console.WriteLine("Enter Book ID to remove:");
                        int id =Convert.ToInt32( Console.ReadLine());
                       // Library remvOjb;
                        foreach(var i in books)
                        {
                            if (i.Book_ID == id)
                            {
                                books.Remove(i);
                                Console.WriteLine("Book removed succesfully");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Book not found");
                            }
                        }
                        
                        break;
                    case 4:
                        flag = false;
                        break;
                   default:
                        Console.WriteLine("Enter Correct Choice ");
                        break;


                }
                
            }
           
           
        }
    }
}
