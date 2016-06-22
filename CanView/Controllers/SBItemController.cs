using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CanView.Models;
using CanView.ViewModels;

namespace CanView.Controllers
{
    public class SnackBarsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationDbContext db2 = new ApplicationDbContext();
        // GET: SnackBars
        public ActionResult Index()
        {
            //ViewData["SnackBarTypes"] = db.snackbarItemsTypes.ToList();
            //ViewData["Drinks"] = db.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == 2);
            //ViewData["Drink Sizes"] = db.snackBarItemsSizes.Where(a => a.SbItemSizeID == 1).Where(b => b.SbItemSizeID == 3).Where(c => c.SbItemSizeID == 4);
            //ViewData["Popcorn"] = db.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == 3);
            //ViewData["Nachos"] = db.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == 4);
            //ViewData["Pretzels"] = db.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == 5);
            //ViewData["Grill Food"] = db.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == 6);
            //ViewData["Frozen Treats"] = db.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == 7);
            //ViewData["Candy"] = db.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == 8);
            //ViewData["Combos"] = db.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == 9);
            //ViewData["Confections"] = db.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == 10);
            GenerateSnackBarItemPanel();
            //PopulateAssignedSizes();
            return View();
        }

        public void GenerateSnackBarItemPanel()
        {
            var listOfAllItems = new List<SnackBarItemTypeVM>();            
            var type = db.snackbarItemsTypes.ToList();
            foreach (var t in type)
            {
                int numOfItems = 0;
                var TypesWithItems = new SnackBarItemTypeVM();
                TypesWithItems.Item = new List<SnackBarItemVM>();
                TypesWithItems.ID = t.SbItemTypeID;
                TypesWithItems.ItemTypeName = t.SbItemTypeName;
                var dbItemResults = db2.snackBarItems.Where(i => i.snackBarItemType.SbItemTypeID == TypesWithItems.ID);
                foreach (SbItem i in dbItemResults)
                {
                    if (i.snackBarItemSize != null)
                    {
                        numOfItems = i.snackBarItemSize.Count();
                    }                  

                    SnackBarItemVM item = new SnackBarItemVM();
                    item.ItemName = i.SbItemName;
                    item.ItemDescription = i.SbItemDesc;
                    item.ItemSizes = new List<string>();
                    item.ItemSizeAndPrices = new List<string>();
                    if (!i.SbItemIsMultiSize)
                    {
                        for(var c = 0; c <3; c++)
                        {
                            item.ItemSizes.Add("!");                           
                        }
                        item.ItemSizeAndPrices.Add(i.SbItemPrice);
                        TypesWithItems.Item.Add(item);
                    }
                    else
                    {
                        int counter = 0;
                        SnackBarItemVM item2 = new SnackBarItemVM();
                        item2.ItemName = i.SbItemName;
                        item2.ItemDescription = i.SbItemDesc;
                        item2.ItemSizes = new List<string>();
                        item2.ItemSizeAndPrices = new List<string>();
                        if (numOfItems < 3)
                        {
                            counter = 3 - numOfItems;
                            foreach (var s in i.snackBarItemSize)/*.Where(size=>size.SbItem_Item.SbItemID == i.SbItemID))*/
                            {
                                //item2.ItemSizes.Add(s.SbItem_Size.SbItemSizeDesc);
                                //item2.ItemSizeAndPrices.Add(s.SbItem_Size.SbItemSizeDesc + " $" + s.SbItem_Item_SizePrice + " ");
                                item2.ItemSizes.Add("Fucker");
                                item2.ItemSizeAndPrices.Add("Shits");
                                counter++;
                            }
                            while(counter < 3)
                            {
                                item2.ItemSizes.Add("!");
                            }
                            TypesWithItems.Item.Add(item2);
                        }
                        else
                        {
                            SnackBarItemVM item3 = new SnackBarItemVM();
                            item3.ItemName = i.SbItemName;
                            item3.ItemDescription = i.SbItemDesc;
                            item3.ItemSizes = new List<string>();
                            item3.ItemSizeAndPrices = new List<string>();
                            foreach (var s in i.snackBarItemSize)
                            {
                                //item3.ItemSizes.Add(s.SbItem_Size.SbItemSizeDesc);
                                item3.ItemSizes.Add("Fuck");
                                //item3.ItemSizeAndPrices.Add(s.SbItem_Size.SbItemSizeDesc + " $" + s.SbItem_Item_SizePrice + " ");
                                item3.ItemSizeAndPrices.Add("Shit");
                            }
                            TypesWithItems.Item.Add(item3);
                        }
                    }               
                }
            listOfAllItems.Add(TypesWithItems);
            }
            ViewBag.allItems = listOfAllItems;
            //ViewBag.allItems = TypesWithItems;
        }

        // GET: SnackBars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SbItem snackBar = db.snackBarItems.Find(id);
            if (snackBar == null)
            {
                return HttpNotFound();
            }
            return View(snackBar);
        }

        // GET: SnackBars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SnackBars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] SbItem snackBar)
        {
            if (ModelState.IsValid)
            {
                db.snackBarItems.Add(snackBar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(snackBar);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //GenerateTypesForDDL();
            SbItem sbItem = db.snackBarItems.Find(id);
            if (sbItem == null)
            {
                return HttpNotFound();
            }
            PopulateAssignedSizes(sbItem);
            return View(sbItem);
        }

        // POST: SbItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SbItemID,SbItemName,SbItemDesc,SbItemIsMultiSize,SbItemPrice")] SbItem sbItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sbItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sbItem);
        }

        // GET: SnackBars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SbItem snackBar = db.snackBarItems.Find(id);
            if (snackBar == null)
            {
                return HttpNotFound();
            }
            return View(snackBar);
        }

        // POST: SnackBars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SbItem snackBar = db.snackBarItems.Find(id);
            db.snackBarItems.Remove(snackBar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //public void GenerateTypesForDDL()
        //{
        //    var itemTypes =  db.snackbarItemsTypes;
        //    //List<KeyValuePair<int, string>> listOfPairs = new List<KeyValuePair<int, string>>();
        //    List<SelectListItem> listOfValues = new List<SelectListItem>();
        //    foreach(var it in itemTypes)
        //    {
        //        //KeyValuePair<int, string> KVPtems = new KeyValuePair<int, string>(it.SbItemTypeID, it.SbItemTypeName);
        //        //listOfPairs.Add(KVPtems);       
        //        SelectListItem i = new SelectListItem();
        //        i.Value = it.SbItemTypeID;
        //        i.Text = it.SbItemTypeName;
        //        listOfValues.Add((SelectListItem)it.SbItemTypeName);     
        //    }
        //    //SelectList itemtypeSelectList = new SelectList(listOfPairs, "Key", "Value");
        //    SelectListItem itemtypeSelectList = new SelectListItem(listOfValues);
        //    ViewBag.KVPItemType = itemtypeSelectList;
        //}

        public void PopulateAssignedSizes(SbItem size)
        {
            var allRole = db.snackBarItemsSizes.OrderBy(s=>s.SbItemSizeDesc);
            //var aSize = new HashSet<int>(size.snackBarItemSize.Select(r => r.SbItem_Size.SbItemSizeID));
            var viewModel = new List<SizeVM>();
            foreach (var s in allRole)
            {                
                    viewModel.Add(new SizeVM
                    {
                        SizeID = s.SbItemSizeID,
                        SizeName = s.SbItemSizeDesc,
                        //SizeAssigned = aSize.Contains(s.SbItemSizeID)
                    });
             }            
             ViewBag.SizeList = viewModel;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
