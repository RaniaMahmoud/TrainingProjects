using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Doctor:Clinic
    {
        private string schedule;
        private string DoctorSpecialty;
        private string name;
        private int phone;

        public Doctor()
        {
            schedule = null;
            DoctorSpecialty = null;
            name = null;
            phone = 0;

        }

        public Doctor(string name,string schedule, string special,int phone ,string ClinicName,int f):base(ClinicName, f)
        {
            this.schedule = schedule;
            this.DoctorSpecialty = special;
            this.name = name;
            this.phone = phone;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Schedule
        {
            get
            {
                return schedule;
            }

            set
            {
                schedule = value;
            }
        }

        public string DoctorSpecialty1
        {
            get
            {
                return DoctorSpecialty;
            }

            set
            {
                DoctorSpecialty = value;
            }
        }

        public string ToString()
        {
            return "Hospital Clinics: " + ClinicName1 + " Floor:" + Floor + " \n" +
                "Clinic Doctor:" + Name + " Phone:" + Phone + " DoctorSpecialty:" + DoctorSpecialty + " schedule:" + schedule;
        }
    }
}
