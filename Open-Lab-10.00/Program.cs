using System;
using System.Collections.Generic;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Zadaj nazov knihy: ");
             string title = Console.ReadLine();

             Console.Write("Zadaj pocet stran: ");
             int pages =int.Parse(Console.ReadLine());

             if(pages < 0)
             {
                 pages = 1;
             }

             Console.Write("Zadaj zaner: ");
             string category = Console.ReadLine();

             Console.Write("Zadaj meno autora: ");
             string author = Console.ReadLine();

             Console.Write("Zadaj datum vydania (rok): ");
             int releaseDate = int.Parse(Console.ReadLine());

             if (releaseDate <= 1450 || releaseDate >= 2021)
             {
                 releaseDate = -1;
             }

             Book LOTR = new Book(title, pages, category, author, releaseDate);

             Console.WriteLine($"{LOTR.Category}\n{LOTR.Author}\n{LOTR.ReleaseDate}");
            */

            /* Book LOTR2 = new Book();
             Console.WriteLine(LOTR2.ToString());

             Console.Write("Meno knihy: ");
             string title2 = Console.ReadLine();
             Console.Write("Pocet stran: ");
             int pages2 = int.Parse(Console.ReadLine());

             Book LOTR3 = new Book(title2, pages2);
             Console.WriteLine(LOTR3.ToString());
            */

            List<string> gerne = new List<string>();
            
            gerne.Add("detské");
            gerne.Add("romantické");
            gerne.Add("náučné");
            gerne.Add("sci-fi");
            gerne.Add("dobrodružné");

            Book.CategoryList = gerne;

            string category = Book.ChooseAGenre();

            Book HOBIT = new Book("Hobit", 232,category, "J.R.R. Tolkien", 2012);
            HOBIT.DiscribeBook();
        }






            
            
        

    }
    class Book
    {
        private string Title { get; set; }
        private int Pages { get; set; }
        public string Category { private get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }
        public static List<string> CategoryList { get; set; }

        public Book(string title, int pages, string categoty, string author, int releasedate)
        {
            Title = title;
            Pages = pages;
            Category = categoty;
            Author = author;
            ReleaseDate = releasedate;
            CategoryList = new List<string>();
        }
        
        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;

        }
        public override string ToString()
        {
            return $"{Title}\n{Pages}\n{Category}\n{Author}\n{ReleaseDate}";
        }
        public void DiscribeBook()
        {
            Console.WriteLine($"{Title} {Pages} {Category} {Author} {ReleaseDate}");
        }
        
        
        public static string ChooseAGenre()
        {
            int i = 1;
            foreach (string genre in Book.CategoryList)
            {
                
                Console.WriteLine("{0} {1}", i, genre);
                i += 1;
            }
            Console.WriteLine("Tvoj vyber: ");
            string category = Book.CategoryList[int.Parse(Console.ReadLine())-1];
            return category;
        }
        

           
        






        
        
        



    }
}
