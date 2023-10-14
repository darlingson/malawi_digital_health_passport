using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace malawi_digital_health_passport
{
    class Patient
    {
        private string patientName;
        private string patientId;
        private string dob;
        private string location;
        private string sex;
        private string city;
        private string country;
        private string TA;
        private string village;
        public Patient() { }

        //getter methods
        public string getPatientName()
        {
            return patientName;
        }
        public string getPatientID()
        {
            return patientName;
        }
        public string getPatientDOB()
        {
            return patientName;
        }
        public string getPatientLocation()
        {
            return patientName;
        }
        public string getPatientSex()
        {
            return patientName;
        }
        public string getPatientCity()
        {
            return patientName;
        }
        public string getPatientCountry()
        {
            return patientName;
        }
        public string getPatientTA()
        {
            return patientName;
        }
        public string getPatientVillage()
        {
            return patientName;
        }

        //setter methods
        public void setPatientName(string name)
        {
            this.patientName = name ;
        }
        public void setPatientID(string ID)
        {
            this.patientId = ID;
        }
        public void setPatientDOB(string DOB)
        {
            this.dob = DOB;
        }
        public void setPatientLocation(string Location)
        {
            this.location = Location;
        }
        public void setPatientSex(string Sex)
        {
            this.sex = Sex;
        }
        public void setPatientCity(string City)
        {
            this.city = City;
        }
        public void setPatientCountry(string Country)
        {
            this.country = Country;
        }
        public void setPatientTA(string TA)
        {
            this.TA = TA;
        }
        public void setPatientVillage(string Village)
        {
            village = Village;
        }
    }
}
