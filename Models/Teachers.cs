using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Studentt_Teacer_Crud.Models;

    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Subject")]
        [Display(Name="Subject")]

        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

    }
