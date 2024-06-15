using System.Media;
using System;
using System.IO;
using System.Linq;
using Number_speaker_Projects;

namespace OneeChanRemake.Operation_System
{
    public class AudioPlayer
    {
        static SoundPlayer splayer = new SoundPlayer();

        /// <summary>
        /// تابع مجاز برای پخش صدا
        /// </summary>
        /// <param name="stream">صدا که میتونه از سورس برنامه باشه</param>
        public static void Play(Stream stream)
        {
            splayer.Stream = stream;
            splayer.Play();
        }
        /// <summary>
        /// تابع مجاز برای پخش صدا
        /// </summary>
        /// <param name="stream">صدا که میتونه از سورس برنامه باشه</param>
        public static void Play(string audiopath)
        {
            splayer.SoundLocation = audiopath;
            splayer.Play();
        }
    }
}
