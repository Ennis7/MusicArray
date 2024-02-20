using System;
namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Pop,
            Country,
            Classical,
            Jazz,
            RnB
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private double Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, double length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            //public void setValues(string title, string artist, string album, double length, Genre genre)
            //{
            //    Title = title;
            //    Artist = artist;
            //    Album = album;
            //    Length = length;
            //    Genre = genre;
            //}
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(double length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] songs = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the title of your favorite song?");
                    songs[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is the artist?");
                    songs[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the name of the album?");
                    songs[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the length of the song?");
                    songs[i].setLength(double.Parse(Console.ReadLine()));
                    Console.WriteLine("What is the genre?");
                    Console.WriteLine(" P - Pop\n C - Country\n L - Classical\n J - Jazz\n R - RnB");
                    Genre temptGenre = Genre.Pop;


                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'P':
                            temptGenre = Genre.Pop;
                            break;
                        case 'C':
                            temptGenre = Genre.Country;
                            break;
                        case 'L':
                            temptGenre = Genre.Classical;
                            break;
                        case 'J':
                            temptGenre = Genre.Jazz;
                            break;
                        case 'R':
                            temptGenre = Genre.RnB;
                            break;
                    }
                    songs[i].setGenre(temptGenre);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{songs[i].Display()}");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
            //Music music = new(temptTitle, temptArtist, temptAlbum, temptLength, temptGenre);
            //Console.WriteLine($"{music.Display()}");
            //Console.ReadKey();
            //Console.WriteLine();

            //Music musicTwo = new Music(temptTitle, temptArtist, temptAlbum, temptLength, temptGenre);

            //Music moreMusic = music;

            //moreMusic.setTitle("Delicate");
            //moreMusic.setLength(3.28);

            //Console.WriteLine("Here's the second song!");
            //Console.WriteLine($"{moreMusic.Display()}");
            //Console.WriteLine();

            //Console.WriteLine("Here's the first song!");
            //Console.WriteLine($"{music.Display()}");
            //    //Console.ReadKey();
        }

    }
}