﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWorldHub.Core.Entities.Chat
{
    public class Message : BaseEntity
    {
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string? Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
