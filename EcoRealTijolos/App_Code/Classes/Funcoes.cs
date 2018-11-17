using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using EcoRealTijolos.App_Code.Classes;

namespace EcoRealTijolos.App_Code.Classes
{
    public class Funcoes
    {

        public static void enviaEmail(string from, string to, string subject, string body)
        {
            MailMessage msgMail = new MailMessage();

            msgMail.To.Add(new MailAddress(to));
            msgMail.From = new MailAddress(from);
            msgMail.Subject = subject;

            msgMail.IsBodyHtml = true;
            msgMail.Body = body;

            SmtpClient client = new SmtpClient();
            client.Send(msgMail);
        }



        public static string HashTexto(string texto, string nomeHash)
        {
            HashAlgorithm algoritmo = HashAlgorithm.Create(nomeHash);
            if (algoritmo == null)
            {
                throw new ArgumentException("Nome de hash incorreto", "nomeHash");
            }
            byte[] hash = algoritmo.ComputeHash(Encoding.UTF8.GetBytes(texto));
            return Convert.ToBase64String(hash);

        }


    }

}
