using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public interface IWallet
    {
        public double WalletBalance{get;}

        public void WalletRecharger(double amount);

        public void DeductBalance(double amount);
    }
}