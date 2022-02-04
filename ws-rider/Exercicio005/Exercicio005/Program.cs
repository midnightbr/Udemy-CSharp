using System;
using Exercicio005.Entities;

namespace Exercicio005 {
    class Program {
        static void Main(string[] args) {
            
            Comment comment1 = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("Wow that's awesome!");
            Post post1 = new Post(
                DateTime.Parse("21/06/2021 15:30:25"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );
            
            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the Force be with you");
            Post post2 = new Post(
                DateTime.Parse("28/01/2022 20:19:14"), 
                "Good night guys",
                "See you tomorrow",
                5
                );
            
            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}
