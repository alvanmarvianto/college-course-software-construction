using System;

class Program
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // melempar error jika title kosong
            if (title == null)
                throw new ArgumentNullException(nameof(title), "Judul video tidak boleh null.");
            // melempar error jika title terlalu panjang
            if (title.Length > 100)
                throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.", nameof(title));

            var rand = new Random();
            this.id = rand.Next(9999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int jmlh)
        {
            // melempar error jika view terlalu banyak
            if (jmlh < 0 || jmlh > 10000000)
                throw new ArgumentOutOfRangeException(nameof(jmlh),
                    "Input penambahan play count harus antara 0 hingga 10,000,000.");
            
            // try catch jika overflow
            try
            {
                checked
                {
                    playCount += jmlh;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play count: " + playCount);
        }
    }

    static void Main(string[] args)
    {
        // try catch jika class null
        try
        {
            SayaTubeVideo vid1 = new SayaTubeVideo(null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // try catch jika karakter terlalu panjang
        try
        {
            SayaTubeVideo vid2 = new SayaTubeVideo("mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // try catch jika view count terlalu banya
        try
        {
            SayaTubeVideo vid4 = new SayaTubeVideo("Tutorial Design By Contract – Alvan Marvianto");
            vid4.IncreasePlayCount(100000000);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // jika tidak ada error
        SayaTubeVideo vid3 = new SayaTubeVideo("Tutorial Design By Contract – Alvan Marvianto");

        for (int i = 0; i < 10000000; i++)
        {
            vid3.IncreasePlayCount(100);
        }

        vid3.PrintVideoDetails();
    }
}
