﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;
using System.Web.Mvc;
using MVCBog.Models;
using System.Net;
using System.Threading.Tasks;

namespace MVCBog.Controllers
{
    public class AboutusController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }


    }
    }
