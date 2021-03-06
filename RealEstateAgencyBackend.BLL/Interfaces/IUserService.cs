﻿using Microsoft.AspNet.Identity;
using RealEstateAgencyBackend.BLL.DTO;
using System.Collections.Generic;
using System.Security.Claims;

namespace RealEstateAgencyBackend.BLL.Interfaces
{
    public interface IUserService
    {
        IdentityResult Create(CreateUserDto user);

        IdentityResult Delete(string id);


        UserDto Find(string userName, string password);

        UserDto FindById(string id);

		IEnumerable<UserDto> GetAll();

		bool IsUserExist(string userName);

        string GetUserId(string userName);

        ClaimsIdentity CreateIdentity(string userName, string password, string authenticationTypes);


        IEnumerable<RentalAnnouncementReservationDto> GetRentalAnnouncements(string userId);

        IEnumerable<RentalRequestDto> GetRentalRequests(string userId);

        IEnumerable<RentalAnnouncementReservationDto> GetReservations(string userId);


        bool ReserveAnnouncement(int announcementId, string userId);

        void CompliteReservation(int announcementId, string userId);

		void RejectReservation(int announcementId, string ownerId);

		void ConfirmReservation(int announcementId, string userId);

        void DeleteReservation(int announcementId, string userId);
    }
}
