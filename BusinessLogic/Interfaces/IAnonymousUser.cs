using bsGlassHouse.Models.Request;

namespace bsGlassHouse.BusinessLogic.Interfaces
{
    public interface IAnonymousUser
    {
        Task ProcessAnonymousContactForm(ContactForm contactForm);
    }
}
