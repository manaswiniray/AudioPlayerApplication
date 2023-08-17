using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerApplication
{
    internal class NotificationPanel
    {
        public static void notificationClassification(NotificationType notification)
        {
            switch(notification)
            {
                case NotificationType.SMS:
                    Console.WriteLine("Sending via SMS"); Console.WriteLine();
                    break;
                case NotificationType.EMail: 
                    Console.WriteLine("Sending via EMail"); Console.WriteLine();
                    break;
                case NotificationType.WhatsApp:
                    Console.WriteLine("Sending via WhatsApp"); Console.WriteLine();
                    break;
                case NotificationType.Telegram:
                    Console.WriteLine("Sending via Telegram"); Console.WriteLine();
                    break;
            }
        } 
    }
}
