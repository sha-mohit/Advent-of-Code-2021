using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_13
    {
        int RowCount = 0;
        int ColCount = 0;
        public string FirstSolution(List<string> readings)
        {
            for (int i = 0; i < readings.Count; i++)
            {
                string[] cord = readings[i].Split(',');
                if (int.Parse(cord[0]) > ColCount)
                {
                    ColCount = int.Parse(cord[0]);
                   
                }
                if (int.Parse(cord[1]) > RowCount)
                {
                    RowCount = int.Parse(cord[1]);
                }
            }
            RowCount++;
            ColCount++;
            int[][] matrices = new int[RowCount][];
            for (int i = 0; i < RowCount; i++)
            {
                matrices[i] = new int[ColCount];
                for (int j = 0; j < ColCount; j++)
                {
                    matrices[i][j] = 0;
                }
            }
            for (int i = 0; i < readings.Count; i++)
            {
                string[] cord = readings[i].Split(',');
                matrices[int.Parse(cord[1])][int.Parse(cord[0])] = 1;
            }

            fold(matrices, 0, 655);
            fold(matrices, 447, 0);
            fold(matrices, 0, 327);
            fold(matrices, 223, 0);
            fold(matrices, 0, 163);
            fold(matrices, 111, 0);
            fold(matrices, 0, 81);
            fold(matrices, 55, 0);
            fold(matrices, 0, 40);
            fold(matrices, 27, 0);
            fold(matrices, 13, 0);
            fold(matrices, 6, 0);
            return dot.ToString();
        }
        int dot = 0;
        bool isFirstIteration = true;
        Dictionary<int, List<string>> CaptitalLetters = new Dictionary<int, List<string>>();
        public void fold(int[][] matrices, int x, int y)
        {
           
            //int rowCount = matrices.Count();
            //int colCount = matrices[0].Count();
            if (x != 0)
            {

                int newRCount = (RowCount - 1) / 2;
                for (int i = 0; i < ColCount; i++)
                {
                    matrices[x][i] = 0;
                }
                for (int i = 0; i < newRCount; i++)
                {
                    for (int j = 0; j < ColCount; j++)
                    {
                        matrices[i][j] = (matrices[i][j] + matrices[(RowCount - 1) - i][j]) > 0?1:0;
                        matrices[(RowCount - 1) - i][j] = 0;
                    }
                }
                RowCount = newRCount;
            }
            if (y != 0)
            {
                int newColCount = (ColCount - 1) / 2;
                for (int i = 0; i < RowCount; i++)
                {
                    matrices[i][y] = 0;
                }
                for (int j = 0; j < newColCount; j++)
                {
                    for (int i = 0; i < RowCount; i++)
                    {
                        matrices[i][j] = (matrices[i][j] + matrices[i][(ColCount - 1) - j]) > 0 ? 1 : 0;
                        matrices[i][(ColCount - 1) - j] = 0;
                    }
                }

                ColCount = newColCount;
            }
            List<string> letter = new List<string>();
            for (int i = 0; i < RowCount; i++)
            {
                string letterRow = "";
                for (int j = 0; j < ColCount; j++)
                {
                    if (matrices[i][j] > 0)
                    {
                        if (isFirstIteration)
                        {
                            dot++;
                        }
                        letterRow = letterRow + "#";
                    }
                    else
                    {
                        letterRow = letterRow + " ";
                    }
                    
                }
                letter.Add(letterRow);
            }
            if (isFirstIteration)
            {
                isFirstIteration = false;
            }
            CaptitalLetters.Add(CaptitalLetters.Count + 1, letter);
        }
        public string SecondSolution(List<string> readings)
        {
            string output = "";
           for (int j = 0; j < CaptitalLetters[CaptitalLetters.Count].Count; j++)
            {
                output= output+ CaptitalLetters[CaptitalLetters.Count][j] + System.Environment.NewLine;
                Console.WriteLine(CaptitalLetters[CaptitalLetters.Count][j]);
            }


            return output;
        }

    }
}
