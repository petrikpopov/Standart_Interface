using System;
using System.Collections;

namespace _15._02._2023
{
    public class Book: ICloneable, IComparable
    {
        public string Name_Book { get; set; }
        public int Count_P { get; set; }

        public Book() { }
        public Book(string NB, int CP)
        {
            Name_Book = NB;
            Count_P = CP;
        }
        public void Print()
        {
            Console.WriteLine($"Name_Book:{Name_Book}\tCount_P:{Count_P}\n");
        }
        public int CompareTo(object obj)
        {
            if (obj is Book)
            {
                return Count_P.CompareTo((obj as Book).Count_P);
            }
            throw new NotImplementedException();
        }

        public class SortByCountPage : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if (x is Book && y is Book)
                {
                    return (x as Book).Count_P.CompareTo((y as Book).Count_P);
                }
                throw new NotImplementedException();
            }
        }
        public class SortByNameBook : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if (x is Book && y is Book)
                {
                    return (x as Book).Name_Book.CompareTo((y as Book).Name_Book);
                }
                throw new NotImplementedException();
            }
        }

        public object Clone()
        {
            return new Book(Name_Book, Count_P);
        }
    }

    public class Library : IEnumerable

    {
        Book[] mass = new Book[5];

        public Library(Book[] obj)
        {
            mass = new Book[obj.Length];
            for (int i = 0; i<obj.Length; i++)
            {
                mass[i] = new Book(obj[i].Name_Book,obj[i].Count_P);
            }
        }
        public void Print()
        {
            for (int i =0; i<mass.Length; i++)
            {
                mass[i].Print();
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i<mass.Length; i++)
            {
                yield return mass[i];
            }
            throw new NotImplementedException();
        }
    }
}  
