using System;

namespace _15._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Book[] obj = new Book[3];
            obj[0] = new Book("Крассная шапочка", 12);
            obj[1] = new Book("Зайчик", 3);
            obj[2] = new Book("Золушка", 6);
            foreach (Book n in obj)
            {
                n.Print();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Массив упорядоченный по количеству страниц в книге");
            Console.WriteLine("\n");
            Array.Sort(obj, new Book.SortByCountPage());
            foreach (Book n in obj)
            {
                n.Print();
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Массив упорядоченный по названию книиг");
            Console.WriteLine("\n");
            Array.Sort(obj, new Book.SortByNameBook());
            foreach (Book m in obj)
            {
                m.Print();
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Копирование");
            Console.WriteLine("\n");
            Book obj1 = new Book();
            obj1.Name_Book = "Иванушка";
            obj1.Count_P = 4;
            obj1.Print();
            Book objCopy = obj1.Clone() as Book;
            objCopy.Name_Book = "Гуси лебеди";
            objCopy.Count_P = 13;
            objCopy.Print();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Book[] books = new Book[3];
            books[0] = new Book("Варона", 5);
            books[1] = new Book("Трансформеры",187);
            foreach(Book a in books)
            {
                a.Print();
                Library l = new Library(books);

            }
        }
    }
}
