﻿using System;

namespace Ada.Hotel.Reservations.Events
{
    public class RoomsReserved
    {
        public readonly Guid ReservationId;
        public readonly DateTime CheckInDate;
        public readonly DateTime CheckoutDate;
        public readonly Guid RoomTypeId;
        public readonly string GuestId;
        public readonly int NoOfUnits;

        public RoomsReserved(Guid reservationId, DateTime checkInDate, DateTime checkoutDate, Guid roomTypeIdId, string guestId, int noOfUnits)
        {
            ReservationId = reservationId;
            GuestId = guestId;
            RoomTypeId = roomTypeIdId;
            CheckoutDate = checkoutDate;
            CheckInDate = checkInDate;
            NoOfUnits = noOfUnits;
        }

    }
}
