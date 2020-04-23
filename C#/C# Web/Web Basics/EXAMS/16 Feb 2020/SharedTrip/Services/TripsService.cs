﻿using SharedTrip.Models;
using SharedTrip.ViewModels.TripViews;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SharedTrip.Services
{
    public class TripsService : ITripsService
    {
        private readonly ApplicationDbContext db;

        public TripsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public string Add(TripInputModel tripInputModel)
        {
            var date = tripInputModel.DepartureTime;
            var dateAsString = DateTime.ParseExact(date, @"dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);

            var trip = new Trip()
            {
                StartPoint = tripInputModel.StartPoint,
                EndPoint = tripInputModel.EndPoint,
                DepartureTime = dateAsString,
                ImagePath = tripInputModel.ImagePath,
                Seats = tripInputModel.Seats,
                Description = tripInputModel.Description

            };

            this.db.Trips.Add(trip);
            this.db.SaveChanges();

            return trip.Id;
        }

        public IEnumerable<Trip> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Trip GetById(string tripId)
        {
            var trip = this.db.Trips.FirstOrDefault(x => x.Id == tripId);

            return trip;
        }
    }
}
