using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IOptionsMonitor<NewBookAlertConfig> _newBookAlertConfigconfiguration;

        public MessageRepository(IOptionsMonitor<NewBookAlertConfig> newBookAlertConfigconfiguration)
        {
            _newBookAlertConfigconfiguration = newBookAlertConfigconfiguration;
        }
        public MessageRepository()
        {

        }
        public string GetName()
        {
            return _newBookAlertConfigconfiguration.CurrentValue.BookName;
        }
    }
}
