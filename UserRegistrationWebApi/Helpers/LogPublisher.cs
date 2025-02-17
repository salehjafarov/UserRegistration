﻿using Microsoft.Extensions.Options;
using RabbitMq.Events;
using RabbitMq.RabbitMq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistrationWebApi.Helpers
{
    public class LogPublisher : ProducerBase<ConsoleLogEvent>
    {
        public override string Exchange => "";

        public override string RoutingKey => "Logs";

        public override QueueOptions QueueOptions => new QueueOptions()
        {

            Queue = "Logs",
            AutoDelete = false,
            Durable = false,
            Exclusive = false
        };

        public LogPublisher(IOptions<RabbitMqOptions> opts) : base(opts)
        {

        }

        
    }
}
