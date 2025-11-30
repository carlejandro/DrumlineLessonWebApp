using Microsoft.AspNetCore.Mvc;
using DrumlineLessonWebApp.Models;
using System.Collections.Generic;

namespace DrumlineLessonWebApp.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {

            var plans = new List<PricingOption>
{
                new PricingOption
                {
                    Title = "1 Hour",
                    Description = "Any Skill Level One hour with Me!",
                    Price = 29.99m,
                    Features = "1-Hour of Instruction on Any marching instrument",
                    IsPopular = false
                },

                new PricingOption
                {
                    Title = "30 Minutes",
                    Description = "For drummers looking to fit training in on a tight schedule.",
                    Price = 15.99m,
                    Features = "30 Minutes of instruction on Any Marching Instrument",
                    IsPopular = true
                }
            };
            return View(plans);
        }
    }
}
