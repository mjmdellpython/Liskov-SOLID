using System;
using System.Collections.Generic;

namespace ListKov
{
    class Program
    {

        static void Main(string[] args)
        {
            GeneralProcess gp = new GeneralProcess();
            List<int>studentDegrees = new List<int>();
            studentDegrees.Add(20);
            studentDegrees.Add(44);
            studentDegrees.Add(50);
            studentDegrees.Add(51);
            studentDegrees.Add(10);
            studentDegrees.Add(70);
            studentDegrees.Add(65);
            studentDegrees.Add(49);

            ListDegree ListDeg;
            foreach (var i in studentDegrees)
            {
                if (i>=50)
                {
                    ListDeg = new listOverDegree();
                }else if (i < 50)
                {
                    ListDeg = new listUnderDegree();
                }
                else
                {
                    ListDeg = new ListDegree();
                }

                string str = ListDeg.resultAllDegree(gp, i);
                Console.WriteLine(str);
            }
        }
    }
}
