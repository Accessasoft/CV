using CanView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanView.ViewModels
{
    public class SnackBarItemTypeVM
    {
        public int ID { get; set; }
        public string ItemTypeName { get; set; }
        public List<SnackBarItemVM> Item { get; set; }
       
    }
}