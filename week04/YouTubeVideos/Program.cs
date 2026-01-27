using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video catVideo = new Video("Funny Cat Sneezing", "Sam Smith", 105);
        catVideo.AddComment(new Comment("CatLady739", "🤣🤣 so funny!"));
        catVideo.AddComment(new Comment("Melody Jones", "I liked it but i wish it was longer."));
        catVideo.AddComment(new Comment("Tammy Jacobo", "That is exactly how my cat acts too!"));
        catVideo.AddComment(new Comment("TeamCatUSA", "Cats are the best!"));

        Video puppyVideo = new Video("Happy Puppy Loves Cheese", "Tiffany Chavez", 35);
        puppyVideo.AddComment(new Comment("Dogs-Rule84", "Gotta pay that cheese tax."));
        puppyVideo.AddComment(new Comment("Jason Thomas", "Look at that tail go! so cute."));
        puppyVideo.AddComment(new Comment("Harry Seymore", "Mans best friend indeed."));

        Video birdVideo = new Video("Everybody Loves Ray-bird", "Tony Giovana", 145);
        birdVideo.AddComment(new Comment("Ornithologist-Club1", "How did they get that little hat onto that bird?"));
        birdVideo.AddComment(new Comment("Diana Johnston", "Hillarious! 🤣"));
        birdVideo.AddComment(new Comment("Tyler Rex", "Love the play on words."));

        videos.Add(catVideo);
        videos.Add(puppyVideo);
        videos.Add(birdVideo);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetTitle());
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }


    }
}