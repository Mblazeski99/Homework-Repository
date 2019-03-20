using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            Song[] allSongs = new Song[]
            {
                new Song("Classical1", 2.5, Genre.Classical),
                new Song("Classical2", 5.4, Genre.Classical),
                new Song("Classical3", 3.7, Genre.Classical),
                new Song("Classical4", 7.3, Genre.Classical),
                new Song("Techno1", 6.3, Genre.Techno),
                new Song("Techno2", 3.3, Genre.Techno),
                new Song("Techno3", 4.7, Genre.Techno),
                new Song("Techno4", 5.1, Genre.Techno),
                new Song("HipHop1", 7.0, Genre.Hip_Hop),
                new Song("HipHop2", 4.1, Genre.Hip_Hop),
                new Song("HipHop3", 3.2, Genre.Hip_Hop),
                new Song("HipHop4", 2.9, Genre.Hip_Hop),
                new Song("Rock1", 6.9, Genre.Rock),
                new Song("Rock2", 5.3, Genre.Rock),
                new Song("Rock3", 2.9, Genre.Rock),
                new Song("Rock4", 4.4, Genre.Rock),
                new Song("Bsong1", 5.4, Genre.Rock),
                new Song("Bsong2", 3.2, Genre.Hip_Hop),
                new Song("Bsong3", 6.2, Genre.Classical),
                new Song("Bsong4", 7.2, Genre.Techno),
            };

            List<Song> jerrysFavorites = new List<Song>();
           foreach(Song song in allSongs)
            {
                if(song.Title[0] =='B')
                {
                    jerrysFavorites.Add(song);
                }
            }

            List<Song> mariasFavorites = new List<Song>();
            foreach (Song song in allSongs)
            {
                if (song.Length > 6.0)
                {
                    mariasFavorites.Add(song);
                }
            }

            List<Song> janesFavorites = new List<Song>();
            foreach (Song song in allSongs)
            {
                if (song.Genre == Genre.Rock)
                {
                    janesFavorites.Add(song);
                }
            }

            List<Song> stefansFavorites = new List<Song>();
            foreach (Song song in allSongs)
            {
                if (song.Genre == Genre.Hip_Hop && song.Length < 3.0)
                {
                    stefansFavorites.Add(song);
                }
            }

            Person[] personArr = new Person[]
            {
                new Person(01,"Jerry","Reed",45,Genre.Rock,jerrysFavorites),
                new Person(02,"Maria","Wallace", 37,Genre.Classical,mariasFavorites),
                new Person(03,"Jane","Johnson", 23,Genre.Rock,janesFavorites),
                new Person(04,"Stefan","Stefanson",27,Genre.Hip_Hop,stefansFavorites)
            };

            foreach(Person person in personArr)
            {
                person.GetFavSongs();
            }

            Console.WriteLine("The persons with 4 or more songs are:");

            foreach(Person person in personArr)
            {
                if(person.FavoriteSongs.Count >= 4)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}");
                }
            }






            Console.ReadKey();
        }
    }
}
