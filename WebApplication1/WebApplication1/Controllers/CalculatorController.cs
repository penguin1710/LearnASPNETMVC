﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/
        public ActionResult Index()
        {
            return View();
        }

        public string ShowAuthor()
        {
            return "HNTN";
        }

        public double Factorial(int n)
        {
            double f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
	}
}