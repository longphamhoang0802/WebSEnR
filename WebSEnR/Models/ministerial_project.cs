﻿using System.ComponentModel.DataAnnotations;

namespace WebSEnR.Models
{
    public class ministerial_project
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string member { get; set; }
        public string href { get; set; }
    }
}
