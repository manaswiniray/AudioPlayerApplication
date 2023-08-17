using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerApplication
{
    public interface IAudioPlayer
    {
        void Play();
        void Stop();
        void DisplayMessage(string msg);
        void Notify(NotificationType notification);

    }
}
