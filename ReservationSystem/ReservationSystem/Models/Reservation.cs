﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ReservationSystem.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }
        public string Restaurant { get; set; }
        public int PartySize { get; set; }
    }
}
