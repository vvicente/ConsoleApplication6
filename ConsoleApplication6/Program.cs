using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Before using");
            using (var context = new MusicContext())
            {
                 var count = context.Albums.Count();
                Console.WriteLine(count);
                context.Albums.Add(new Album() { Price = 9.99m, Title = "Encore" });
                context.SaveChanges();
                count = context.Albums.Count();
                Console.WriteLine(count);
                var albums = context.Albums.Where(p => p.Title.Contains("Smells")).ToList();
                Console.WriteLine(albums.Count );

                Console.ReadLine();
            }
        }
    }

    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Album()
        {
            this.AlbumId = 111;
            this.Title = "Default Album Title";
            this.Price = 4;
        }
    }
    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}
