using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public interface IBalance
    {
        public double WalletBalance{get;set;}

        public  void WalletRecharge(double recharge);
        
    }
}