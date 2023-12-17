using bsGlassHouse.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace bsGlassHouse.Controllers
{
    [ApiController]
    public class AnonymousUserController : ControllerBase
    {
        // Contact Form Submission for Anonymous Users
        [HttpPost]
        [Route("api/anonymous-user/contact-form")]
        
        public async Task<IActionResult> ContactForm([FromBody] ContactForm contactForm)
        {
            var result = await Request.BodyReader.ReadAsync();

            return Ok();
        }
    }
}
