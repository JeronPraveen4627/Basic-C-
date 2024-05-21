using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dependence;
class Program
{
    public static void Main(string[] args)
    {
       CCAccount ccAccount = new CCAccount();
       {
            ccAccount.AccountNumber=123;
            ccAccount.Name="Jeron";
            ccAccount.Balance=1000000000;

            SBAccount sBAccount=new SBAccount();
            sBAccount.AccountNumber=123;
            sBAccount.Name="Praveen";
            sBAccount.Balance=10000;

            List<CCAccount> cCList=new List<CCAccount>();
            cCList.Add(ccAccount);

            List<SBAccount> sbList =new List<SBAccount>();
            sbList.Add(sBAccount);

            List<IAccount> accountList=new List<IAccount>();
            accountList.Add(sBAccount);
            accountList.Add(ccAccount);
       } 
    }
}  