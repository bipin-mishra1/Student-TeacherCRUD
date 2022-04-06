using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Studentt_Teacer_Crud.Models;

    public class Subject
    {
        [Key]
        public int ID { get; set; }

        public string? Subject_Name { get; set; }

        public string? syllabus { get; set; }

        [Range(1,5)]
        public int credits { get; set; }

    }