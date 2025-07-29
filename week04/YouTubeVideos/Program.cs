using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Console.WriteLine();
        Console.WriteLine("YOUTUBE VIDEO PROGRAM");

        // Videos
        Video video1 = new Video("Alex Warren", "Eternity", 204);
        video1.AddComment(new Comment("@julliette1095", "2:21 the soul leaves my body 🥹"));
        video1.AddComment(new Comment("@BLueJayxe7", "Felt like an eternity waiting for this to release ❤️😭"));
        video1.AddComment(new Comment("@Kamal-p9u7d", "This deserves way more views. Absolutely underrated."));
        videos.Add(video1);

        Video video2 = new Video("RemasterKingdom4K", "Newsies | Carrying The Banner + King Of New York | Newsies: The Broadway Musical |", 228);
        video2.AddComment(new Comment("@gcxlc", "this looks so good and clear."));
        video2.AddComment(new Comment("@brothersburst611", "Pls do Brooklyn’s here."));
        video2.AddComment(new Comment("@Kamal", "Absolutely perfect."));
        videos.Add(video2);

        Video video3 = new Video("Ed Sheeran", "Sapphire", 183);
        video3.AddComment(new Comment("@Thugesh", "This makes me happy for no reason! ❤️"));
        video3.AddComment(new Comment("@LondoGzz", "This song really brings back the old Ed Sheeran."));
        video3.AddComment(new Comment("@Monu_kumar100", "Ed dropped a literal gem!!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------"); // Separator
            Console.WriteLine("VIDEO");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine("COMMENTS:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenter()}: \"{comment.GetText()}\"");
            }
        }
        Console.WriteLine("----------------------------------"); // Separator
    }
}