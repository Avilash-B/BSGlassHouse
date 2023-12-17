using bsGlassHouse.BusinessLogic.Interfaces;
using bsGlassHouse.Models.Request;

namespace bsGlassHouse.BusinessLogic
{
    public class AnonymousUser : IAnonymousUser
    {
        public async Task ProcessAnonymousContactForm(ContactForm contactForm)
        {
            throw new NotImplementedException();
        }
  

    }
}
