using System;

namespace Blockbuster_Lab
{
    public class DVD : Movie
    {
        //TODO- finish this method
        public override void Play()
        {
            do
            {
                Console.WriteLine($"What scene would you like to watch? Select 0 to 2:");
                PrintScenes();
                bool isInt = int.TryParse(Console.ReadLine(), out int sceneIndex);
                if (isInt && sceneIndex >= 0 && sceneIndex < Scenes.Count)
                {
                    Console.WriteLine($"{Scenes[sceneIndex]}");
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid input. Please try again.");
                }

            } while (true);

        }
    }

}
