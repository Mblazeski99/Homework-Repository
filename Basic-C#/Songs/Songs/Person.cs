using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class Person
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public Genre FavoriteMusicType { get; private set; }
        public List<Song> FavoriteSongs { get; private set; }

        public Person(int id, string firstName, string lastName, int age, Genre favoriteMusicType, List<Song> favoriteSongs)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs;
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine($"{FirstName} hates music");
            } else
            {
                Console.WriteLine($"{FirstName}s Favorite songs are:");
                foreach(Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
            
        }
    }
}
