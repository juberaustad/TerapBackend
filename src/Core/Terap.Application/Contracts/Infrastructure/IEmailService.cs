using Terap.Application.Models.Mail;
using System.Threading.Tasks;

namespace Terap.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
