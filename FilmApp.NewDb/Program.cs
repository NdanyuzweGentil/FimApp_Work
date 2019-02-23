using System;

namespace FilmApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new FilmContext())
            {
                Console.WriteLine("Can you plz Enter Film Title:");

               string title = Console.ReadLine();
                Console.WriteLine("Can you plz Enter Film year:");
               string year = Console.ReadLine();
                Console.WriteLine("Can you plz Enter Film category_name:");
               string category = Console.ReadLine();
                db.Films.Add(new Filmtbl { title = title });
                db.Films.Add(new Filmtbl { year = year });
                db.Films.Add(new Filmtbl { category_name = category});
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All Films in database:");
                foreach (var Filmtbl in db.Films)
                {
                    Console.WriteLine(" $ {0}{1}{2}",Filmtbl.title, Filmtbl.year,Filmtbl.category_name);
                }
            }
        }
    }
}