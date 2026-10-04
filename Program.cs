using System;
using System.Collections;
using System.Runtime.Remoting.Channels;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace oopsfunda
{
    public enum genre { fiction, non_fiction, horror, thriller, romance, fantasy };
    public enum personality { introvert, extrovert, ambivert };

    public class Address
    {
        public string addressLine, city, state;
            public Address(String addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
    public class book
    {

        private String booktitle;

        public String Booktitle
        {
            get { return booktitle; }
            set { booktitle = value; }
        }
        public float Prize
        {
            get; set;
        }
        public int Pages
        {
            get;set;
        }

        public genre type = genre.fantasy;

        
       

        public string genre_type;

        //not a string; address is a class. so we can create an object of address class and use it as a data member of book class.
        public Address publishers_address;

        public book() //default constructor
        {
            Console.WriteLine("this is a default constructor");
        }
        //public book(string s, float p, int pg) //parameterised constructor
        //{
        //    booktitle = s;
        //    prize = p;
        //    pages = pg;
        //}

       //this is a copy constructor.
       public book(book b)
        {
            this.booktitle = b.booktitle;
            this.Prize = b.Prize;
            this.Pages = b.Pages;
            this.type = b.type;
        }

        public book( string booktitle, float prize, int pages, /*string genre_type*/ genre type) //parameterised constructor
        {
            this.booktitle = booktitle;
            this.Prize = prize;
            this.Pages   = pages;
            this.type = type;
            
        }

        public book(string booktitle, Address address)
        {
            this.booktitle = booktitle;
            this.publishers_address = address;
        }
        ~book() //destructor
        {
            Console.WriteLine("this is a destructor");
        }
        public void showbook()
        {
            Console.WriteLine("book name: {0}", booktitle);
            Console.WriteLine("book prize: {0}", Prize);
            Console.WriteLine("book pages: {0}", Pages);
           // Console.WriteLine("book genre: {0}", genre_type);
            Console.WriteLine("book type: {0}", type);
        }


        public void insert(string s, float p, int pg)
        {
            booktitle = s;
            Prize = p;
            Pages = pg;
        }
    }

    
        internal class Program
        {
            //public string Show(string x)
            //{
            //    Console.WriteLine(" i am from planet mars");
            //    x = "hello" + x;

            //public void showparams(params int[] g)
            //{
            //    for (int i = 0; i < g.Length; i++)
            //    {
            //        Console.WriteLine(g[i]);
            //    }
            //}
            public void showparams(params Object[] g)
            {
                for (int i = 0; i < g.Length; i++)
                {
                    Console.WriteLine(g[i]);
                }
            }
            public void English(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                { Console.WriteLine(arr[i]); }
            }

            //    return x;
            //}

            //public void Printval( ref int f)
            //{
            //    f += f;
            //    Console.WriteLine(f);
            //}

            //public void Outpara(out int d)
            //{
            //    int h = 35;
            //    d = h;
            //    d *= d;
            //    Console.WriteLine(d);

            //}

            //public void TwoOutpara(out int d, out int f)
            //{
            //    d = 6; f = 7;
            //    int a = d;
            //    int b = f;

            //    d = a * a;
            //    f = b * b;
            //}


            static void Main(string[] args)
            {

            indexescreate obj = new indexescreate();
            obj[0] = "pooja";
            obj[1] = "mukund";
            obj[2] = "kavin";

            Console.WriteLine("the names are: {0} {1} {2}", obj[0], obj[1], obj[2]);

            //animal class-MULTILVL INHERITANCE

           Console.WriteLine("this is calling from dog class");
            dog d1 = new dog();
            d1.display();
            d1.eat();
            d1.bark();

            Console.WriteLine("this is calling from baby dog class");
            babyDog bd1 = new babyDog();
            bd1.display();
            bd1.eat();
            bd1.bark();
            bd1.weep();


            //method over-riding

            animal A1;
            A1 = new dog(); // dog is derived class of animal
            Console.WriteLine("testing overriding");
            A1.eat(); // eat is the function available in both. default it will call the base class function. but if we want to call the derived class function, we need to use virtual and override keywords in the base and derived class respectively.

            /* this is for array list*/
            //ArrayList books= new ArrayList();
            //books.Add("the housemaid ");
            //books.Add(453);
            //books.Add(500.50);
            //books.Add(true);
            //books.Add('T');
            ////for (int i = 0; i < books.Count; i++) { 
            ////    Console.WriteLine(books[i]);
            ////}
            //foreach (var i in books) { Console.WriteLine(i); }

            //    int d = 43;
            //    int f = 67;
            //    int w = 85;
            //int[] arr= { 1, 2, 3, 4 };
            //Program obj = new Program();
            //obj.English(arr);
            //    //string k = "pooja";

            //   Program obj = new Program(); //object creation

            //    Console.WriteLine("before: "+ f); 
            //    obj.Printval(ref f);
            //    Console.WriteLine("after: "+ f);
            //    //string h = obj.Show(k);
            //    //Console.WriteLine(h);


            //    Console.WriteLine("before: " + d);
            //    obj.Outpara(out d);
            //    Console.WriteLine("after: " + d);

            //    Console.WriteLine("before:{0} {1} ",w,f);

            //    obj.TwoOutpara(out w, out f);
            //    Console.WriteLine("after:{0} {1} ",w,f);


            //int[] arr = new int[5];
            //for(int i=0; i< arr.Length; i++)
            //{
            //    Console.Write("enter the element " + i +": ");
            //    int n= Convert.ToInt32(Console.ReadLine());

            //    arr[i]= n;
            //}
            //for (int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //foreach(int i in arr)
            //    {
            //        Console.WriteLine(i);
            //    }
            //Console.WriteLine("enter your word: ");

            //string word = Console.ReadLine();
            //string rword = "";
            //char[] og;
            //og = word.ToCharArray();
            //Array.Reverse(og);
            //rword = new string(og);
            //Console.WriteLine(rword);
            //Array.Sort(og);

            /*for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    rword += word[i].ToString();
            ////}*/
            //bool b = word.Equals(rword, StringComparison.OrdinalIgnoreCase);

            //if (b == true)
            //{
            //    Console.WriteLine("it is a palindrome");
            //}
            //else Console.WriteLine("it isn't a palindrome");

            //  int[] arr = { 65, 11, 22, 13, 46 };
            //int max = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{ if(arr[i] > max)
            //    {
            //        max=arr[i];
            //    }

            //}
            //Console.WriteLine("the largest number is: "+ max);

            /*jagged arrays */
            //int[][] arr = new int[2][] {
            //    new int[]{ 3,5,6 },
            //    new int[]{ 4, 5,6, 3,9 }
            //};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for(int j=0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j]);
            //    }
            //    Console.WriteLine();
            // }

            //Program obj = new Program();
            //obj.showparams('m', "mukund", 32, 67, 180.32);

            ////25.Write a C# Sharp program to copy the elements of one array into another array.

            //int[] arr1 = { 65, 11, 22, 13, 46 };
            //int[] arr2 = new int[5];
            //Console.WriteLine("the elements stored in the 1st array is: ");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write(arr1[i]+" ");
            //}
            //Array.Copy(arr1, arr2,arr2.Length);
            //Console.WriteLine();
            //Console.WriteLine("the elements that are copied are: ");
            //for (int i = 0;i < arr1.Length; i++)
            //{
            //    Console.Write(arr2[i]+ " ");
            //}


            book books = new book();
                book books_1 = new book();
                book books_2 = new book();
                book books_4 = new book();
                book books_5 = new book("midnight library", 150.00f, 250, /*Enum.GetName(typeof(genre),0)*/ genre.fantasy );
            book books_6 = new book("good girls guide to murder", 500.00f, 436, /*Enum.GetName(typeof(genre), 2)*/ genre.horror );
            book book_3 = new book(books_6);
            books_6.showbook();
            book_3.showbook();

            books_1.Pages = 200;
            books_1.Booktitle=" the ballad of never after";
            books_1.Prize = 180.00f;
            
            Console.WriteLine("my book details are: {0} {1} {2}", books_1.Booktitle, books_1.Prize, books_1.Pages);


            //derived class object

            derived_books db1 = new derived_books("c programming", 300.00f, 500, genre.horror, "Category 7", "penguin publication", "section a");
            Console.WriteLine("Using the derived object: ");
            db1.showbook();
            db1.display();

            Address pa1 = new Address("10A- rajalazmi avenue", "chennai", "tamil nadu");
            book b1_pa = new book("verity",pa1);
            Console.WriteLine("book publisher and address: {0} {1} {2}", b1_pa.Booktitle, b1_pa.publishers_address.addressLine, b1_pa.publishers_address.city);

            //books.booktitle = "the housemaid";
            //books.prize = 250.00f;
            //books.pages = 300;

            //Console.WriteLine("book name: {0}", books.booktitle);
            //Console.WriteLine("book prize: {0}", books.prize);
            //Console.WriteLine("book pages: {0}", books.pages);
            //books.insert("the housemaid", 250.00f, 300);
            //books_1.insert("the hunter", 120.00f, 345);
            //books_2.insert("the secret", 180.00f, 280);
            //books.showbook();
            //books_1.showbook();
            //books_2.showbook();
            account.ROI = 6.7f;
            account a3 = new account("kavin", 76543);


                books_5.showbook();

            account a1 = new account("John Doe", 12345);

            a1.display();


            account a2 = new account("Jane Smith", 67890); 
            
            a2.display();



            //////26.Write a program in C# Sharp to print all unique elements in an array.
            //int[] arr3 = new int[5];
            //Console.WriteLine("input 3 elements for the array: ");
            //for(int i=0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine("element " + i + ":");
            //   arr3[i]= Console.ReadLine();
            account a4 = new account("james", 67543);
            Console.WriteLine("no of objects for account class:{0}", account.count);
            Console.ReadKey();
        }
        }
    
}
