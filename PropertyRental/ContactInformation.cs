using System.Net.Mail;

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

        public MailAddress Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }

   
}

