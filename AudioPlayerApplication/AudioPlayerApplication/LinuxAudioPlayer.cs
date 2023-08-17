using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerApplication
{
    internal class LinuxAudioPlayer : IAudioPlayer
    {
        public void Play()
        {
            Console.WriteLine("In Linux,  Play Button is clicked");
            Console.WriteLine();
        }

        public void Stop()
        {
            Console.WriteLine("In Linux,  Stop Button is clicked!!!");
            Console.WriteLine();
        }

        public void Notify(NotificationType notification)
        {
            NotificationPanel.notificationClassification(notification);
        }

        public void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine();
        }
    }
}
