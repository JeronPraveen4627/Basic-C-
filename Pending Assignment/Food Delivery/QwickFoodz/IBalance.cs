using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public interface IBalance
    {
        public double WalletBalance{get;}

        public static void WalletRecharge(double amount){}

        public static void DeductBalance(double amount){}
    }
}