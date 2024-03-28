internal class Program
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string Username;

        public SayaTubeUser(string title)
        {
            Random rnd = new Random();
            this.id = rnd.Next(10000, 100000);
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.Username = Username;
        }

        public int GetTotalVideoPlayCount()
        {
            return uploadedVideos.Count;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + this.Username);
            for (int i = 0; i < this.uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + i + "judul: " + this.uploadedVideos);
            }
        }
    }

    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int PlayCount;

        public SayaTubeVideo(string title)
        {
            Random rnd = new Random();
            this.id = rnd.Next(10000, 100000);
            this.title = title;
            this.PlayCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.PlayCount++;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Details:");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.PlayCount);
        }
    }
    private static void Main(string[] args)
    {
        string reviewFilm1 = "Review Film Dilan oleh Rizky";
        string reviewFilm2 = "Review Film The Conjuring oleh Rizky";
        string reviewFilm3 = "Review Film Insidious oleh Rizky";
        string reviewFilm4 = "Review Film Dua Garis Biru oleh Rizky";
        string reviewFilm5 = "Review Film Dear Nathan oleh Rizky";
        string reviewFilm6 = "Review Film Titanic oleh Rizky";
        string reviewFilm7 = "Review Film Naruto oleh Rizky";
        string reviewFilm8 = "Review Film DragonBall oleh Rizky";
        string reviewFilm9 = "Review Film Godzila oleh Rizky";
        string reviewFilm10 = "Review Film Mariposa oleh Rizky";
        SayaTubeVideo myVideo1 = new SayaTubeVideo(reviewFilm1);
        SayaTubeVideo myVideo2 = new SayaTubeVideo(reviewFilm2);
        SayaTubeVideo myVideo3 = new SayaTubeVideo(reviewFilm3);
        SayaTubeVideo myVideo4 = new SayaTubeVideo(reviewFilm4);
        SayaTubeVideo myVideo5 = new SayaTubeVideo(reviewFilm5);
        SayaTubeVideo myVideo6 = new SayaTubeVideo(reviewFilm6);
        SayaTubeVideo myVideo7 = new SayaTubeVideo(reviewFilm7);
        SayaTubeVideo myVideo8 = new SayaTubeVideo(reviewFilm8);
        SayaTubeVideo myVideo9 = new SayaTubeVideo(reviewFilm9);
        SayaTubeVideo myVideo10 = new SayaTubeVideo(reviewFilm10);
        myVideo1.PrintVideoDetails();
        myVideo2.PrintVideoDetails();
        myVideo3.PrintVideoDetails();
        myVideo4.PrintVideoDetails();
        myVideo5.PrintVideoDetails();
        myVideo6.PrintVideoDetails();
        myVideo7.PrintVideoDetails();
        myVideo8.PrintVideoDetails();
        myVideo9.PrintVideoDetails();
        myVideo10.PrintVideoDetails();
    }
}