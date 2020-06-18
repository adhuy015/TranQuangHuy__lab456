﻿using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TranQuangHuy__lab456.Models;

namespace TranQuangHuy__lab456.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        [ValidTime]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
    }
}