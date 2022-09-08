using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using WebGentle.BookStore.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using WebGentle.BookStore.Repository;

namespace WebGentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewBookAlertConfig _newBookAlertconfiguration;
        private readonly NewBookAlertConfig _thirdPartyBookconfiguration;
        private readonly IMessageRepository _messageRepository;

        public HomeController(IOptionsSnapshot<NewBookAlertConfig> newBookAlertconfiguration, IMessageRepository messageRepository)
        {
            _newBookAlertconfiguration = newBookAlertconfiguration.Get("InternalBook");
            _thirdPartyBookconfiguration = newBookAlertconfiguration.Get("ThirdPartyBook");
            _messageRepository = messageRepository;
        }
        public ViewResult Index()
        {
            bool isDisplay = _newBookAlertconfiguration.DisplayNewBookAlert;
            bool isDisplay1 = _thirdPartyBookconfiguration.DisplayNewBookAlert;
            //var value = _messageRepository.GetName();
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
