﻿using RealEstateAgencyBackend.DAL.Contexts;
using RealEstateAgencyBackend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RealEstateAgencyBackend.DAL.Repositories
{
    public class RentalAnnouncementRepository : IRentalAnnouncementRepository
    {
        private AppDbContext _context;

        public RentalAnnouncementRepository(AppDbContext context)
        {
            _context = context;
        }

        public RentalAnnouncement Create(RentalAnnouncement item)
        {
            return _context.RentalAnnouncements.Add(item);
        }

        public RentalAnnouncement Remove(int id)
        {
            RentalAnnouncement announcement = _context.RentalAnnouncements.Find(id);
            if (announcement != null)
            {
                if (announcement.Reservations != null)
                {
                    _context.Reservations.RemoveRange(announcement.Reservations);
                }
                announcement = _context.RentalAnnouncements.Remove(announcement);
            }
            return announcement;
        }

        public RentalAnnouncement Find(int id)
        {
            return _context.RentalAnnouncements.Find(id);
        }

        public IQueryable<RentalAnnouncement> GetAll()
        {
            return _context.RentalAnnouncements;
        }

        public IEnumerable<RentalAnnouncement> FindByUserId(string userID)
        {
            return _context.RentalAnnouncements.Where(announcement => announcement.UserId == userID);
        }

        public RentalAnnouncement Update(RentalAnnouncement item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
