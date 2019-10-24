using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_BookshopDLL
{
    public class User
    {
        public User(uint Id, string Name, string Password,
            string Email, Role Role)
        {
            this.Id = Id;
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.Role = Role;
        }
        public User(uint Id, string Name, string Password, 
            string Email) :
            this(Id, Name, Password, Email, Company.GetRole(RoleEnum.CUSTOMER))
        {
        }

        public uint Id { get; private set; }
        public string Name { get; set; }
        public string Password { get; private set; }

        private string email;
        public string Email
        {
            set
            {
                string regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                if (Regex.Match(value, regex).Success)
                    email = value;
                else throw new Exception("Invalid email");
            }
            get
            {
                return email;
            }
        }

        public void SendEmail(string subject, string message)
        {          
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("ede.troll@gmail.com");
                mail.To.Add(this.Email);
                mail.Subject = subject;
                mail.IsBodyHtml = false;
                mail.Body = message;
                mail.Attachments.Add(new Attachment("file elérési útja..."));

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ede.troll@gmail.com", "dsvdsvdsd");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
        }
        public void SendHTMLEmail(string subject, string message)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("ede.troll@gmail.com");
            mail.To.Add(this.Email);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = message;
            mail.Attachments.Add(new Attachment("file elérési útja..."));

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ede.troll@gmail.com", "dsvdsvdsd");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

        public Role Role { get; private set; }
    }
}
