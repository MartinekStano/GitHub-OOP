using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            

            Console.Write("Zadaj nazov knihy: ");
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
            
            

            
        }
       
    }
    class Book
    {
        private string Title { get; set; }
        private int Pages { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }

        public Book(string title, int pages, string categoty, string author, int releasedate)
        {
            Title = title;
            Pages = pages;
            Category = categoty;
            Author = author;
            ReleaseDate = releasedate;
        }


        
        public void DiscribeBook()
        {
            Console.WriteLine($"{Title} {Pages} {Category} {Author} {ReleaseDate}");
           
        }
    }
}
