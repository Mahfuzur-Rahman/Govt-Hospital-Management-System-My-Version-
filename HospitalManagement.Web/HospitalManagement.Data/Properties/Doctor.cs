﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Data
{
    public class Doctor
    {
        [Key]
       public int Id { get; set; }

        
        [Required]
        public string DoctorName { get; set; }
        public int age { get; set; }

        public string Contact { get; set; }
        public string ContactNo { get; set; }
        public string ContactEmail { get; set; }

        public string Departments { get; set; }
        public string Departmentslist { get; set; }
        public string Degrees { get; set; }

        public string SurgeryOrMedicine { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoinningDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime RetireDate { get; set; }

        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

    }
}