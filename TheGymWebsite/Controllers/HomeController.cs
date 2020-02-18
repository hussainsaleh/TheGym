using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheGymWebsite.Models;
using TheGymWebsite.ViewModels;
using static TheGymWebsite.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TheGymWebsite.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IGymRepository gymRepository;
        private readonly IOpenHoursRepository openHoursRepository;
        private readonly IVacancyRepository vacancyRepository;
        private readonly IFreePassRepository freePassRepository;
        private readonly IWebHostEnvironment env;
        private readonly IMembershipDealRepository dealRepository;

        public HomeController(IGymRepository gymRepository, IOpenHoursRepository openHoursRepository,
            IVacancyRepository vacancyRepository, IFreePassRepository freePassRepository, IWebHostEnvironment env,
            IMembershipDealRepository dealRepository)
        {
            this.gymRepository = gymRepository;
            this.openHoursRepository = openHoursRepository;
            this.vacancyRepository = vacancyRepository;
            this.freePassRepository = freePassRepository;
            this.env = env;
            this.dealRepository = dealRepository;
            this.gymRepository = gymRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OpenHours()
        {
            List<OpenHours> openHours = openHoursRepository.GetAllOpenHours().ToList();

            return View(openHours);
        }

        [HttpGet]
        [RequireHttps]
        public IActionResult FreePass()
        {
            return View();
        }

        [HttpPost]
        [RequireHttps]
        public IActionResult FreePass(FreePassViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Adding entry to database.
                FreePass freePass = new FreePass { Name = model.Name, Email = model.Email, DateIssued = model.DateIssued, DateUsed = null };
                freePassRepository.Add(freePass);

                // Getting the Id of the free pass. This will be sent to the user as the pass code.
                int freePassId = freePassRepository.GetFreePassId(freePass.Email);

                string subject = "Your Day Pass number";
                string message = $"Hello {freePass.Name}. Your pass number is: {freePassId}.";
                Email.Send(env.IsDevelopment() ? "thesuperiorman007@gmail.com" : model.Email, subject, message);

                return RedirectToAction(nameof(ConfirmFreePass), "Home", model.Name);
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult ConfirmFreePass(string name)
        {
            ViewBag.Name = name;

            return View();
        }

        [HttpGet]
        public IActionResult MembershipDeals()
        {
            IEnumerable<MembershipDeal> membershipDeals = dealRepository.GetAllMembershipDeals();

            return View(membershipDeals);
        }

        [HttpGet]
        public IActionResult Vacancies()
        {
            IEnumerable<Vacancy> vacancies = vacancyRepository.GetAllVacancies();

            return View(vacancies);
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            // Hard-coding the id value 1 because this application is only serving one gym at the initial stage.
            Gym gym = gymRepository.GetGym(1);

            ContactUsViewModel model = new ContactUsViewModel
            {
                GymId = gym.Id,
                GymName = gym.GymName,
                GymEmail = gym.Email,
                GymAddressLineOne = gym.AddressLineOne,
                GymAddressLineTwo = gym.AddressLineTwo,
                GymTown = gym.Town,
                GymPostCode = gym.Postcode,
                GymTelephone = gym.Telephone
            };


            return View(model);
        }

        [HttpPost]
        public IActionResult ContactUs(ContactUsViewModel model)
        {
            if (ModelState.IsValid)
            {
                string subject = "A message from website visitor";
                string message = $"Name: {model.Name}\nEmail: {model.Email}\n\nSubject: {model.Subject}\n{model.Message}\n\nSent on: {DateTime.Now}.";

                Email.Send("thesuperiorman007@gmail.com", subject, message);

                return RedirectToAction(nameof(ConfirmContactUs), "Home", model.Name);
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult ConfirmContactUs(string name)
        {
            ViewBag.Name = name;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}