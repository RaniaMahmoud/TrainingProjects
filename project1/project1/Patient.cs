using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Patient:Doctor
    {
        private int id;
        private string Prescription;
        private bool reserv;
        private bool pay;
        private string name;
        private int phone;

        public Patient()
        {
            id = 0;
            Prescription = null;
            reserv = false;
            name = null;
            pay = false;
            phone = 0;
        }

        public Patient(int id,bool reserv,string name, int phone,Doctor d):base(d.Name,d.Schedule,d.DoctorSpecialty1,d.Phone,d.ClinicName1,d.Floor)
        {
            this.id = id;
            //this.Prescription = presc;
            this.reserv = reserv;
            this.name = name;
            this.phone = phone;
            //this.pay = pay;

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

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Prescription1
        {
            get
            {
                return Prescription;
            }

            set
            {
                Prescription = value;
            }
        }

        public bool Reserv
        {
            get
            {
                return reserv;
            }

            set
            {
                reserv = value;
            }
        }

        public bool Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }

        public string Reservation()
        {
            Reserv = true;
            pay = true;
            return "reserv";
        }

        public string CancelReservation()
        {
            if (Reserv == true)
            {
                Reserv = false;
                pay = false;
                return "Reserv is cancel";
            }
            else
                return "There is no reservation for this person";
        }

        public string ToString()
        {
            return "Patient Data: " + ID + " Name:" + Name + " Doctor Specialty : " + DoctorSpecialty1+ " Clinic Name : "+ClinicName1+ " Reserv: " + Reserv + " phone: " + phone + " pay: " + pay;
        }

    }
}
