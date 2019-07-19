using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AuthorizationCenter.Filters;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using MIS2020.Models;

namespace MIS2020.Controllers
{
    public class HomeController : Controller
    {
        private readonly Bom2013Context Bom2013Context;
        private readonly IEngRepository engRepository;
        private readonly IRightRepository rightRepository;
        private readonly IFavoriteFormRepository favoriteFormRepository;
        private readonly IRepository<FormGroup> formGroupRepository;
        private readonly IRepository<Tuser> tuserRepository;
        private readonly IRepository<UserBehaviorLog> userBehaviorLogRepository;

        public HomeController(

            IEngRepository engRepository,
            IRepository<Tuser> tuserepository,
            Bom2013Context Bom2013Context,
            IRightRepository rightRepository,
            IFavoriteFormRepository favoriteFormRepository,
            IRepository<FormGroup> formGroupRepository,
            IRepository<UserBehaviorLog> userBehaviorLogRepository

            )
        {

            this.favoriteFormRepository = favoriteFormRepository;
            this.engRepository = engRepository;
            this.userBehaviorLogRepository = userBehaviorLogRepository;
            this.formGroupRepository = formGroupRepository;
            this.tuserRepository = tuserepository;
            this.Bom2013Context = Bom2013Context;
            this.rightRepository = rightRepository;

        }
       
        public IActionResult Index()
        {
            var eng = engRepository.Get();
            return View(eng);
        }

        public IActionResult _EngListPartial()
        {
            var eng = this.engRepository.Get();

            return PartialView("~/Views/Shared/List/_EngListPartial.cshtml", eng);

        }
        [AuthenticatedFilter]
        public IActionResult Privacy()

        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
