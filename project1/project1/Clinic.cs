using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Clinic
    {
        private int floor;
        private string ClinicName;
        private double RevealInvoice;
        public Clinic()
        {
            floor = 0;
            ClinicName = null;
        }
        public Clinic(string clinicName, int floor)
        {
            this.floor = floor;
            ClinicName = clinicName;
        }
        public int Floor
        {
            get
            {
                return floor;
            }

            set
            {
                floor = value;
            }
        }

        public string ClinicName1
        {
            get
            {
                return ClinicName;
            }

            set
            {
                ClinicName = value;
            }
        }

        public double RevealInvoice1
        {
            get
            {
                return RevealInvoice;
            }

            set
            {
                RevealInvoice = value;
            }
        }

        //public bool Reservation(string name, int phone ,string prescription,int id)
        //{
        //    this.ID = id;
        //    this.Name = name;
        //    this.Phone = phone;
        //    this.Prescription1 = prescription;
        //    Reserv = true;
        //    return Reserv;
        //}

        //public string CancelReservation()
        //{
        //    if (Reserv != true)
        //    {
        //        Reserv = false;
        //        return "Reserv is cancel";
        //    }
        //    else
        //        return "There is no reservation for this person";
        //}

        public string ToString()
        {
            return "Hospital Clinics: Floor:" + Floor + " " + ClinicName1 + " RevealInvoice " + RevealInvoice;
        }
    }
}
