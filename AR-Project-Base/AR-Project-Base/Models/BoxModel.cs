using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AR_Project_Base.Models
{
    public class BoxModel
    {
        public int BoxId { get; set; }
        public string BoxName { get; set; }
        public string BoxDescription { get; set; }
        public float Length { get; set; }
        public float Breadth { get; set; }
        public float Height { get; set; }
        public float BaseArea { get; set; }
        public float BaseVolume { get; set; }
    }
}