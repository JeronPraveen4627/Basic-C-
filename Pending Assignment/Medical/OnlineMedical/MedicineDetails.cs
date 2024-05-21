using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public class MedicineDetails
    {
        private static int s_medicineID=100;

        public string MedicineID{get;}

        public string MedicineName{get;set;}

        public int AvailableCount{get;set;}

        public double Price{get;set;}

        public DateTime DateOfExpiry{get;set;}

        public MedicineDetails(string medicineName,int availableCount,double price, DateTime dateOfExpiry)
        {
            MedicineID="MD"+(++s_medicineID);
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }
        public MedicineDetails(string name)
        {
            string [] Values=name.Split(",");
            MedicineID=Values[0];
            s_medicineID=int.Parse(Values[0].Remove(0,2));
            MedicineName=Values[1];
            AvailableCount=int.Parse(Values[2]);
            Price=int.Parse(Values[3]);
            DateOfExpiry=DateTime.ParseExact(Values[4],"dd/MM/yyyy",null);
            
        }
    }
}