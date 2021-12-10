using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_5
    {
        public string FirstSolution(List<string> readings)
        {
            int count = 0;
            int[][] matrices = new int[1000][];
            for (int i = 0; i < 1000; i++)
            {
                matrices[i] = new int[1000];
                for (int j = 0; j < 1000; j++)
                {
                    matrices[i][j] = 0;
                }
            }
            for (int i = 0; i < readings.Count; i++)
            {
                string r = readings[i].Trim().Replace(" -> ", ",");
                string[] row = r.Split(',');
                int a, b, c, d;
                a = int.Parse(row[0]);
                b = int.Parse(row[1]);
                c = int.Parse(row[2]);
                d = int.Parse(row[3]);

                if (a == c && b == d)
                {
                    matrices[a][b] = matrices[a][b] + 1;
                }
                if (a == c && b != d)
                {
                    for (int j = 0; j <= Math.Abs(d - b); j++)
                    {
                        if (b > d)
                        {
                            matrices[a][b - j] = matrices[a][b - j] + 1;
                        }
                        else
                        {
                            matrices[a][b + j] = matrices[a][b + j] + 1;
                        }
                    }
                }
                if (b == d && a != c)
                {
                    for (int j = 0; j <= Math.Abs(c - a); j++)
                    {
                        if (a > c)
                        {
                            matrices[a - j][b] = matrices[a - j][b] + 1;
                        }
                        else
                        {
                            matrices[a + j][b] = matrices[a + j][b] + 1;
                        }
                    }
                }
            }
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (matrices[i][j] >= 2)
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }
        public string SecondSolution(List<string> readings)
        {
            int[][] matrices = new int[1000][];
            for (int i = 0; i < 1000; i++)
            {
                matrices[i] = new int[1000];
                for (int j = 0; j < 1000; j++)
                {
                    matrices[i][j] = 0;
                }
            }
            for (int i = 0; i < readings.Count; i++)
            {
                string r = readings[i].Trim().Replace(" -> ", ",");
                string[] row = r.Split(',');
                int a, b, c, d;
                a = int.Parse(row[0]);
                b = int.Parse(row[1]);
                c = int.Parse(row[2]);
                d = int.Parse(row[3]);

                if (a == c && b == d)
                {
                    matrices[a][b] = matrices[a][b] + 1;
                }
                if (a == c && b != d)
                {
                    for (int j = 0; j <= Math.Abs(d - b); j++)
                    {
                        if (b > d)
                        {
                            matrices[a][b - j] = matrices[a][b - j] + 1;
                        }
                        else
                        {
                            matrices[a][b + j] = matrices[a][b + j] + 1;
                        }
                    }
                }
                if (b == d && a != c)
                {
                    for (int j = 0; j <= Math.Abs(c - a); j++)
                    {
                        if (a > c)
                        {
                            matrices[a - j][b] = matrices[a - j][b] + 1;
                        }
                        else
                        {
                            matrices[a + j][b] = matrices[a + j][b] + 1;
                        }
                    }
                }
                if (a != c && d != b)
                {
                    for (int j = 0; j <= Math.Abs(c - a); j++)
                    {
                        if (a > c)
                        {
                            if (b > d)
                            {
                                matrices[a - j][b - j] = matrices[a - j][b - j] + 1;
                            }
                            else
                            {
                                matrices[a - j][b + j] = matrices[a - j][b + j] + 1;
                            }
                        }
                        else
                        {
                            if (b > d)
                            {
                                matrices[a + j][b - j] = matrices[a + j][b - j] + 1;
                            }
                            else
                            {
                                matrices[a + j][b + j] = matrices[a + j][b + j] + 1;
                            }
                        }
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (matrices[i][j] >= 2)
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }
    }
}
