using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class SbItemSize
    {
        public int SbItemSizeID { get; set; }
        public string SbItemSizeDesc { get; set; }        
        public virtual ICollection<SbItem_Item_ItemSize> SbItems { get; set; }
    }
}