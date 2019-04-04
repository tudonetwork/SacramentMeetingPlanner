using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeeting.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
        public string Conducting { get; set; }
        public string Presiding { get; set; }
        //prayers
        public string Invocation { get; set; }
        public string Benediction { get; set; }
        //songs
        public int OpeningHymn { get; set; }
        public int SacramentHymn { get; set; }
        public int ClosingHymn { get; set; }
        //speakers and topics
        public ICollection<Speaker> Speakers { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}

