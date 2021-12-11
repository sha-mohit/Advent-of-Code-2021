using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_11
    {
        int[][] matrices = new int[10][];
        int RowCount = 0;
        int ColCount = 0;
        int totalFlashes = 0;
        int allFlashedStep = 0;
        List<string> flashCord = new List<string>();
        public string FirstSolution(List<string> readings)
        {
            RowCount = readings.Count;
            if (readings.Count>0)
            {
                ColCount = readings[0].Count();
            }
           for (int i = 0; i < RowCount; i++)
            {
                matrices[i] =  new int[ColCount];
                string r = readings[i];
              
                for (int j = 0;j < r.Count(); j++)
                {
                    matrices[i][j] = int.Parse(r[j].ToString());
                }
            }
            totalFlashes = 0;
            int step = 1;
            int firstAns = 0;
            while (allFlashedStep == 0)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    for (int k = 0; k < ColCount; k++)
                    {
                        Increment(j, k);
                    }
                }
                //puzzel 1
                if (step ==100)
                {
                    firstAns = totalFlashes;
                }
                //puzzel 2
                if (flashCord.Count == 100)
                {
                    if (allFlashedStep == 0)
                    {
                        allFlashedStep = step;
                    }

                }
                step++;
                flashCord.Clear();

            }
           return firstAns.ToString();
        }
        public void Increment(int i, int j)
        {
            if (matrices[i][j] == 9)
            {
                matrices[i][j] = 0;
                totalFlashes++;
                flashCord.Add(i + "," + j);
                flash(i, j);
            }
            else
            {
                if (!flashCord.Contains(i + "," + j))
                {
                    matrices[i][j] = matrices[i][j] + 1;
                }
            }
        }
        public void flash(int i, int j)
        {
            int locUp = i - 1 < 0 ? 999 : i - 1;
            int locDown = i + 1 > (RowCount - 1) ? 999 : i + 1;
            int locBack = j - 1 < 0 ? 999 : j - 1;
            int locFor = j + 1 > (ColCount - 1) ? 999 : j + 1;

            if (locUp != 999)
            {
                Increment(locUp, j);
            }
            if (locUp != 999 && locBack != 999)
            {
                Increment(locUp, locBack);
            }
            if (locUp != 999 && locFor != 999)
            {
                Increment(locUp, locFor);
            }
            if (locDown != 999)
            {
                Increment(locDown, j);
            }
            if (locDown != 999 && locBack != 999)
            {
                Increment(locDown, locBack);
            }
            if (locBack != 999)
            {
                Increment(i, locBack);
            }
            if (locDown != 999 && locFor != 999)
            {
                Increment(locDown, locFor);
            }
            if (locFor != 999)
            {
                Increment(i, locFor);
            }
        }

        public string SecondSolution(List<string> readings)
        {
           
            return allFlashedStep.ToString();
        }
       
    }
   
}
