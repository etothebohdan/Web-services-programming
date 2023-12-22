using System;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        
        var smtpClient = new SmtpClient("smtp.example.com", 25);
        smtpClient.Credentials = new System.Net.NetworkCredential("username", "password");

        
        var mailMessage = new MailMessage();
        mailMessage.From = new MailAddress("sender@example.com");
        mailMessage.To.Add(new MailAddress("recipient@example.com"));
        mailMessage.Subject = "Subject";
        mailMessage.Body = "Body";

        
        smtpClient.Send(mailMessage);

        Console.WriteLine("Електронний лист надіслано успішно!");
    }
}

