using DTO.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.Viewmodel.Root;

namespace BLL.Interface
{
    public  interface IBusinesssample
    {
        public object GetJson();
        public object NumofTransaction();

        public object SumofTransaction();
        public object AverageOgTransaction();
        public object Highestquantity();
        public object HighestAmount();
    }
}
