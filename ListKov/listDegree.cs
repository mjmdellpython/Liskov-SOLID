using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKov
{
    public class ListDegree
    {
        public virtual string resultAllDegree(GeneralProcess gp, int d)
        {
            return gp.allDegree(d).ToString();
        }

    }

    public class listOverDegree:ListDegree
    {
        public override string resultAllDegree(GeneralProcess gp, int d)
        {
            return $"Sucess " + gp.overDegree(d);
        }
    }

    public class listUnderDegree : ListDegree
    {

        public override string resultAllDegree(GeneralProcess gp, int d)
        {
            return $"Fail " + gp.underDegree(d);
        }
    }
}
