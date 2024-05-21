using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public interface IBalance
    {
     
        public double WalletBalance{get;}

        public void WalletRecharger()
        {}

        public void DeductAmount()
        {}
    }
}