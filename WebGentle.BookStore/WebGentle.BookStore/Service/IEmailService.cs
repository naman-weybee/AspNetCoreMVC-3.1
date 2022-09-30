using System.Threading.Tasks;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmailOptions);
        Task SendEmailConfirmation(UserEmailOptions userEmailOptions);
    }
}