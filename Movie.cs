using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    public abstract partial class Movie
    { 
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTimeInMinutes { get; set; }
        public List<string> Scenes { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Category: {this.Category}");
            Console.WriteLine($"RunTime: {this.RunTimeInMinutes}");
        }

        public void PrintScenes()
        {
            var index = 0;
            foreach (var scene in Scenes)
            {
                Console.WriteLine($"{index}: {scene}:");
                index += 1;
            }


        }
        public abstract void Play();
    }

}
