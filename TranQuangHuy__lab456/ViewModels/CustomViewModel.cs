﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TranQuangHuy__lab456.ViewModels
{
    public class CustomViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
    }
}