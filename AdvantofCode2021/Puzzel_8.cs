using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_8
    {
        public string FirstSolution(List<string> readings)
        {
            int count = 0;

            for (int i = 0; i < readings.Count; i++)
            {
                string[] row = readings[i].Split('|');
                string[] row0 = row[1].Trim().Split(' ');
                for (int j = 0; j < row0.Length; j++)
                {

                    if (row0[j].Count() == 2)
                    {
                        count = count + 1;
                    }
                    if (row0[j].Count() == 4)
                    {
                        count = count + 1;
                    }
                    if (row0[j].Count() == 3)
                    {
                        count = count + 1;
                    }
                    if (row0[j].Count() == 7)
                    {
                        count = count + 1;
                    }

                } 
            }
            return count.ToString();
        }

        public string SecondSolution(List<string> readings)
        {
            int count = 0;

           for (int i = 0; i < readings.Count; i++)
            {
                string app = "";
                string[] row = readings[i].Split('|');
                string[] row0 = row[0].Trim().Split(' ');
                string[] row1 = row[1].Trim().Split(' ');

                string one = "";
                string two = "";
                string the = "";
                string fo = "";
                string fi = "";
                string six = "";
                string se = "";
                string eg = "";
                string nin = "";
                string zer = "";
                for (int j = 0; j < row0.Length; j++)
                {

                    if (row0[j].Count() == 2)
                    {
                        one = sortString(row0[j]);
                    }
                    if (row0[j].Count() == 4)
                    {
                        fo = sortString(row0[j]);
                    }
                    if (row0[j].Count() == 3)
                    {
                        se = sortString(row0[j]);
                    }
                    if (row0[j].Count() == 7)
                    {
                        eg = sortString(row0[j]);
                    }

                }
                for (int j = 0; j < row0.Length; j++)
                {
                    int rem = 0;
                    int union = 0;
                    int inter = 0;
                    if (row0[j].Count() == 5)
                    {
                        string _2_3_5 = sortString(row0[j]);
                        if (one != "")
                        {
                            for (int l = 0; l < one.Count(); l++)
                            {
                                if (_2_3_5.Contains(one[l]))
                                {
                                    _2_3_5 = _2_3_5.Replace(one[l].ToString(), "");
                                    union++;
                                }
                                else
                                {
                                    inter++;
                                }
                            }
                            rem = _2_3_5.Count();
                            if (rem == 3 && union == 2 && inter == 0)
                            {
                                the = sortString(row0[j]);
                            }
                            else
                            {
                                _2_3_5 = sortString(row0[j]);
                                rem = 0;
                                union = 0;
                                inter = 0;
                                if (fo != "")
                                {
                                    for (int l = 0; l < fo.Count(); l++)
                                    {
                                        if (_2_3_5.Contains(fo[l]))
                                        {
                                            _2_3_5 = _2_3_5.Replace(fo[l].ToString(), "");
                                            union++;
                                        }
                                        else
                                        {
                                            inter++;
                                        }
                                    }
                                    rem = _2_3_5.Count();
                                    if (rem == 3 && union == 2 && inter == 2)
                                    {
                                        two = sortString(row0[j]);
                                    }
                                    else
                                    {
                                        fi = sortString(row0[j]);
                                    }
                                }

                            }
                        }
                    }
                    rem = 0;
                    union = 0;
                    inter = 0;
                    if (row0[j].Count() == 6)
                    {
                        string _0_6_9 = sortString(row0[j]);
                        if (one != "")
                        {
                            for (int l = 0; l < one.Count(); l++)
                            {
                                if (_0_6_9.Contains(one[l]))
                                {
                                    _0_6_9 = _0_6_9.Replace(one[l].ToString(), "");
                                    union++;
                                }
                                else
                                {
                                    inter++;
                                }
                            }
                            rem = _0_6_9.Count();
                            if (rem == 5 && union == 1 && inter == 1)
                            {
                                six = sortString(row0[j]);
                            }
                            else
                            {
                                _0_6_9 = sortString(row0[j]);
                                rem = 0;
                                union = 0;
                                inter = 0;
                                if (fo != "")
                                {
                                    for (int l = 0; l < fo.Count(); l++)
                                    {
                                        if (_0_6_9.Contains(fo[l]))
                                        {
                                            _0_6_9 = _0_6_9.Replace(fo[l].ToString(), "");
                                            union++;
                                        }
                                        else
                                        {
                                            inter++;
                                        }
                                    }
                                    rem = _0_6_9.Count();
                                    if (rem == 2 && union == 4 && inter == 0)
                                    {
                                        nin = sortString(row0[j]);
                                    }
                                    else
                                    {
                                        zer = sortString(row0[j]);
                                    }
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < row1.Length; j++)
                {

                    if (row1[j].Count() == 2)
                    {
                        app = app + "1";
                    }
                    if (row1[j].Count() == 4)
                    {
                        app = app + "4";
                    }
                    if (row1[j].Count() == 3)
                    {
                        app = app + "7";
                    }
                    if (row1[j].Count() == 7)
                    {
                        app = app + "8";
                    }
                    if (row1[j].Count() == 5)
                    {
                        string _2_3_5 = sortString(row1[j]);
                        if (_2_3_5.Equals(two))
                        {
                            app = app + "2";
                        }
                        else if (_2_3_5.Equals(the))
                        {
                            app = app + "3";
                        }
                        else
                        {
                            app = app + "5";
                        }
                    }
                    if (row1[j].Count() == 6)
                    {

                        string _0_6_9 = sortString(row1[j]);
                        if (_0_6_9.Equals(zer))
                        {
                            app = app + "0";
                        }
                        else if (_0_6_9.Equals(six))
                        {
                            app = app + "6";
                        }
                        else
                        {
                            app = app + "9";
                        }
                    }

                }
                count = count + int.Parse(app);
            }
                return count.ToString();
        }
        public string sortString(String str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            return String.Join("", arr);
        }
    }
}
