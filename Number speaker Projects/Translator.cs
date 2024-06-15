using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_speaker_Projects
{
    public class Translator
    {
        public static List<string> Translate(int x)
        {
            if(x < 0)
                return new List<string>();

            if(x < 20)
            {
                List<string> newluis = new List<string>();
                newluis.Add(x.ToString());
                return newluis;
            }

            return Translate(SecuqentalNumber(x));
        }
        public static List<string> Translate(int[] s)
        {
            int n = s.Length;

            if (n == 0)
                return new List<string>();
            
            List<string> soundlist = new List<string>();


            bool Parity = false;

            for (int i = n-1; i>=0;i--)
            {
                int num = s[i];

                if (num == 0)
                    continue;
                else
                {
                    int powered = num * PlaceWorth(n, i);

                    if (i+1 == n || !Parity)
                    {
                        soundlist.Add(powered.ToString());
                        Parity = true;
                    }
                    else
                        soundlist.Add($"{powered}&");
                }
            }

            soundlist.Reverse();

            if (soundlist.Exists(x => x == "10&"))
            {
                soundlist.RemoveAt(soundlist.Count - 1);
                soundlist.RemoveAt(soundlist.Count - 1);
                soundlist.Add((s[n - 2]).ToString() + s[n - 1].ToString());
            }

            return soundlist;
        }

        static int PlaceWorth(int lenght,int index)
        {
            return (int)Math.Pow(10, (lenght - 1) - index);
        }

        static int[] SecuqentalNumber(int x)
        {
            string str = x.ToString();
            int[] sec = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
                sec[i] = int.Parse(str[i].ToString());

            return sec;
        }
    }
}
