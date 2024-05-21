using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CollegeDetails;

namespace Application
{
    //static class
    public static class Operations
    {
        // Local/Global Object creation
        static StudentDetails currentLoggedInStudent;
        //List Creation
       static List<StudentDetails> studentList=new List<StudentDetails>();
       static List<DepartmentDetails> departmentList=new List<DepartmentDetails>();

       static List<AdmissionDetails> admissionList=new List<AdmissionDetails>();

       public static void MainMenu()
       {
            Console.WriteLine("*************************Welcome To Syncfusion College of Engineering and Technology*************************");
            string mainChoice="yes";
            do{
            //Need to show Main Menu option
            Console.WriteLine("1.Student Registration\n2.Student Login\n3.Department wise seat availability\n4.Exit");
            //need to get input from user
            Console.Write("Select an option : ");
            int mainOption=int.Parse(Console.ReadLine());
            //Create Main Menu Structure
            switch(mainOption)
            {
               case 1:
               {
                Console.WriteLine("******************Student Registration******************");
                StudentRegistration();
                break;
               } 
               case 2:
               {
                Console.WriteLine("******************Student Login ******************");
                StudentLogin();
                break;
               }
               case 3:
               {
                Console.WriteLine("****************** Department wise seat Availability ******************");
                DeparmentWiseAvailability();
                break;
               }
               case 4:
               {
                
                Console.WriteLine("application Ended Successfully");
                mainChoice="no";
                break;
               }
            }
            //Need to Iterate until the option is 4
            }while(mainChoice=="yes");


       }//MainMenu
       public static void StudentRegistration()
       {
        // Need to get requried details
        Console.Write("Enter your Name: ");
        string name=Console.ReadLine();
        Console.Write("Enter Your Father Name: ");
        string fatherName=Console.ReadLine();
        Console.Write("Enter your Date Of Birth: ");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.Write("Enter your Gender: ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        Console.Write("Enter your Physics Mark: ");
        int physicsMark=int.Parse(Console.ReadLine());
        Console.Write("Enter your Chemistry Mark: ");
        int chemistryMark=int.Parse(Console.ReadLine());
        Console.Write("Enter Your Maths Mark: ");
        int mathsMark=int.Parse(Console.ReadLine());
        //Need to create an object
        StudentDetails student=new StudentDetails(name,fatherName,dob,gender,physicsMark,chemistryMark,mathsMark);
        //Need to add in the list
        studentList.Add(student);
        //Need to Display conformation message and ID
        Console.WriteLine($"Registration successfully completed Your ID is : {student.StudentID}");

       }//Student Registration Ended

       public static void StudentLogin()
       {
            //Need to get ID Input 
            Console.Write("Enter Your Student ID : ");
            string loginID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(StudentDetails student in studentList)
            {
                if(loginID.Equals(student.StudentID))
                {
                    flag=false;
                    //Assigning current user to global variable
                    currentLoggedInStudent=student;
                    Console.Write("Loggin Successfully");
                    //Need to call SubMenu
                    SubMenu();
                    break;
                    
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid ID");
            }

            //Validate by its Presence in the List
            //If Not -Invalid Valid

       }//Student Login
       
       //submenu
       public static void SubMenu()
       {
        string subChoice="yes";
        do
        {
            Console.WriteLine("***************Sub Menu ***************");
            //Need to show SubMenu Option
            Console.WriteLine("Select an option\n1.Check Eligibility\n2.Show Details\n3.Take Admission\n4.Cancel Admission\n5.Show Admission Details\n6.Exit");
            //Getting user Option
            Console.Write("Select your Option: ");
            int subOption=int.Parse(Console.ReadLine());
            //Need to create Sub Menu structure
            switch(subOption)
            {
                case 1:
                {
                    Console.WriteLine("************* Check Eligibility ***************");
                    CheckEligiblity();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("************* Show Details ***************");
                    ShowDetails();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("************* Take Admission ***************");
                    TakeAdmission();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("************* Cancel Admission ***************");
                    CancelAdmission();
                    break;
                }
                case 5:
                {
                    Console.WriteLine("************* Show Admission ***************");
                    ShowAdmission();
                    break;
                }
                case 6:
                {
                    Console.WriteLine("************* Taking to Main Menu ***************");
                    subChoice="no";
                    break;
                }
            }
            //Iterate till option is exit.
        }while(subChoice=="yes");
       }//Submenu ended
       public static void CheckEligiblity()
       {
        //Get the cut off Value as input
        Console.Write("Enter the cutoff Value: ");
        double cutOff=double.Parse(Console.ReadLine());
        if(currentLoggedInStudent.CheckEligiblity(cutOff))
        {
            Console.WriteLine("Student is Eligible");
        }
        else
        {
           Console.WriteLine("Student is not Eligible"); 
        }
       }//CheckEligibility

       public static void ShowDetails()
       {
        Console.WriteLine($"|{currentLoggedInStudent.StudentID}|{currentLoggedInStudent.StudentName}|{currentLoggedInStudent.FatherName}|{currentLoggedInStudent.DOB}|{currentLoggedInStudent.Gender}|{currentLoggedInStudent.Physics}|{currentLoggedInStudent.Chemistry}|{currentLoggedInStudent.Maths}|");

       }//Show Details

        public static void TakeAdmission()
        {
            //Need to show available Department
            DeparmentWiseAvailability(); 
            //Ask department ID from user
            Console.Write("Select Department ID : ");
            string departmentID=Console.ReadLine().ToUpper();
            //check the ID is present or not
            bool flag =true;
            foreach(DepartmentDetails department in departmentList)
            {
                if(departmentID.Equals(department.DepartmentID))
                {
                    flag=false;
                    //Check student is Eligible or not
                    if(currentLoggedInStudent.CheckEligiblity(75.0))
                    {
                         //Check the seat Availability
                        if(department.NumberOfSeats>0)
                        {
                            //check student already taken any admission
                            int count=0;
                            foreach(AdmissionDetails admission in admissionList)
                            {
                                if(currentLoggedInStudent.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted))
                                {
                                    count++;
                                }
                            }
                            if(count==0)
                            {
                                //create admission object
                                AdmissionDetails admissionTaken=new AdmissionDetails(currentLoggedInStudent.StudentID,department.DepartmentID,DateTime.Now,AdmissionStatus.Admitted);
                                //Reduce seat count.
                                department.NumberOfSeats--;
                                //Add to admission list
                                admissionList.Add(admissionTaken);
                                //Display Admission successful message
                                Console.WriteLine($"You have taken admission successfully.Admission ID : {admissionTaken.AdmissionID}");
                            }
                            else
                            {
                                Console.WriteLine("You Have Already taken an admission");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Seat is not available");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are Not Eligible due to low cutoff");
                    }
                    break;
                   
                    
                }
                if(flag)
                {
                    Console.WriteLine("Invalid ID");
                }
            }
            
        }//Take admission
        public static void CancelAdmission()
        {
            bool flag=true;
            //Check Student is taken any admission and display it.
            foreach(AdmissionDetails admission in admissionList)
            {
                if(currentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted))
                {
                    flag=false;
                    //Cancel the found admission
                    admission.AdmissionStatus=AdmissionStatus.Cancelled;
                    //return seat to department
                    foreach(DepartmentDetails department in departmentList)
                    {
                        if(admission.DepartmentID.Equals(department.DepartmentID))
                        {
                            department.NumberOfSeats++;
                            break;
                        }
                    }
                    break;
                }
                if(flag)
                {
                    Console.WriteLine("You have not Admission to Cancel");
                }

            }
            
        }//Cancel Admission
        public static void ShowAdmission()
        {
            Console.WriteLine("|Admission ID | Student ID |Department ID |Admission Date |Admission Status| ");   
            foreach(AdmissionDetails admission in admissionList)
        {
            if(currentLoggedInStudent.StudentID.Equals(admission.StudentID)){
            Console.WriteLine($"|{admission.AdmissionID}|{admission.StudentID}|{admission.DepartmentID}|{admission.AdmissionDate}|{admission.AdmissionStatus}|");
            }
        }

        }//show Admission
        public static void DeparmentWiseAvailability()
        {

            // Need to show all Department Seat
            Console.WriteLine($"|{"DepartmentID ",-20}| Department Name  |Number Of seats|");
            foreach(DepartmentDetails department in departmentList)
                {
                    Console.WriteLine($"|{department.DepartmentID,-13}|{department.DepartmentName,-11}|{department.NumberOfSeats,-12}|");
                }
        }//DepartmentWiseAvailability
       public static void AddDefaultData()
       {
        StudentDetails student1=new StudentDetails("Ravichandran E" , "Ettapparajan",	new DateTime(1999,11,11),Gender.Male,95,95,95);
        StudentDetails student2=new StudentDetails("Baskaran S","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
        studentList.AddRange(new List<StudentDetails>(){student1,student2});

        DepartmentDetails deparment1= new DepartmentDetails("EEE",29);
        DepartmentDetails deparment2= new DepartmentDetails("CSE",29);
        DepartmentDetails deparment3= new DepartmentDetails("MECH",30);
        DepartmentDetails deparment4= new DepartmentDetails("ECE",30);
        departmentList.AddRange(new List<DepartmentDetails>(){deparment1,deparment2,deparment3,deparment4});

        AdmissionDetails admission1=new AdmissionDetails(student1.StudentID,"DID101",new DateTime(2022,05,11),AdmissionStatus.Admitted);
        AdmissionDetails admission2=new AdmissionDetails("SSF3002",	"DID102",new DateTime(2022,05,12),AdmissionStatus.Admitted);
        admissionList.AddRange(new List<AdmissionDetails>(){admission1,admission2});


        // //Print
        // foreach(StudentDetails student in studentList)
        // {
        //     Console.WriteLine($"|{student.StudentID}|{student.StudentName}|{student.FatherName}|{student.DOB}|{student.Gender}|{student.Physics}|{student.Chemistry}|{student.Maths}|");
        // }
        // Console.WriteLine();

        // foreach(DepartmentDetails department in departmentList)
        // {
        //     Console.WriteLine($"|{department.DepartmentID}|{department.DepartmentName}|{department.NumberOfSeats}|");
        // }
        // Console.WriteLine();
        
       }


    }

}