﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleParts.Models
{
    //public enum NewPartType
    //{
    //    Engine = 1,
    //    Frame,
    //    tank,
    //    Exhuast,
    //    DriveTrain,
    //    Fork,
    //    Seat
    //}
    public class PartEdit
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public string ModelNumber { get; set; }
        public string Manufacturer { get; set; }
        //public NewPartType TypeOfPart { get; set; }
    }
}
