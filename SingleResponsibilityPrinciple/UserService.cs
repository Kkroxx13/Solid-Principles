using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace SingleResponsibilityPrinciple
{
    public class UserService
    {
        public void Register(string email , string password)
        {
            var emailService = new EmailService();
            if (!emailService.ValidateEmail(email))
            {
                throw new ValidationException("Email not found!!");
            }
            var user = new User(email, password);
        }
        public void Login(string email,string password)
        {
            Console.WriteLine("Login");
        }

      
    }
}
