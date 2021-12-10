using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_9
    {
       int[][] matrices = new int[100][];
        int RowCount = 0;
        int ColCount = 0;
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
            int risk=0;
            for(int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    int locUp = i - 1 < 0 ? 999: i - 1;
                    int locDown = i + 1 > (RowCount - 1) ? 999 : i + 1;
                    int locBack = j - 1 < 0 ? 999 : j - 1;
                    int locFor = j + 1 > (ColCount - 1) ? 999 : j + 1;
                    int lowest = 999;
                    if (locUp != 999)
                    {
                        if (matrices[i][j] < matrices[locUp][j])
                        {
                            lowest = matrices[locUp][j];
                        }
                        else { continue; }
                        
                    }
                    if (locDown != 999)
                    {
                        if (matrices[i][j] < matrices[locDown][j])
                        {
                            lowest = matrices[locDown][j];
                        }
                        else { continue; }
                    }
                    if (locBack != 999)
                    {
                        if (matrices[i][j] < matrices[i][locBack])
                        {
                            lowest = matrices[i][locBack];
                         }
                        else { continue; }

                    }
                    if (locFor != 999)
                    {
                        if (matrices[i][j] < matrices[i][locFor])
                        {
                            lowest = matrices[i][locFor];
                        }
                        else { continue; }
                    }
                    if (lowest!=999)
                    {
                        risk = risk + matrices[i][j]+1;
                        lowerePoints.Add(i + "," + j);
                    }
                  
                }
            }
           return risk.ToString();
        }
        List<string> lowerePoints = new List<string>();
        Dictionary<string, List<string>> finalBasin = new Dictionary<string, List<string>>();
        List<string> totalbasin = new List<string>();

        public string SecondSolution(List<string> readings)
        {
            List<int> count = new List<int>();
            for (int i = 0; i < lowerePoints.Count; i++)
            {
                totalbasin.Add(lowerePoints[i]);
                finalBasin.Add((lowerePoints[i]),FindBasin(lowerePoints[i]));
            }
            foreach (var item in finalBasin)
            {
                count.Add(item.Value.Count+1);   
            }
            count.Sort();

            return (count[count.Count-1] * count[count.Count - 2] * count[count.Count - 3]).ToString();
        }
        public List<string> FindBasin(string coordinate)
        {
            string[] coord = coordinate.Split(',');
            int i = int.Parse(coord[0].ToString());
            int j = int.Parse(coord[1].ToString());
            List<string> basin = new List<string>();
            List<string> finalbasin = new List<string>();

            int locUp = i - 1 < 0 ? 999 : i - 1;
            int locDown = i + 1 > (RowCount - 1) ? 999 : i + 1;
            int locBack = j - 1 < 0 ? 999 : j - 1;
            int locFor = j + 1 > (ColCount - 1) ? 999 : j + 1;
            if (locUp != 999)
            {
                if (matrices[i][j] <= matrices[locUp][j] && matrices[locUp][j]!= 9)
                {
                    if (!totalbasin.Contains(locUp + "," + j))
                    {
                        totalbasin.Add(locUp + "," + j);
                        basin.Add(locUp + "," + j);
                    }
                   
                }
            }
            if (locDown != 999)
            {
                if (matrices[i][j] <= matrices[locDown][j] && matrices[locDown][j] != 9)
                {
                    if (!totalbasin.Contains(locDown + "," + j))
                    {
                        totalbasin.Add(locDown + "," + j);
                        basin.Add(locDown + "," + j);
                    }
                }
            }
            if (locBack != 999)
            {
                if (matrices[i][j] <= matrices[i][locBack] && matrices[i][locBack] != 9)
                {
                    if (!totalbasin.Contains(i + "," + locBack))
                    {
                        totalbasin.Add(i + "," + locBack);
                        basin.Add(i + "," + locBack);
                    }
                }

            }
            if (locFor != 999)
            {
                if (matrices[i][j] <= matrices[i][locFor] && matrices[i][locFor] != 9)
                {
                    if (!totalbasin.Contains(i + "," + locFor))
                    {
                        totalbasin.Add(i + "," + locFor);
                        basin.Add(i + "," + locFor);
                    }
                }
            }
            if (basin.Count==0)
            {
                return finalbasin;
            }
            for (int k = 0; k < basin.Count; k++)
            {
                finalbasin.Add(basin[k]);
                finalbasin.AddRange(FindBasin(basin[k]));
            }
            
            return finalbasin;
        }
    }
   
}
