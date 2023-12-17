using bsGlassHouse.Data_Models.Enums;

namespace bsGlassHouse.Models.Request
{
    /// <summary>
    /// a contact form submission from an anonymous user
    /// </summary>
    public class ContactForm
    {
        //public Guid Guid { get;} = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string QueryMessage { get; set; }
        public GlassWorkType GlassWorkType { get; set;}      
    }
}
