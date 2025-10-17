using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clinical_Project.Models
{
    internal class PatientRecordsModel
    {
        [Key]
        public int RecordID { get; set; }

        [Required]
        
        public int PatientID { get; set; }

        [Required]
        public int DoctorID { get; set; }

        public string DataRecorded { get; set; }
        public string MedicalHistory { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime? FollowUpDate
        {
            get; set;
        }
        [Url]
        public  string AttachtmentURL { get; set; }
    }
}
