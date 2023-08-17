using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerApplication
{
    internal class ChoosePlatformForAudioPlayer
    {
        public static void choosePlatform()
        {
            while (true)
            {
                Console.WriteLine("Menu 1:");
                Console.WriteLine();
                Console.WriteLine("1. Window:");
                Console.WriteLine("2. Linux");
                Console.WriteLine("3. Exit App");
                Console.WriteLine("Select Option:"); 
                Console.WriteLine();

                int choice1 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choice1 == 3) { break; }

                var audioPlayer = AudioPlayerFactory.CreateAudioPlayer(choice1);
                OperatingAudioPlayer.operateAudioPlayer(audioPlayer);
            }
        }
    }
}
