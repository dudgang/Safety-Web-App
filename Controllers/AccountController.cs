using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebsiteFramwork.Models;
using System.Data.SqlClient;

namespace MyWebsiteFramwork.Controllers
{
    public class AccountController : Controller
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source = DESKTOP-51T57VE; database = Account; integrated security = SSPI; ";
        }
        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from  Login where username ='"+acc.Name+"' and password ='"+acc.Password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Dashboard"); 
            }
            else
            {
                con.Close();
                return View("Register");
            }
        }

        [HttpGet]
        // GET: Createapp
        public ActionResult App()
        {
            return View();
        }

        [HttpGet]
        // GET: Createapp
        public ActionResult Register()
        {
            return View();
        }

        [HttpGet]
        // GET: Createapp
        public ActionResult Dashboard()
        {
            return View();
        }


    }
}