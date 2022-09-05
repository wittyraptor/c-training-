using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorMangementSytem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            
            List<Doctor> doctors = new List<Doctor>();
            while (flag)
            {
                Console.WriteLine(" ====== welcome ======= \n 1-> Enter Doctor details \n " +
                    "2-> Display Doctor details \n 3->exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                Doctor d = new Doctor();

                

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Reg No:");
                        string registrationNo = Console.ReadLine();
                        if (validateDoctor.validateReg(registrationNo))
                        {
                            d.registrationNo = registrationNo;
                        }
                        else
                        {
                            throw new RegException("Enter 7 digits only");
                        }


                        
                        Console.WriteLine("Doctor name:");
                        string doctorName = Console.ReadLine();
                        if (validateDoctor.validateName(doctorName))
                        {
                            d.doctorName = doctorName;
                        }
                        else
                        {
                            throw new NameException("only alphabets allowed");
                        }

                        Console.WriteLine("City:");
                        d.city = Console.ReadLine();


                        Console.WriteLine("Area of Specialization:");
                        string areaOfSepecialization = Console.ReadLine();
                        if (validateDoctor.validateAoS(areaOfSepecialization))
                        {
                            d.areaOfSepecialization = areaOfSepecialization;
                        }
                        else
                        {
                            throw new AoSException("only alphabets allowed");
                        }
                        Console.WriteLine("Clinic address:");
                        d.clinicAddress = Console.ReadLine();


                        Console.WriteLine("Clinic timings");
                        string clinicTime = Console.ReadLine();
                        if (validateDoctor.validateTime(clinicTime))
                        {
                            d.clinicTime = clinicTime;
                        }
                        else
                        {
                            throw new timeException("proper time");
                        }

                        Console.WriteLine("Contact No");
                        string contactNo = Console.ReadLine();
                        if (validateDoctor.validateContact(contactNo))
                        {
                            d.contactNo = contactNo;
                        }
                        else{
                            throw new ContactException("only 10 digits allowed");
                        }

                        doctors.Add(d);

                        break;
                    case 2:
                        foreach(var item in doctors)
                        {
                            Console.WriteLine(" ** doctor details **");
                            Console.WriteLine("Reg Number: "+ item.registrationNo);
                            Console.WriteLine("Name: "+item.doctorName);
                            Console.WriteLine("City: "+item.city);
                            Console.WriteLine("AoS: "+item.areaOfSepecialization);
                            Console.WriteLine("Address: "+item.clinicAddress);
                            Console.WriteLine("Time: "+item.clinicTime);
                            Console.WriteLine("Contact Number: "+item.contactNo);
                        }
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

