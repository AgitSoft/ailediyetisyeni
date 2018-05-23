using AileDiyetisyeni.Models;
using System;
using System.Web.Mvc;
namespace AileDiyetisyeni.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CallCustomers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CallCustomers(CallPeople model)
        {
            try
            {
                using (DiyetDbEntities entities = new DiyetDbEntities())
                {
                    CallPeople call = new CallPeople();

                    call.Name = model.Name;
                    call.MailAdress = model.MailAdress;
                    call.Surname = model.Surname;
                    call.Phone = model.Phone;
                    call.CreateDate = DateTime.Now;

                    entities.CallPeoples.Add(call);
                    entities.SaveChanges();

                }


            }
            catch (System.Exception)
            {

                throw;
            }

            return View();
        }



        [HttpPost]
        public ActionResult CallCustomerPartial(CallPeople model)
        {
            try
            {
                using (DiyetDbEntities entities = new DiyetDbEntities())
                {
                    CallPeople call = new CallPeople();

                    call.Name = model.Name;
                    call.MailAdress = model.MailAdress;
                    call.Surname = model.Surname;
                    call.Phone = model.Phone;
                    call.CreateDate = DateTime.Now;

                    entities.CallPeoples.Add(call);
                    entities.SaveChanges();

                }


            }
            catch (System.Exception)
            {

                throw;
            }

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}