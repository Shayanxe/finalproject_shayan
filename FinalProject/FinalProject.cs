/*
 *
 *
 * 
 * 
 شایان باقری *
 برنامه سازی پیشرفته *
 سه شنبه تایم 1 تا 3 *
 پروژه نهایی *
 *
 *
 *
 * 
 */


using System.Collections.Generic;
using System;

namespace FinalProject
{
    class FinalProject
    {
        public static void Main()
        {
            bool isMenuActive = true;
            List<BookModel> bookList = new List<BookModel>();

            bookList.Add(new BookModel(1, "Design Patterns", "Richard Helm", 100));
            bookList.Add(new BookModel(2, "The Art of Computer Programming", "Donald Knuth", 20));
            bookList.Add(new BookModel(3, "Clean code", "Robert C Martin", 150));

            while (isMenuActive)
            {
                Console.WriteLine("1. Add a new book");
                Console.WriteLine("2. Search the book by name");
                Console.WriteLine("3. Show all the existing books");
                Console.WriteLine("4. Remove book by ID");
                Console.WriteLine("5. Show the most expensive book");
                Console.WriteLine("6. Show the cheapest book");
                Console.WriteLine("7. Show books count");
                Console.WriteLine("8. Show all the existing books sorted by price");
                Console.WriteLine("9. Show the books between two prices");
                Console.WriteLine("0. Exit");
                Console.WriteLine("\n");
                Console.Write("Choose from above: ");
                int menuInput = int.Parse(Console.ReadLine());


                switch (menuInput)
                {
                    case 1:
                    {
                        Console.Clear();
                        Console.Write("Book id : ");
                        int bookID = int.Parse(Console.ReadLine());
                        Console.Write("Book title : ");
                        string bookTitle = Console.ReadLine();
                        Console.Write("Book Writter : ");
                        string bookWritter = Console.ReadLine();
                        Console.Write("Book Price : ");
                        int bookPrice = int.Parse(Console.ReadLine());

                        BookModel book = new BookModel(bookID, bookTitle, bookWritter, bookPrice);
                        bookList.Add(book);

                        Console.WriteLine("Book Added Successfully!");
                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    case 2:
                    {
                        Console.Clear();

                        var tempList = new List<BookModel>();

                        Console.Write("Book title : ");
                        string query = Console.ReadLine();

                        foreach (BookModel bookModel in bookList)
                        {
                            if (bookModel.getTitle().ToLower().Contains(query.ToLower()))
                            {
                                tempList.Add(bookModel);
                            }
                        }

                        if (tempList.Count > 0)
                        {
                            foreach (var bookModel in tempList)
                            {
                                Console.WriteLine("=======================");
                                Console.WriteLine(bookModel.ToString());
                                Console.WriteLine("=======================");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nothing found!");
                        }

                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    case 3:
                    {
                        Console.Clear();
                        foreach (BookModel bookModel in bookList)
                        {
                            Console.WriteLine("=======================");
                            Console.WriteLine(bookModel.ToString());
                            Console.WriteLine("=======================");
                        }

                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    case 4:
                    {
                        Console.Clear();

                        BookModel tempBook = null;

                        Console.Write("Book ID to remove : ");
                        int query = int.Parse(Console.ReadLine());

                        foreach (var bookModel in bookList)
                        {
                            if (bookModel.getID() == query)
                            {
                                tempBook = bookModel;
                            }
                        }

                        if (tempBook != null)
                        {
                            bookList.Remove(tempBook);
                            Console.WriteLine("Book removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Book not found!");
                        }

                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    case 5:
                    {
                        Console.Clear();



                        if (bookList.Count > 0)
                        {
                            BookModel expBook = bookList[0];

                            foreach (var bookModel in bookList)
                            {
                                if (bookModel.getPrice() >= expBook.getPrice())
                                {
                                    expBook = bookModel;
                                }
                            }

                            Console.WriteLine("=======================");
                            Console.WriteLine(expBook.ToString());
                            Console.WriteLine("=======================");
                        }
                        else
                        {
                            Console.WriteLine("List is empty!");
                        }

                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                    case 6:
                    {
                        Console.Clear();



                        if (bookList.Count > 0)
                        {
                            
                            BookModel expBook = bookList[0];
                            foreach (var bookModel in bookList)
                            {
                                if (bookModel.getPrice() <= expBook.getPrice())
                                {
                                    expBook = bookModel;
                                }
                            }

                            Console.WriteLine("=======================");
                            Console.WriteLine(expBook.ToString());
                            Console.WriteLine("=======================");
                        }
                        else
                        {
                            Console.WriteLine("List is empty!");
                        }

                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    case 7:
                    {
                        Console.Clear();
                        Console.WriteLine("There is " + bookList.Count + " Books in the list.");
                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    case 8:
                    {
                        Console.Clear();
                        var tempList = bookList;
                        tempList.Sort((model, bookModel) => bookModel.getPrice() - model.getPrice());
                        foreach (var bookModel in tempList)
                        {
                            Console.WriteLine("=======================");
                            Console.WriteLine(bookModel.ToString());
                            Console.WriteLine("=======================");
                        }

                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    case 9:
                    {
                        Console.Clear();
                        var tempList = new List<BookModel>();

                        Console.Write("start price at : ");
                        int queryFrom = int.Parse(Console.ReadLine());
                        Console.Write("end price at : ");
                        int queryTo = int.Parse(Console.ReadLine());

                        foreach (var bookModel in bookList)
                        {
                            if (bookModel.getPrice() >= queryFrom & bookModel.getPrice() <= queryTo)
                            {
                                tempList.Add(bookModel);
                            }
                        }


                        if (tempList.Count > 0)git remote add origin https://github.com/Shayanxe/finalproject_shayan.git
                        {
                            foreach (var bookModel in tempList)
                            {
                                Console.WriteLine("=======================");
                                Console.WriteLine(bookModel.ToString());
                                Console.WriteLine("=======================");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nothing found!");
                        }

                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    case 0:
                    {
                        isMenuActive = false;
                        break;
                    }
                    default:
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }
    
    public class BookModel
    {
        private long id;
        private string title;
        private string writter;
        private int price;

        public BookModel()
        {
        }

        public BookModel(long id, string title, string writter, int price)
        {
            this.id = id;
            this.title = title;
            this.writter = writter;
            this.price = price;
        }

        public long getID()
        {
            return id;
        }

        public string getTitle()
        {
            return title;
        }

        public string getWritter()
        {
            return writter;
        }

        public int getPrice()
        {
            return price;
        }

        public void setID(long id)
        {
            this.id = id;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setWritter(string writter)
        {
            this.writter = writter;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public override string ToString()
        {
            return "Book :" + "\n" + "-ID : " + id + "\n" + "-Title : " + title + "\n" + "-Writter : " + writter + "\n" + "-Price : " + price;
        }
    }
}