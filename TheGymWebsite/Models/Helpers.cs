using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace TheGymWebsite.Models
{
    public class Email
    {
        public static void Send(string email, string subject, string message)
        {
            // Setting up the email message.
            MimeMessage emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("thesuperiorman007@gmail.com"));
            emailMessage.To.Add(new MailboxAddress(email));
            emailMessage.Subject = subject;
            // The email message is set to plain, ie, no attachments, etc.
            emailMessage.Body = new TextPart("plain")
            {
                Text = message
            };

            using (SmtpClient client = new SmtpClient())
            {
                // Connecting to client.
                client.Connect("smtp.gmail.com", 587, false);

                // Google blocks access from less secure devices by default. Change this setting on this link:
                // https://myaccount.google.com/lesssecureapps 
                client.Authenticate("thesuperiorman007@gmail.com", "facebook.com");
                client.Send(emailMessage);
                client.Disconnect(true);
            }
        }
    }

    public class UserAge
    {
        public static int GetAge(DateTime dateOfBirth)
        {
            int age; ;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }

    public class Expiry
    {
        public static DateTime GetExpiryDate(Enums.MembershipDuration duration)
        {
            DateTime today = DateTime.Now;

            switch (duration)
            {
                case Enums.MembershipDuration.OneDay:
                    return today.AddDays(1);
                case Enums.MembershipDuration.OneWeek:
                    return today.AddDays(8);
                case Enums.MembershipDuration.TwoWeeks:
                    return today.AddDays(15);
                case Enums.MembershipDuration.OneMonth:
                    return today.AddMonths(1);
                case Enums.MembershipDuration.TwoMonth:
                    return today.AddMonths(2);
                case Enums.MembershipDuration.ThreeMonths:
                    return today.AddMonths(3);
                case Enums.MembershipDuration.FourMonths:
                    return today.AddMonths(4);
                case Enums.MembershipDuration.SixMonths:
                    return today.AddMonths(6);
                case Enums.MembershipDuration.OneYear:
                    return today.AddYears(1);
                case Enums.MembershipDuration.TwoYears:
                    return today.AddYears(2);
                case Enums.MembershipDuration.Unlimited:
                    return DateTime.MaxValue;
                default:
                    return DateTime.MinValue;
            }
        }
    }
}






