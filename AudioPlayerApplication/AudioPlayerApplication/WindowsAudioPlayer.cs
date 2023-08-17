using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerApplication
{
    public class WindowsAudioPlayer : IAudioPlayer
    {
        public void Play()
        {
            Console.WriteLine("In Windows, Play Button is clicked");
            Console.WriteLine();
        }

        public void Stop()
        {
            Console.WriteLine("In Windows, Stop Buttton is clicked!!!");
            Console.WriteLine();
        }

        public void Notify(NotificationType notification)
        {
            NotificationPanel.notificationClassification(notification);
        }

        public void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
