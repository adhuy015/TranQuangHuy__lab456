﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace TranQuangHuy__lab456.ViewModels
{
    public class FutureDate:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "dd/m/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime);
            return base.IsValid(isValid&& dateTime>DateTime.Now);
        }
    }
}