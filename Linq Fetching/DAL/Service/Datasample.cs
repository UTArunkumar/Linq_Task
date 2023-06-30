
using DAL.Interface;
using DTO.Viewmodel;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace DAL.Service
{
    public class Datasample : IDatasample
    {
        public object AverageOgTransaction()
        {
            string json = File.ReadAllText(@"E:\seran\Json file\Json.json");
            var productDataList = JsonConvert.DeserializeObject<List<Root>>(json);


            var sumOfTransaction = productDataList
            .SelectMany(x => x.transactions)
            .GroupBy(x => x.ProductName)
            .Select(group => new
            {
                Product = group.Key,
                Average = group.Average(transaction => transaction.Price * transaction.Quantity)
            });
           
            return sumOfTransaction;
        }

        public object GetJson()
        {
            string json = File.ReadAllText(@"E:\seran\Json file\Json.json");
            var productDataList = JsonConvert.DeserializeObject<List<Root>>(json);
            return productDataList;

        }

        public object HighestAmount()
        {

            string json = File.ReadAllText(@"E:\seran\Json file\Json.json");
            var productDataList = JsonConvert.DeserializeObject<List<Root>>(json);

            var HighestAmount = productDataList
           .SelectMany(x => x.transactions)
           .GroupBy(x => x.ProductName)
           .Select(group => new
           {
               Product = group.Key,
               HighestAmount = group.Sum(x => x.Quantity * x.Price)
           }).OrderByDescending(x=>x.HighestAmount).FirstOrDefault();

            return HighestAmount;
        }

        public object Highestquantity()
        {
            string json = File.ReadAllText(@"E:\seran\Json file\Json.json");
            var productDataList = JsonConvert.DeserializeObject<List<Root>>(json);

            var Highestquantity = productDataList
           .SelectMany(x => x.transactions)
           .GroupBy(x => x.ProductName)
           .Select(group => new
           {
               Product = group.Key,
               MaxQuantity = group.Sum(x => x.Quantity)
           });
            var res = Highestquantity.OrderByDescending(u=>u.MaxQuantity).FirstOrDefault();
            return res;

        }

        public object NumofTransaction()
        {
            string json = File.ReadAllText(@"E:\seran\Json file\Json.json");
            var productDataList = JsonConvert.DeserializeObject<List<Root>>(json);

            var totalTransactions = productDataList
                                     .SelectMany(x => x.transactions)
                                     .Count();
            return ($"Total number of Transactions :  {totalTransactions}");
        }

        public object SumofTransaction()
        {
            string json = File.ReadAllText(@"E:\seran\Json file\Json.json");
            var productDataList = JsonConvert.DeserializeObject<List<Root>>(json);


            var sumOfTransaction = productDataList
            .SelectMany(x => x.transactions)
            .GroupBy(x => x.ProductName)
            .Select(group => new
            {
                Product = group.Key,
                SumAmount = group.Sum(c => c.Price * c.Quantity)
            });
            
            return sumOfTransaction;
        }


    }
}
