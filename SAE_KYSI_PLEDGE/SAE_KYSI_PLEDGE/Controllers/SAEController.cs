﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAE_KYSI_PLEDGE.ViewModels;
using SAE_CORE;
using SAE_DAL;

namespace SAE_KYSI_PLEDGE.Controllers
{
    public class SAEController : Controller
    {
        SAE_DB _context = new SAE_DB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateClass()
        {
            ViewBag.Message = "Create Pledge Class";
         
            return View();
        }

        public ActionResult CreatePledge()
        {
            ViewBag.Message = "Create Pledge";

            return View();
        }

        public ActionResult EditPledge()
        {
            ViewBag.Message = "Edit Pledge";
            
            return View();
        }

        public ActionResult EditClass()
        {
            
            return View();
        }


        public ActionResult DropDownList(string type, string selected)
        {
            var query = new EditClassViewModel(from context in _context.PLEDGE_CLASS
                                               select new DropdownListItem { Text = context.PLEDGE_CLASS_NAME, Value = context.PLEDGE_CLASS_NAME }).ClassList();
            return PartialView("EditClassPartialView", query);

        }


        //public List<SelectListItem> GetClasses()
        //{
        //    SAE_DB _context = new SAE_DB();

        //    var query = from context in _context.PLEDGE_CLASS
        //                orderby context.PLEDGE_CLASS_NAME ascending
        //                select context.PLEDGE_CLASS_NAME;

        //    Classes = (List<SelectListItem>)query;

        //    return Classes;
        //}


        public ActionResult ManagePoints()
        {
            ViewBag.Message = "Manage Points";

            return View();
        }

    }
}
