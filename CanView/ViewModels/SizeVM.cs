using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanView.ViewModels
{
    public class SizeVM
    {      
            public int SizeID { get; set; }
            public string SizeHexKey { get; set; }
            public string SizeName { get; set; }
            public bool SizeAssigned { get; set; }
     }
}