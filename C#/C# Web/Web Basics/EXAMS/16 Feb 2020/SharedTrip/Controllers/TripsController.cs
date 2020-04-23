using SharedTrip.Services;
using SharedTrip.ViewModels.TripViews;
using SIS.HTTP;
using SIS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedTrip.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITripsService tripsService;

        public TripsController(ITripsService tripsService)
        {
            this.tripsService = tripsService;
        }


        [HttpGet]
        public HttpResponse All()
        {
            return this.View();
        }

        [HttpGet]
        public HttpResponse Add()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Add(TripInputModel tripInputModel)
        {
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("Users/Login");
            }

            if (tripInputModel.Seats < 2 || tripInputModel.Seats > 6)
            {
                return this.View();
            }

            if (tripInputModel.Description.Length > 80)
            {
                return this.View();
            }

            var tripId = this.tripsService.Add(tripInputModel);

            return this.Redirect($"/Trips/Details?tripId={tripId}");
        }

        public HttpResponse Details(string tripId)
        {
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var trip = this.tripsService.GetById(tripId);

            return this.View(trip);
        }

        //[HttpPost]
        //public HttpResponse Details()
        //{
        //    return this.View();
        //}

    }
}
