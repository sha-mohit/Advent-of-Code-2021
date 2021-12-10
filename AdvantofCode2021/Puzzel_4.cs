using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_4
    {
        public string FirstSolution(List<string> readings)
        {
            int numIn = 0;
            int mat = 0;
            string[] inputs = "59,91,13,82,8,32,74,96,55,51,19,47,46,44,5,21,95,71,48,60,68,81,80,14,23,28,26,78,12,22,49,1,83,88,39,53,84,37,93,24,42,7,56,20,92,90,25,36,34,52,27,50,85,75,89,63,33,4,66,17,98,57,3,9,54,0,94,29,79,61,45,86,16,30,77,76,6,38,70,62,72,43,69,35,18,97,73,41,40,64,67,31,58,11,15,87,65,2,10,99".Split(',');
            Dictionary<int, int[][]> matrices = new Dictionary<int, int[][]>();
            Dictionary<int, int> rowd = new Dictionary<int, int>();
            Dictionary<int, int> columnd = new Dictionary<int, int>();
            for (int i = 1; i <= 500; i++)
            {
                rowd.Add(i, 0);
                columnd.Add(i, 0);
            }
            for (int i = 0; i < 100; i++)
            {
                matrices.Add(i + 1, new int[5][]);

                for (int j = 0; j < 5; j++)
                {
                    matrices[i + 1][j] = new int[5];
                    string r = readings[(i * 5) + j].Trim().Replace(' ', ',');
                    if (r.Contains(",,"))
                    {
                        r = r.Replace(",,", ",");
                    }
                    string[] row = r.Split(',');
                    for (int k = 0; k < 5; k++)
                    {
                        matrices[i + 1][j][k] = int.Parse(row[k].ToString());
                    }
                }
            }
            bool found = false;
            for (int i = 0; i < inputs.Length; i++)
            {
                int ecount = 1;
                for (int j = 1; j <= 100; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int L = 0; L < 5; L++)
                        {
                            if (matrices[j][k][L] == int.Parse(inputs[i]))
                            {
                                rowd[ecount] = (rowd[ecount] + 1);
                                if (rowd[ecount] == 5)
                                {
                                        numIn = i;
                                        mat = j;
                                    found = true;
                                    break;

                                 }
                            }
                            if (matrices[j][L][k] == int.Parse(inputs[i]))
                            {
                                columnd[ecount] = (columnd[ecount] + 1);
                                if (columnd[ecount] == 5)
                                {       numIn = i;
                                        mat = j;
                                    found = true;
                                    break;
                                }
                            }
                        }
                        ecount++;
                        if (found)
                        {
                            break;
                        }
                    }
                    if (found)
                    {
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            for (int i = 0; i <= numIn; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int L = 0; L < 5; L++)
                    {
                        if (matrices[mat][k][L] == int.Parse(inputs[i]))
                        {
                            matrices[mat][k][L] = 0;
                        }
                    }
                }
            }
            int sum = 0;
            for (int k = 0; k < 5; k++)
            {
                for (int L = 0; L < 5; L++)
                {
                    sum = sum + matrices[mat][k][L];

                }
            }
            return (sum * int.Parse(inputs[numIn])).ToString();
        }
        public string SecondSolution(List<string> readings)
        {
            int rowf = 0;
            int colf = 0;
            int numIn = 0;
            string[] inputs = "59,91,13,82,8,32,74,96,55,51,19,47,46,44,5,21,95,71,48,60,68,81,80,14,23,28,26,78,12,22,49,1,83,88,39,53,84,37,93,24,42,7,56,20,92,90,25,36,34,52,27,50,85,75,89,63,33,4,66,17,98,57,3,9,54,0,94,29,79,61,45,86,16,30,77,76,6,38,70,62,72,43,69,35,18,97,73,41,40,64,67,31,58,11,15,87,65,2,10,99".Split(',');
            Dictionary<int, int[][]> matrices = new Dictionary<int, int[][]>();
            Dictionary<int, int> rowd = new Dictionary<int, int>();
            Dictionary<int, int> columnd = new Dictionary<int, int>();
            for (int i = 1; i <= 500; i++)
            {
                rowd.Add(i, 0);
                columnd.Add(i, 0);
            }
            for (int i = 0; i < 100; i++)
            {
                matrices.Add(i + 1, new int[5][]);

                for (int j = 0; j < 5; j++)
                {
                    matrices[i + 1][j] = new int[5];
                    string r = readings[(i * 5) + j].Trim().Replace(' ', ',');
                    if (r.Contains(",,"))
                    {
                        r = r.Replace(",,", ",");
                    }
                    string[] row = r.Split(',');
                    for (int k = 0; k < 5; k++)
                    {
                        matrices[i + 1][j][k] = int.Parse(row[k].ToString());
                    }
                }
            }
            int mat = 0;
            List<int> asd = new List<int>();
            for (int i = 0; i < inputs.Length; i++)
            {
                int ecount = 1;
                for (int j = 1; j <= 100; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int L = 0; L < 5; L++)
                        {
                            if (matrices[j][k][L] == int.Parse(inputs[i]))
                            {
                                rowd[ecount] = (rowd[ecount] + 1);
                                if (rowd[ecount] == 5)
                                {
                                    if (!asd.Contains(j))
                                    {
                                        rowf = j;
                                        numIn = i;
                                        mat = rowf;
                                        asd.Add(rowf);
                                    }

                                }
                            }
                            if (matrices[j][L][k] == int.Parse(inputs[i]))
                            {
                                columnd[ecount] = (columnd[ecount] + 1);
                                if (columnd[ecount] == 5)
                                {
                                    if (!asd.Contains(j))
                                    {
                                        rowf = j;
                                        numIn = i;
                                        mat = rowf;
                                        asd.Add(rowf);
                                    }

                                }
                            }
                        }
                        ecount++;
                    }
                }
            }
            asd.Clear();
            for (int i = 0; i < inputs.Length; i++)
            {
                int ecount = 1;
                for (int j = 1; j <= 100; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int L = 0; L < 5; L++)
                        {
                            if (matrices[j][L][k] == int.Parse(inputs[i]))
                            {
                                columnd[ecount] = (columnd[ecount] + 1);
                                if (columnd[ecount] == 5)
                                {

                                    if (!asd.Contains(j))
                                    {
                                        colf = j;
                                        asd.Add(colf);
                                        if (numIn < i)
                                        {
                                            numIn = i;
                                            mat = colf;
                                        }
                                    }
                                }
                            }

                        }
                        ecount++;
                    }
                }
            }

            for (int i = 0; i <= numIn; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int L = 0; L < 5; L++)
                    {
                        if (matrices[mat][k][L] == int.Parse(inputs[i]))
                        {
                            matrices[mat][k][L] = 0;
                        }
                    }
                }
            }
            int sum = 0;
            for (int k = 0; k < 5; k++)
            {
                for (int L = 0; L < 5; L++)
                {
                    sum = sum + matrices[mat][k][L];

                }
            }
            return (sum * int.Parse(inputs[numIn])).ToString();
        }
    }
}
