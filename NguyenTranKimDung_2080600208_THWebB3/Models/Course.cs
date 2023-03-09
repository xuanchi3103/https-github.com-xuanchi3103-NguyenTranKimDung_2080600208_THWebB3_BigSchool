﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenTranKimDung_2080600208_THWebB3.Models
{
    public class Course
    {
        public int ID { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerID { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryID { get; set; }
    }
}