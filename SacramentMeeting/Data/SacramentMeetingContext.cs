﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SacramentMeeting.Models
{
    public class SacramentMeetingContext : DbContext
    {
        public SacramentMeetingContext (DbContextOptions<SacramentMeetingContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeeting.Models.Meeting> Meeting { get; set; }
    }
}
