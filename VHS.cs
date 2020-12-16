using System;

namespace Blockbuster_Lab
{
    public class VHS : Movie
    {
        public int CurrentRunTime { get; set; }
        public override void Play()
        {
            Console.WriteLine($"{Scenes[CurrentRunTime]}");
            CurrentRunTime++;
        }
        public void Rewind()
        {
            CurrentRunTime = 0;
        }
    }

}
