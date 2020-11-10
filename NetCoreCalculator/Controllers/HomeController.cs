using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreCalculator.Models;

namespace NetCoreCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index( Operation model )
        {
            switch(model.OperationType)
            {
                case OperationType.Addition:
                    model.Result = model.NumberA + model.NumberB;
                    break;
                case OperationType.Multiplication:
                    model.Result = model.NumberA * model.NumberB;
                    break;
                case OperationType.Subtraction:
                    model.Result = model.NumberA - model.NumberB;
                    break;
                case OperationType.Division:
                    model.Result = model.NumberA / model.NumberB;
                    break;


            }
            return View( model );
        }
    }
}