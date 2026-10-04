using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsfunda
{
    internal class derived_books:book
    {
        public string category;
        public string publisher;

        public string section;

        public derived_books(string book_title, float price, int pages, genre type, string Category, string Publisher, string Section) : base(book_title, price, pages, type) { 
         
            this.category = Category;
            this.publisher = Publisher;
            this.section = Section;

        }
       
        public void display()
        {
            //Console.WriteLine("Book Name: " + name);
            //Console.WriteLine("Book Price: " + price);
            //Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Publisher: " + publisher);
           // Console.WriteLine("Book Pages: " + pages);
            Console.WriteLine("Book Category: " + category);
            Console.WriteLine("Book Section: " + section);
        }
    }
}
