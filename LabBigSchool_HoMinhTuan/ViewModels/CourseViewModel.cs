using LabBigSchool_HoMinhTuan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Globalization;

namespace LabBigSchool_HoMinhTuan.ViewModels
{
    public class CourseViewModel
    {
        string a = "dd/M/yyyy";
        string b = "HH:mm";
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.ParseExact(string.Format("{0} {1}", Date, Time), string.Format("{0} {1}", a,b), CultureInfo.InvariantCulture);
        }
    }
}