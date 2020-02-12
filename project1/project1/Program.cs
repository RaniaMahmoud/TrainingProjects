using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int read;
            bool r;
            string name;
            int numPhone;
            int count = 5;
            int Prescription;
            int patientID;
            List<Clinic> clinic = new List<Clinic>
            {
                new Clinic("Dental Clinic",1),
                new Clinic("Orthopedic clinic",2),
                new Clinic("Brain and Nerve Clinic",3),
                new Clinic("Eye clinic",4),
                new Clinic("Physiotherapy clinic",5)
            };

            List<Doctor> doctor = new List<Doctor>
            {
                new Doctor("Mahmoud","from sun to we from 10Am to 5PM","Dental",01234567895,"Dental Clinic",1),
                new Doctor("Ahmed","from sun to we from 10Am to 5PM","Orthopedic",01234567895,"Orthopedic clinic",2),
                new Doctor("Hany","from sun to we from 10Am to 5PM","Brain",01234567895,"Brain and Nerve Clinic",3),
                new Doctor("Fahmy","from sun to we from 10Am to 5PM","Eye",01234567895,"Eye clinic",4),
                new Doctor("Mai","from sun to we from 10Am to 5PM","Physiotherapy",01234567895,"Physiotherapy clinic",5)
            };

            List<Patient> patient = new List<Patient>
            {
                new Patient(1,true,"Mahmoud",01234567895,new Doctor("Mahmoud","from sun to we from 10Am to 5PM","Dental",01234567895,"Dental Clinic",1)),
                new Patient(2,true,"hala",01234567895,new Doctor("Ahmed","from sun to we from 10Am to 5PM","Orthopedic",01234567895,"Orthopedic clinic",2)),
                new Patient(3,true,"hamed",01234567895,new Doctor("Hany","from sun to we from 10Am to 5PM","Physiotherapy",01234567895,"Physiotherapy clinic",5))
            };
            do
            {
                WriteLine("*if you want detail about clinic press 1");
                WriteLine("*if you want detail about Doctors press 2");
                WriteLine("*if you want detail about Petient press 3");
                WriteLine("*if you want to reserve in clinic press 4");
                WriteLine("*if you want to cancel reservation press 5");
                WriteLine("*if you want close press 0");
                r = int.TryParse(ReadLine(), out read);
                if (r)
                {
                    switch (read)
                    {
                        case 1:
                            foreach(Clinic c in clinic)
                            {
                                WriteLine(c.ToString());

                            }
                            WriteLine();
                            WriteLine();
                            break;
                        case 2:
                            foreach (Doctor d in doctor)
                            {
                                WriteLine(d.ToString());

                            }
                            WriteLine();
                            WriteLine();
                            break;
                        case 3:
                            foreach (Patient pa in patient)
                            {
                                WriteLine(pa.ToString());
                            }
                            WriteLine();
                            WriteLine();
                            break;
                        case 4:
                            Patient p;
                            Doctor cl = new Doctor();
                            WriteLine("Patient Name :");
                            name = ReadLine();
                            WriteLine("Clinic Floor : ");
                            bool e = int.TryParse(ReadLine(), out Prescription);
                            if (e)
                            {
                                foreach (Doctor d in doctor)
                                {
                                    if (d.Floor == Prescription)
                                    {
                                        cl = d;
                                    }

                                }
                            }
                            else
                            {
                                while (!e)
                                {
                                    WriteLine("Clinic Floor : ");
                                    e = int.TryParse(ReadLine(), out Prescription);
                                }

                                foreach (Doctor d in doctor)
                                {
                                    if (d.Floor == Prescription)
                                    {
                                        cl = d;
                                    }

                                }
                            }

                            WriteLine("Patient phone Number :");
                            bool n = int.TryParse(ReadLine(), out numPhone);
                            if (n)
                            {
                                p = new Patient(count++, false, name, numPhone, cl);
                                patient.Add(p);
                            }
                            else
                            {
                                while (!n)
                                {
                                    WriteLine("Patient phone Number :");
                                    n = int.TryParse(ReadLine(), out numPhone);
                                }
                                p = new Patient(count++, false, name, numPhone, cl);
                                patient.Add(p);
                            }

                            WriteLine(p.Reservation());
                            WriteLine();
                            WriteLine();
                            break;
                        case 5:
                            WriteLine("Patient ID :");
                            bool x = int.TryParse(ReadLine(), out patientID);
                            if (x)
                            {
                                foreach(Patient pat in patient)
                                {
                                    if (patientID == pat.ID)
                                    {
                                        WriteLine(pat.CancelReservation());
                                    }
                                }
                            }
                            else
                            {
                                while (!x)
                                {
                                    WriteLine("Patient ID :");
                                    x = int.TryParse(ReadLine(), out patientID);
                                }
                                foreach (Patient pat in patient)
                                {
                                    if (patientID == pat.ID)
                                    {
                                        WriteLine(pat.CancelReservation());
                                    }
                                }
                            }
                            WriteLine();
                            WriteLine();
                            break;
                        default:
                            WriteLine("Error!!!!!");
                            WriteLine();
                            WriteLine();
                            break;
                    }
                }
            } while (read != 0);
            WriteLine("\n*******Programe Close*******");
        }
    }
}
