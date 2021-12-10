using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_3
    {
        public string FirstSolution(List<string> readings)
        {
            string gamma = "";
            string epsilon = "";
            for (int j = 0; j < readings[0].Count(); j++)
            {
                int one = 0;
                int zero = 0;
                string o2 = string.Empty;
                for (int i = 0; i < readings.Count; i++)
                {
                    if (int.Parse(readings[i][j].ToString()) > 0)
                    {
                        one++;
                    }
                    else
                    {
                        zero++;
                    }
                }
                if (one>zero)
                {
                    gamma = gamma + "1";
                    epsilon = epsilon + "0";
                }
                else{
                    gamma = gamma + "0";
                    epsilon = epsilon + "1";
                }
            }
            
            return (Convert.ToInt32(gamma,2) * Convert.ToInt32(epsilon,2)).ToString();
        }

        public string SecondSolution(List<string> readings)
        {
            string o2 = string.Empty;
            string co2 = string.Empty;
            o2 = FindO2(readings, 0);
            co2 = FindCO2(readings, 0);
            return (Convert.ToInt32(o2, 2) * Convert.ToInt32(co2, 2)).ToString();
        }
        private string FindO2(List<string> reading, int place)
        {
            List<string> a = new List<string>();
            int count = 0;
            int zero = 0;
            string o2 = string.Empty;
            for (int i = 0; i < reading.Count; i++)
            {
                if (int.Parse(reading[i][place].ToString()) > 0)
                {
                    count++;
                }
                else
                {
                    zero++;
                }
            }
            if (count > zero)
            {
                for (int i = 0; i < reading.Count; i++)
                {
                    if (int.Parse(reading[i][place].ToString()) == 1)
                    {
                        a.Add(reading[i].ToString());
                    }
                }
            }
            else if (count == zero)
            {
                for (int i = 0; i < reading.Count; i++)
                {
                    if (int.Parse(reading[i][place].ToString()) == 1)
                    {
                        a.Add(reading[i].ToString());

                    }
                }
            }
            else
            {
                for (int i = 0; i < reading.Count; i++)
                {
                    if (int.Parse(reading[i][place].ToString()) == 0)
                    {
                        a.Add(reading[i].ToString());

                    }
                }
            }
            if (place == 11)
            {
                place = 0;
            }
            else
            {
                place++;
            }
            if (a.Count == 1)
            {
                return a[0];
            }
            o2 = FindO2(a, place);
            return o2;
        }
        private string FindCO2(List<string> reading, int place)
        {
            List<string> b = new List<string>();
            int count = 0;
            int zero = 0;
            string co2 = string.Empty;
            for (int i = 0; i < reading.Count; i++)
            {
                if (int.Parse(reading[i][place].ToString()) > 0)
                {
                    count++;
                }
                else
                {
                    zero++;
                }
            }
            if (count > zero)
            {
                for (int i = 0; i < reading.Count; i++)
                {
                    if (int.Parse(reading[i][place].ToString()) == 0)
                    {
                        b.Add(reading[i].ToString());
                    }
                }
            }
            else if (count == zero)
            {
                for (int i = 0; i < reading.Count; i++)
                {
                    if (int.Parse(reading[i][place].ToString()) == 0)
                    {
                        b.Add(reading[i].ToString());

                    }
                }
            }
            else
            {
                for (int i = 0; i < reading.Count; i++)
                {
                    if (int.Parse(reading[i][place].ToString()) == 1)
                    {
                        b.Add(reading[i].ToString());

                    }
                }
            }
            if (place == 11)
            {
                place = 0;
            }
            else
            {
                place++;
            }
            if (b.Count == 1)
            {
                return b[0];
            }
            co2 = FindCO2(b, place);
            return co2;
        }
    }
}
