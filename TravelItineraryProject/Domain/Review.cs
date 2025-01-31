using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TravelItineraryProject.Domain
{
    public class Review : BaseDomainModel
    {
        public int ReviewId { get; set; } // PK


        public int? Rating { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string? Comment { get; set; }
        public bool ApprovedByStaff { get; set; }

        public int ItineraryId { get; set; } // Fk
        public Itinerary? Itinerary { get; set; } // Nav
        public int UserId { get; set; } // Fk
        public Customer? User { get; set; } // Nav
        public int StaffId { get; set; } // FK
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Staff? Staff { get; set; } // Nav

    }
}
