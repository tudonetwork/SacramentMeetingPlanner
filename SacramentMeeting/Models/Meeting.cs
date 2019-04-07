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
        public string Speaker1 { get; set; }
        public string Topic1 { get; set; }
        public string Speaker2 { get; set; }
        public string Topic2 { get; set; }
        public string Speaker3 { get; set; }
        public string Topic3 { get; set; }
    }
}

