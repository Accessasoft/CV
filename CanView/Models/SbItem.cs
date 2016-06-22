using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class SbItem
    {
        public int SbItemID { get; set; }
        public string SbItemName { get; set; }
        public string SbItemDesc { get; set; }
        public bool SbItemIsMultiSize { get; set; }
        public string SbItemPrice { get; set; }
        public virtual SbItemType snackBarItemType { get; set;}
        public virtual ICollection<SbItem_Item_ItemSize> snackBarItemSize { get; set; }
    }
}