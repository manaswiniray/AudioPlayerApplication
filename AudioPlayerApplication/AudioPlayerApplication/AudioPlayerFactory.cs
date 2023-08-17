using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerApplication
{
    internal class AudioPlayerFactory
    {
        public static IAudioPlayer CreateAudioPlayer(int type)
        {
            IAudioPlayer audioPlayer = type switch
            {
                1 => new WindowsAudioPlayer(),
                2 => new LinuxAudioPlayer(),
                _ => default,
            };

            return audioPlayer;
        }
    }
}
