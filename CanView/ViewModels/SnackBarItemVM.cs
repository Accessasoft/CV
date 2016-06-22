using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanView.ViewModels
{
    public class SnackBarItemVM
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public List<String> ItemSizes { get; set; }
        public List<String> ItemSizeAndPrices { get; set; }
        public string ItemDescription { get; set; }
    }
}