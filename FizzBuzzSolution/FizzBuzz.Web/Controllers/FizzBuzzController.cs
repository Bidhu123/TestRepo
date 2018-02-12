using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.Business;
using FizzBuzz.Web.Models;
using PagedList;
using PagedList.Mvc;

namespace FizzBuzz.Web.Controllers
{
    public class FizzBuzzController : Controller
    {
        IFizzBuzzRepository _IFizzBuzzRepository;
        
    public FizzBuzzController(IFizzBuzzRepository IFizzBuzzRepository)
    {
            _IFizzBuzzRepository = IFizzBuzzRepository;
    }


        // GET: FizzBuzz
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FizzBuzzView()
        
        {
            return View();
        }

        [HttpPost]
        public ActionResult FizzBuzzView(FizzBuzzModel model,int ? page)
        {
                model.PageSize = 20;
                if (ModelState.IsValid)
                {
                var number = model.Number;
                for (int i = 1; i < number; i++)
                {                    
                   model.NumberList = _IFizzBuzzRepository.DisplayList(number).ToPagedList(page ?? 1,model.PageSize).ToList();
                }                                   
            }

            return View("FizzBuzzView", model);
        }
         
        }
    }

