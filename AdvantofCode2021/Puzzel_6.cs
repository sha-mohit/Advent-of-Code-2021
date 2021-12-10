using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2021
{
    public class Puzzel_6
    {
        public string FirstSolution(List<string> readings)
        {
            string[] inputs = "4,1,4,1,3,3,1,4,3,3,2,1,1,3,5,1,3,5,2,5,1,5,5,1,3,2,5,3,1,3,4,2,3,2,3,3,2,1,5,4,1,1,1,2,1,4,4,4,2,1,2,1,5,1,5,1,2,1,4,4,5,3,3,4,1,4,4,2,1,4,4,3,5,2,5,4,1,5,1,1,1,4,5,3,4,3,4,2,2,2,2,4,5,3,5,2,4,2,3,4,1,4,4,1,4,5,3,4,2,2,2,4,3,3,3,3,4,2,1,2,5,5,3,2,3,5,5,5,4,4,5,5,4,3,4,1,5,1,3,4,4,1,3,1,3,1,1,2,4,5,3,1,2,4,3,3,5,4,4,5,4,1,3,1,1,4,4,4,4,3,4,3,1,4,5,1,2,4,3,5,1,1,2,1,1,5,4,2,1,5,4,5,2,4,4,1,5,2,2,5,3,3,2,3,1,5,5,5,4,3,1,1,5,1,4,5,2,1,3,1,2,4,4,1,1,2,5,3,1,5,2,4,5,1,2,3,1,2,2,1,2,2,1,4,1,3,4,2,1,1,5,4,1,5,4,4,3,1,3,3,1,1,3,3,4,2,3,4,2,3,1,4,1,5,3,1,1,5,3,2,3,5,1,3,1,1,3,5,1,5,1,1,3,1,1,1,1,3,3,1".Split(',');
            //string[] inputs = "3,4,3,1,2".Split(',');
            //List<int> input = new List<int>();
            double zero = 0;
            double one = 0;
            double two = 0;
            double th = 0;
            double fo = 0;
            double fi = 0;
            double six = 0;
            double se = 0;
            double eg = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                //input.Add(int.Parse(inputs[i]));
                if (int.Parse(inputs[i]) == 0)
                {
                    zero++;
                }
                if (int.Parse(inputs[i]) == 1)
                {
                    one++;
                }
                if (int.Parse(inputs[i]) == 2)
                {
                    two++;
                }
                if (int.Parse(inputs[i]) == 3)
                {
                    th++;
                }
                if (int.Parse(inputs[i]) == 4)
                {
                    fo++;
                }
                if (int.Parse(inputs[i]) == 5)
                {
                    fi++;
                }
                if (int.Parse(inputs[i]) == 6)
                {
                    six++;
                }
                if (int.Parse(inputs[i]) == 7)
                {
                    se++;
                }
                if (int.Parse(inputs[i]) == 8)
                {
                    eg++;
                }
            }

            double total = 0;
            double inc = 0;
            for (int i = 0; i < 80; i++)
            {
                inc = zero;
                zero = one;
                one = two;
                two = th;
                th = fo;
                fo = fi;
                fi = six;
                six = se + inc;
                se = eg;
                eg = inc;

                total = total + inc;
                inc = 0;
            }
            return (total + inputs.Length).ToString();
           
        }
        public string SecondSolution(List<string> readings)
        {
            string[] inputs = "4,1,4,1,3,3,1,4,3,3,2,1,1,3,5,1,3,5,2,5,1,5,5,1,3,2,5,3,1,3,4,2,3,2,3,3,2,1,5,4,1,1,1,2,1,4,4,4,2,1,2,1,5,1,5,1,2,1,4,4,5,3,3,4,1,4,4,2,1,4,4,3,5,2,5,4,1,5,1,1,1,4,5,3,4,3,4,2,2,2,2,4,5,3,5,2,4,2,3,4,1,4,4,1,4,5,3,4,2,2,2,4,3,3,3,3,4,2,1,2,5,5,3,2,3,5,5,5,4,4,5,5,4,3,4,1,5,1,3,4,4,1,3,1,3,1,1,2,4,5,3,1,2,4,3,3,5,4,4,5,4,1,3,1,1,4,4,4,4,3,4,3,1,4,5,1,2,4,3,5,1,1,2,1,1,5,4,2,1,5,4,5,2,4,4,1,5,2,2,5,3,3,2,3,1,5,5,5,4,3,1,1,5,1,4,5,2,1,3,1,2,4,4,1,1,2,5,3,1,5,2,4,5,1,2,3,1,2,2,1,2,2,1,4,1,3,4,2,1,1,5,4,1,5,4,4,3,1,3,3,1,1,3,3,4,2,3,4,2,3,1,4,1,5,3,1,1,5,3,2,3,5,1,3,1,1,3,5,1,5,1,1,3,1,1,1,1,3,3,1".Split(',');
            //string[] inputs = "3,4,3,1,2".Split(',');
            //List<int> input = new List<int>();
            double zero = 0;
            double one = 0;
            double two = 0;
            double th = 0;
            double fo = 0;
            double fi = 0;
            double six = 0;
            double se = 0;
            double eg = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                //input.Add(int.Parse(inputs[i]));
                if (int.Parse(inputs[i]) == 0)
                {
                    zero++;
                }
                if (int.Parse(inputs[i]) == 1)
                {
                    one++;
                }
                if (int.Parse(inputs[i]) == 2)
                {
                    two++;
                }
                if (int.Parse(inputs[i]) == 3)
                {
                    th++;
                }
                if (int.Parse(inputs[i]) == 4)
                {
                    fo++;
                }
                if (int.Parse(inputs[i]) == 5)
                {
                    fi++;
                }
                if (int.Parse(inputs[i]) == 6)
                {
                    six++;
                }
                if (int.Parse(inputs[i]) == 7)
                {
                    se++;
                }
                if (int.Parse(inputs[i]) == 8)
                {
                    eg++;
                }
            }

            double total = 0;
            double inc = 0;
            for (int i = 0; i < 256; i++)
            {
                inc = zero;
                zero = one;
                one = two;
                two = th;
                th = fo;
                fo = fi;
                fi = six;
                six = se + inc;
                se = eg;
                eg = inc;

                total = total + inc;
                inc = 0;
            }
            return (total + inputs.Length).ToString();

          
        }
    }
}
