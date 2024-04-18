using System.Reflection.Metadata;

namespace AgriculturePresentation.Models
{
    public class ContactModel
    {
        public int contactId { get; set; }
        public string contactName  { get; set; }
        public string  contactMail { get; set; }
        public string  contactMessage { get; set; }
        public DateTime contactDate { get; set; }
    }
}
