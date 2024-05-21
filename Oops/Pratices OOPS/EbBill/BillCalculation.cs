using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace EbBill
{
    public class BillCalculation
    {
        private static int s_MeterID=1001;
        public string MeterID{get; }
        public string UserName{get; set;}

        public long PhoneNumber{get; set;}

        public string MailID{get; set;}

        public int UnitUsed{get; set;}

        public BillCalculation(string Name, long Phone,string MailId,int Unit)
        {
            s_MeterID++;
            MeterID="EB"+s_MeterID;
            UserName =Name;
            PhoneNumber=Phone;
            MailID=MailId; 
            UnitUsed=Unit;
        }

        public int AmountCalculate()
        {
            int result;
            result=UnitUsed*5;
            return result;
        }
    }
}