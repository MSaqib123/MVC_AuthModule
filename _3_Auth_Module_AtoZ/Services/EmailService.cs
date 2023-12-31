﻿using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace _3_Auth_Module_AtoZ.Services
{
    public class EmailService
    {
        //_______________ Confirm Email ________________
        public async Task SendConfirmationEmail(string email, string confirmationLink)
        {
            // Configure Gmail SMTP settings
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("m43577535@gmail.com", "cmtahcoveejodpqs"),
                EnableSsl = true
            };

            // Create the email message
            var mailMessage = new MailMessage
            {
                From = new MailAddress("m43577535@gmail.com"),
                To = { new MailAddress(email) },
                Subject = "Email Confirmation",
                Body = $"Please confirm your email address by clicking the following link: {confirmationLink}"
            };

            // Send the email
            await smtpClient.SendMailAsync(mailMessage);
        }

        //_______________ Reset, Forget Email ________________
        //For forget , Rest   Email send will be same
        public async Task SendPasswordResetEmail(string email, string resetLink)
        {
            // Configure Gmail SMTP settings
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("m43577535@gmail.com", "cmtahcoveejodpqs"),
                EnableSsl = true
            };

            // Create the email message
            var mailMessage = new MailMessage
            {
                From = new MailAddress("m43577535@gmail.com"),
                To = { new MailAddress(email) },
                Subject = "Password Reset",
                Body = $"Please reset your password by clicking the following link: {resetLink}"
            };

            // Send the email
            await smtpClient.SendMailAsync(mailMessage);
        }


    }
}
