using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_10
    {

        public string FirstSolution(List<string> readings)
        {
            int count = 0;
            Dictionary<string, string> pair = new Dictionary<string, string>();
            pair.Add("<", ">");
            pair.Add("(", ")");
            pair.Add("[", "]");
            pair.Add("{", "}");

            Dictionary<string, int> pairValues = new Dictionary<string, int>();
            pairValues.Add( ">",25137);
            pairValues.Add( ")",3);
            pairValues.Add( "]",57);
            pairValues.Add( "}",1197); 
            List<string> row = new List<string>();
            List<int> invalidROw = new List<int>();
            List<string> invalidValues = new List<string>();

            for (int i = 0; i < readings.Count; i++)
            {
               for (int j = 0; j < readings[i].Count(); j++)
                {

                    if (pair.ContainsKey(readings[i][j].ToString()))
                    {
                        row.Add(readings[i][j].ToString());
                    } else
                    {
                        if (pair[row[row.Count - 1]].Equals(readings[i][j].ToString()))
                        {
                            row.RemoveAt((row.Count - 1));
                        }else
                        {

                            invalidValues.Add(readings[i][j].ToString());
                            break;
                        }
                    }

                }
                if (row.Count!=0)
                {
                    invalidROw.Add(i);
                }
                row.Clear();
            }
            for (int i = 0; i < invalidValues.Count; i++)
            {
                count = count + pairValues[invalidValues[i]];
            }
            return count.ToString();
        }

        public string SecondSolution(List<string> readings)
        {
            double count = 0;
            Dictionary<string, string> pair = new Dictionary<string, string>();
            pair.Add("<", ">");
            pair.Add("(", ")");
            pair.Add("[", "]");
            pair.Add("{", "}");

            Dictionary<string, int> pairValues = new Dictionary<string, int>();
            pairValues.Add(">", 4);
            pairValues.Add(")", 1);
            pairValues.Add("]", 2);
            pairValues.Add("}", 3);
            List<string> row = new List<string>();
            List<double> final = new List<double>();


            bool invalid = false;
         
           for (int i = 0; i < readings.Count; i++)
            {
                double rowTotal = 0;
                for (int j = 0; j < readings[i].Count(); j++)
                {

                    if (pair.ContainsKey(readings[i][j].ToString()))
                    {
                        row.Add(readings[i][j].ToString());
                    }
                    else
                    {
                        if (pair[row[row.Count - 1]].Equals(readings[i][j].ToString()))
                        {
                            row.RemoveAt((row.Count - 1));
                        }
                        else
                        {
                           invalid = true;
                           break;
                        }
                    }

                }
                if (row.Count != 0 && !invalid)
                {
                    rowTotal = 0;
                    for (int j = 0; j < row.Count; j++)
                    {
                        rowTotal = rowTotal * 5 + pairValues[pair[row[row.Count - 1 - j]]];
                    }
                    final.Add(rowTotal);
                }
                invalid = false;
                row.Clear();
            }
            final.Sort();
            count = final[(final.Count -1)/2];
            return count.ToString();
        }
    }
}
