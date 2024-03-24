using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random rnd = new Random();
        id = rnd.Next(10000, 99999);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        // Precondition: Judul video memiliki panjang maksimal 100 karakter dan tidak null
        if (title == null || title.Length > 100)
        {
            throw new ArgumentException("Judul video harus memiliki panjang maksimal 100 karakter dan tidak null.");
        }

        // Precondition: Input penambahan play count maksimal 10.000.000 per panggilan method-nya
        if (count < 0 || count > 10000000)
        {
            throw new ArgumentOutOfRangeException("Jumlah penambahan play count harus antara 0 dan 10.000.000.");
        }

        try
        {
            // Exception Handling: Pastikan jumlah penambahan play count tidak melebihi batas tertinggi integer (overflow)
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Overflow terjadi saat menambahkan play count.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        // Membuat objek SayaTubeVideo dengan judul video
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Kal El Pratama");

        // Memanggil method IncreasePlayCount untuk menguji prekondisi dan exception
        for (int i = 0; i < 5; i++)
        {
            video.IncreasePlayCount(2000000); // Menaikkan play count sebanyak 2.000.000 per panggilan
        }

        // Memanggil method PrintVideoDetails untuk mencetak detail video
        video.PrintVideoDetails();
    }
}
