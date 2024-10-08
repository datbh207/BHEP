﻿using BHEP.Contract.Abstractions.Message;

namespace BHEP.Contract.IntergrationEvents;

public static class Command
{
    public record class SendNotification : INotification
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public Guid TransactionId { get; set; }
    }
}
