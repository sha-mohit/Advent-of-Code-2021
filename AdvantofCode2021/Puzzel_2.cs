using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_2
    {
        public string FirstSolution(List<string> readings)
        {
            int forward = 0;
            int down = 0;
            int up = 0;
            for (int i = 0; i < readings.Count; i++)
            {
                string[] words = readings[i].Split(' ');
                if (words[0].Contains("forward"))
                {
                    forward = forward + int.Parse(words[1]);
                }
                if (words[0].Contains("down"))
                {
                    down = down + int.Parse(words[1]);
                }
                if (words[0].Contains("up"))
                {
                    up = up + int.Parse(words[1]);
                }
            }
            return (forward * (down - up)).ToString();
        }

        public string SecondSolution(List<string> readings)
        {
            int forward = 0;
            int down = 0;
            int up = 0;
            int aim = 0;
            int depth = 0;
            for (int i = 0; i < readings.Count; i++)
            {
                string[] words = readings[i].Split(' ');
                if (words[0].Contains("forward"))
                {
                    forward = forward + int.Parse(words[1]);
                    depth = depth + (aim * int.Parse(words[1]));
                }
                if (words[0].Contains("down"))
                {
                    down = down + int.Parse(words[1]);
                    aim = aim + int.Parse(words[1]);
                }
                if (words[0].Contains("up"))
                {
                    up = up + int.Parse(words[1]);
                    aim = aim - int.Parse(words[1]);
                }
            }

            return (forward * (depth)).ToString();
        }
    }
}
