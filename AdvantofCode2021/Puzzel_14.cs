using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2022
{
    public class Puzzel_14
    {
        Dictionary<string, string> step = new Dictionary<string, string>();
        string input = "PHOSBSKBBBFSPPPCCCHN";
        //string input = "NNCB";
        public Dictionary<string, double> counter = new Dictionary<string, double>();
        public string FirstSolution(List<string> readings)
        {
            for (int i = 0; i < readings.Count; i++)
            {
                string[] cord = readings[i].Trim().Replace(" -> ", ",").Split(',');
                step.Add(cord[0], cord[1]);
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                string pair1 = "";
                string pair2 = "";
                string pair = input[i].ToString() + input[i + 1].ToString();
                pair1 = input[i].ToString() + step[pair];
                if (counter.ContainsKey(pair1))
                {
                    counter[pair1]++;
                }
                else
                {
                    counter.Add(pair1, 1);
                }
                pair2 = step[pair] + input[i + 1].ToString();
                if (counter.ContainsKey(pair2))
                {
                    counter[pair2]++;
                }
                else
                {
                    counter.Add(pair2, 1);
                }
            }
            return parse(9);
        }
        public string parse(int loop)
        {
            Dictionary<string, double> least = new Dictionary<string, double>();
            for (int i = 0; i < loop; i++)
            {
                int count = counter.Count;
                Dictionary<string, double> counter1 = new Dictionary<string, double>();
                foreach (KeyValuePair<string, double> item in counter)
                {

                    string pair1 = item.Key[0].ToString() + step[item.Key].ToString();
                    string pair2 = step[item.Key].ToString() + item.Key[1].ToString();
                    if (counter1.ContainsKey(pair1))
                    {
                        counter1[pair1] = counter1[pair1] + item.Value;
                    }
                    else
                    {
                       counter1.Add(pair1, item.Value);
                    }
                    if (counter1.ContainsKey(pair2))
                    {
                        counter1[pair2] = counter1[pair2] + item.Value;
                    }
                    else
                    {
                        counter1.Add(pair2, item.Value);
                    }


                }
                counter.Clear();
                counter = counter1;
            }

            least.Clear();
            foreach (KeyValuePair<string, double> item in counter)
            {
                if (least.ContainsKey(item.Key[0].ToString()))
                {
                    least[item.Key[0].ToString()] = least[item.Key[0].ToString()] + item.Value;
                }
                else
                {
                    least.Add(item.Key[0].ToString(), item.Value);
                }
            }
            least[input[input.Length - 1].ToString()] = least[input[input.Length - 1].ToString()] + 1;//last element
            double less = 0;
            double pop = 0;
            foreach (KeyValuePair<string, double> item in least)
            {
                if (less == 0)
                {
                    less = item.Value;
                }
                if (pop == 0)
                {
                    pop = item.Value;
                }
                if (item.Value > pop)
                {
                    pop = item.Value;
                }
                if (item.Value < less)
                {
                    less = item.Value;
                }
            }
            return (pop - less).ToString();
        }

        public string SecondSolution(List<string> readings)
        {
            return parse(30);
        }
    }
}
