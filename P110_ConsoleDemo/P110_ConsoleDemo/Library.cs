using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110_ConsoleDemo
{
    public class Library
    {
        private int bookIndex = 0;
        private int encIndex = 0;
        private int jrIndex = 0;

        private readonly Book[] books; 
        //private readonly Encyclopedia[] encyclopedias; 
        //private readonly Journal[] journals;

        //indexer
        public Book this[int i]
        {
            get {
                return books[i];
            }
            set {
                books[i] = value;
            }
        }

        public Library()
        {
            books = new Book[100];
            //encyclopedias = new Encyclopedia[100];
            //journals = new Journal[100];
        }

        public void AddBook(Book book)
        {
            bool exists = ISBNExists(books, book);

            if (exists) throw new ArgumentException("Book ISBN is duplicate.");

            books[bookIndex++] = book;
        }

        //public void AddJournal(Journal journal)
        //{
        //    bool exists = ISBNExists(journals, journal);

        //    if (exists) throw new ArgumentException("Journal ISBN is duplicate.");

        //    journals[jrIndex++] = journal;
        //}

        //public void AddEncyclopedia(Encyclopedia encyclopedia)
        //{
        //    bool exists = ISBNExists(encyclopedias, encyclopedia);

        //    if (exists) throw new ArgumentException("Encyclopedia ISBN is duplicate.");

        //    encyclopedias[encIndex++] = encyclopedia;
        //}

        public bool ISBNExists(ReadableItem[] readableItems, ReadableItem item)
        {
            foreach (var it in readableItems)
            {
                if (it != null && it.ISBN == item.ISBN) return true;
            }

            return false;
        }

        public void GetList()
        {
            Console.WriteLine("Books:");
            foreach (var item in books)
            {
                if(item != null)
                    Console.WriteLine(item);
            }
            Console.WriteLine("\n------------------------\n");

            //Console.WriteLine("Encyclopedias:");
            //foreach (var item in encyclopedias)
            //{
            //    if(item != null)
            //        Console.WriteLine(item);
            //}
            //Console.WriteLine("\n------------------------\n");

            //Console.WriteLine("Journals:");
            //foreach (var item in journals)
            //{
            //    if(item != null)
            //        Console.WriteLine(item);
            //}
            //Console.WriteLine("\n------------------------\n");
        }
    }
}
