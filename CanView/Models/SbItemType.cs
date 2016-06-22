using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class SbItemType
    {
        public int SbItemTypeID { get; set; }
        public string SbItemTypeDesc { get; set; }
        public string SbItemTypeName { get; set; }
        public ICollection<SbItem> snackBarItems { get; set; }
    }
}