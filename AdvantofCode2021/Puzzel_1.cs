using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_1
    {
        public string FirstSolution(List<string> readings)
        {
            int count = 0;
            for (int i = 1; i < readings.Count; i++)
            {
                if (int.Parse(readings[i]) > int.Parse(readings[i - 1]))
                {
                    count++;
                }
            }
           return count.ToString();
        }

        public string SecondSolution(List<string> readings)
        {
            int count = 0;
            for (int i = 1; i < readings.Count - 2; i++)
            {
                if ((int.Parse(readings[i]) + int.Parse(readings[i + 1]) + int.Parse(readings[i + 2])) > (int.Parse(readings[i - 1]) + int.Parse(readings[i]) + int.Parse(readings[i + 1])))
                {
                    count++;
                }
            }
            return count.ToString();
        }
    }
}
