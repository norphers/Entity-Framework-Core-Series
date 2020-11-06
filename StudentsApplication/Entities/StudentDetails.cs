﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class StudentDetails
    {
        [Column("StudentDetailsId")]
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string AdditionalInformation { get; set; }

        //One-to-One relationship
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
