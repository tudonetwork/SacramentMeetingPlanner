using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeeting.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
    }
}