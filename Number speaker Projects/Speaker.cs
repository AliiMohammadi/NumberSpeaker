using NAudio.Wave;
using OneeChanRemake.Operation_System;
using System;
using System.Media;


namespace Number_speaker_Projects
{
    internal class Speaker
    {
        static readonly string Soundpath = Environment.CurrentDirectory+ @"\Sounds";
        static readonly string soundsExtention = ".wav";

        public static void Speak(string numbercode)
        {
            AudioPlayer.Play(Soundpath + @"\" + numbercode + soundsExtention);
        }
        public static int WavFileDuratio(string numbercode)
        {
           return GetWavFileDuration(Soundpath + @"\" + numbercode + soundsExtention).Milliseconds;
        }

        static TimeSpan GetWavFileDuration(string fileName)
        {
            WaveFileReader wf = new WaveFileReader(fileName);
            return wf.TotalTime;
        }
    }
}
