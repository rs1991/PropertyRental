using System.Net.Mail;
using System.Xml.Serialization;

namespace PropertyRental
{
    public class ContactInformation
    {
       private string _phoneNumber;
       private MailAddress _email;
       
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        [XmlIgnore] /* The [XmlIgnore] attribute is applied to the Email property.
                     * This attribute tells the XmlSerializer to exclude the Email property from direct XML serialization.
                     * Instead, the email address will be serialized using a custom approach.  
                     */
        public MailAddress Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [XmlElement("SerializedEmail")]
        public string SerializedEmail
        {
            get { return _email?.Address; }
            set { _email = value != null ? new MailAddress(value) : null; }
        }


        public ContactInformation()
        {

        }
    }

   
}

