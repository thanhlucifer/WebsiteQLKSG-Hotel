﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS.Models
{
    public class GoiDichVuModel
    {
        public IEnumerable<tblDichVu> dsDichVu { get; set; }
        public IEnumerable<tblDichVuDaDat> dsDvDaDat { get; set; }
    }
}