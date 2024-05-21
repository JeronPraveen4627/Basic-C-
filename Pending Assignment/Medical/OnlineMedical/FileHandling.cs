using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineMedical"))
            {
                Console.WriteLine("Creating Folder...");
                Directory.CreateDirectory("OnlineMedical");
            }

            if(!File.Exists("OnlineMedical/UserDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("OnlineMedical/UserDetails.csv").Close();
            }
            if(!File.Exists("OnlineMedical/MedicalDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("OnlineMedical/MedicalDetails.csv").Close();
            }
             if(!File.Exists("OnlineMedical/OrderDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("OnlineMedical/OrderDetails.csv").Close();
            }
        }
        public static void WriteToCSV()
        {
            string[] user =new string[Operation.userList.Count];
            for(int i=0;i<Operation.userList.Count;i++)
            {
                user[i]=Operation.userList[i].UserID+","+Operation.userList[i].Name+","+Operation.userList[i].Age+","+Operation.userList[i].City+","+Operation.userList[i].PhoneNumber+","+Operation.userList[i].WalletBalance;
            }
            File.WriteAllLines("OnlineMedical/UserDetails.csv",user);


            string[] medical=new string[Operation.medicineList.Count];
            for(int i=0;i<Operation.medicineList.Count;i++)
            {
                medical[i]=Operation.medicineList[i].MedicineID+","+Operation.medicineList[i].MedicineName+","+Operation.medicineList[i].AvailableCount+","+Operation.medicineList[i].Price+","+Operation.medicineList[i].DateOfExpiry.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("OnlineMedical/MedicalDetails.csv",medical);

            string[] order=new string[Operation.orderList.Count];
            for(int i=0;i<Operation.orderList.Count;i++)
            {
                order[i]=Operation.orderList[i].OrderID+","+Operation.orderList[i].UserID+","+Operation.orderList[i].MedicineID+","+Operation.orderList[i].MedicineCount+","+Operation.orderList[i].TotalPrice+","+Operation.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operation.orderList[i].OrderStatus;
            }
            File.WriteAllLines("OnlineMedical/OrderDetails.csv",order);

        }

        public static void ReadFromCSV()
        {
            string[] users=File.ReadAllLines("OnlineMedical/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails user1=new UserDetails(user);
                Operation.userList.Add(user1);
            }


            string[] medicines=File.ReadAllLines("OnlineMedical/MedicalDetails.csv");
            foreach(string medicine in medicines)
            {
                MedicineDetails medicine1=new MedicineDetails(medicine);
                Operation.medicineList.Add(medicine1);
            }

            string[] orders=File.ReadAllLines("OnlineMedical/OrderDetails.csv");
            foreach(string order in orders)
            {
                OrderDetails order1=new OrderDetails(order);
                Operation.orderList.Add(order1);
            }
        }

    }
}


