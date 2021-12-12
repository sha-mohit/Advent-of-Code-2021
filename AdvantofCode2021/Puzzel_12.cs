using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_12
    {
        int[][] matrices = new int[10][];
        int RowCount = 0;
        List<string> smallCaves = new List<string>();
        Dictionary<string, List<string>> caveMap = new Dictionary<string, List<string>>();
        public string FirstSolution(List<string> readings)
        {
            RowCount = readings.Count;
            for (int i = 0; i < RowCount; i++)
            {
                string[] row = readings[i].Split('-');
                if (caveMap.ContainsKey(row[0]))
                {
                    caveMap[row[0]].Add(row[1]);
                } else
                {
                    List<string> caves = new List<string>();
                    caves.Add(row[1]);
                    caveMap.Add(row[0], caves);
                }
            }
            for (int i = 0; i < RowCount; i++)
            {
                string[] row = readings[i].Split('-');
                if (caveMap.ContainsKey(row[1]))
                {
                    caveMap[row[1]].Add(row[0]);
                }
                else
                {
                    List<string> caves = new List<string>();
                    caves.Add(row[0]);
                    caveMap.Add(row[1], caves);
                }

            }
            List<string> r = new List<string>();
            r.Add("start");
            if (caveMap.ContainsKey("start"))
            {
                int edges = caveMap["start"].Count;

                for (int i = 0; i < edges; i++)
                {
                    List<string> routes = new List<string>();
                    routes.AddRange(r);
                  
                     traverseMap(caveMap["start"][i], routes);
                }

            } 


           return pathCount.ToString();
        }
       
        int pathCount = 0;
        Dictionary<int, List<string>> finalRoutes = new Dictionary<int, List<string>>();
        public void traverseMap(string cave,List<string> route)
        {
            Dictionary<int, List<string>> AllRoutes = new Dictionary<int, List<string>>();

            if (cave.Equals("start"))
            {
                return;
            }
            if (cave.Any(char.IsLower))
            {
                if (route.Contains(cave))
                {
                    return;

                }
                else
                {
                    route.Add(cave);
                }
            }
            else
            {
                route.Add(cave);
            }
            
            if (cave.Equals("end"))
            {
                pathCount++;
                finalRoutes.Add(finalRoutes.Count + 1, route);
                return;
             }
            

            if (caveMap.ContainsKey(cave))
            {
                int edges = caveMap[cave].Count;
                for (int i = 0; i < edges; i++)
                {
                    List<string> r = new List<string>();
                    r.AddRange(route);
                    traverseMap(caveMap[cave][i],r);
                }
            }
        }

        public string SecondSolution(List<string> readings)
        {

            RowCount = readings.Count;
            caveMap.Clear();
            for (int i = 0; i < RowCount; i++)
            {
                string[] row = readings[i].Split('-');
                if (!row[1].Equals("start")&& !row[0].Equals("end"))
                {
                    if (caveMap.ContainsKey(row[0]))
                    {
                        if (!caveMap[row[0]].Contains(row[1]))
                        {
                            caveMap[row[0]].Add(row[1]);
                        }
                    }
                    else
                    {
                        List<string> caves = new List<string>();
                        caves.Add(row[1]);
                        caveMap.Add(row[0], caves);
                    }
                }
               
            }
            for (int i = 0; i < RowCount; i++)
            {
                string[] row = readings[i].Split('-');
                if (!row[0].Equals("start") && !row[1].Equals("end"))
                {
                    if (caveMap.ContainsKey(row[1]))
                    {
                        if (!caveMap[row[1]].Contains(row[0]))
                        {
                            caveMap[row[1]].Add(row[0]);
                        }
                      
                    }
                    else
                    {
                        List<string> caves = new List<string>();
                        caves.Add(row[0]);
                        caveMap.Add(row[1], caves);
                    }
                }
              

            }
            pathCount = 0;
            finalRoutes.Clear();
            List<string> r = new List<string>();
            r.Add("start");
            if (caveMap.ContainsKey("start"))
            {
                int edges = caveMap["start"].Count;

                for (int i = 0; i < edges; i++)
                {
                    List<string> routes = new List<string>();
                    routes.AddRange(r);

                    traverseMap2(caveMap["start"][i], routes);
                }

            }


            return pathCount.ToString();
        }
        public void traverseMap2(string cave, List<string> route)
        {
            Dictionary<int, List<string>> AllRoutes = new Dictionary<int, List<string>>();

            if (cave.Equals("start"))
            {
                return;
            }
            if (cave.Any(char.IsLower))
            {
                if (!isValidRoute(route, cave))
                {
                    return;

                }
                else
                {
                    route.Add(cave);
                }
            }
            else
            {
                route.Add(cave);
            }

            if (cave.Equals("end"))
            {
                pathCount++;
                finalRoutes.Add(finalRoutes.Count + 1, route);
                return;
            }


            if (caveMap.ContainsKey(cave))
            {
                int edges = caveMap[cave].Count;
                for (int i = 0; i < edges; i++)
                {
                    List<string> r = new List<string>();
                    r.AddRange(route);
                    traverseMap2(caveMap[cave][i], r);
                }
            }
        }

        public bool isValidRoute(List<string> route, string cave)
        {
            bool inValid = false;

            for (int i = 0; i < route.Count; i++)
            {
                int count = 0;
                if (route[i].Any(char.IsLower))
                {
                    for (int j = 0; j < route.Count; j++)
                    {
                        if (route[j].Any(char.IsLower))
                        {
                            if (route[j].Equals(route[i]))
                            {
                                count++;

                            }
                        }
                    }

                }

                if (count >= 2)
                {
                    inValid = true;
                    break;
                }
            }
            if (inValid && route.Contains(cave))
            {
                return false;
            }

            return true;
        }
    }

   
}
