using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace malawi_digital_health_passport
{
    class Diagnosis
    {
        public Diagnosis(string date, string patientID) {
            Date = date;
            PatientID = patientID;
        }
        private string Date { get; set; }
        private string PatientID { get; set; }
        private string Lab { get; set;}
        private string Treatment {  get; set; }
        private string Notes { get; set; }
    }
}
