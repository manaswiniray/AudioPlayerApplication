using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerApplication
{
    internal class OperatingAudioPlayer
    {
        public static void operateAudioPlayer(IAudioPlayer audioPlayer)
        {

            while (true)
            {
                Console.WriteLine("Menu 2:"); Console.WriteLine();
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Select Notification Platform: ");
                Console.WriteLine("4. Return to Menu 1");
                Console.WriteLine("Select Option:"); Console.WriteLine();

                int choice2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice2)
                {
                    case 1:
                        audioPlayer.Play();
                        audioPlayer.DisplayMessage("Audio is Played");
                        break;
                    case 2:
                        audioPlayer.Stop();
                        audioPlayer.DisplayMessage("Audio is Stopped");
                        break;
                     case 3:
                        int notificationType = NotificationMenu.chooseNotificationType();
                        NotificationPanel.notificationClassification((NotificationType)notificationType);
                        break;
                    case 4:
                        audioPlayer.DisplayMessage("Returning to Menu1 ......");
                        Thread.Sleep(400);
                        return;
                    default:
                        audioPlayer.DisplayMessage("Invalid Choice");
                        break;
                }
            }
        }
    }
}
