using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class SbItem_Item_ItemSize
    {
        public int SbItem_Item_ItemSizeID { get; set; }
        public string SbItem_Item_SizePrice { get; set; }
        public SbItem SbItem_Item { get; set; }
        public SbItemSize SbItem_Size { get; set; }
    }
}