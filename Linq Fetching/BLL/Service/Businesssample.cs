using BLL.Interface;
using DAL.Interface;
using DTO.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.Viewmodel.Root;

namespace BLL.Service
{
    public class Businesssample : IBusinesssample
    {
        private readonly IDatasample _IDatasample;
        public Businesssample(IDatasample IDatasample)
        {
            _IDatasample = IDatasample;
        }

        public object AverageOgTransaction()
        {
            var res = _IDatasample.AverageOgTransaction();
            return res;
        }

        public object GetJson()
        {
            var res = _IDatasample.GetJson();
            return res;
        }

        public object HighestAmount()
        {
            var res = _IDatasample.HighestAmount();
            return res;
        }

        public object Highestquantity()
        {
            var res = _IDatasample.Highestquantity();
            return res;
        }

        public object NumofTransaction()
        {
            var res = _IDatasample.NumofTransaction();
            return res;
        }

        public object SumofTransaction()
        {
            var res = _IDatasample.SumofTransaction();
            return res;
        }
    }
}
