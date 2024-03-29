﻿using COMP123_S2019_A5_301045531.Models;
using COMP123_S2019_A5_301045531.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301045531
{
    public static class Program
    {
        // static members
        public static Dictionary<FormName, Form> Forms;
        public static Product Product;
        public static ProductInfoForm productInfoForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiating forms in dictionary
            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.ABOUT_FORM, new AboutForm());
            Forms.Add(FormName.SPLASH_FORM, new SplashForm());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectForm());

            // instantiating product info form differently as was unable to access OpenSavedOrder method of
            // productInfoForm in startForm using dictionary
            productInfoForm = new ProductInfoForm();

            //Forms.Add(FormName.PRODUCTINFO_FORM, new ProductInfoForm());

            Forms.Add(FormName.ORDER_FORM, new OrderForm());

            Product = new Product();

            Application.Run(Forms[FormName.SPLASH_FORM]);
        }
    }
}
