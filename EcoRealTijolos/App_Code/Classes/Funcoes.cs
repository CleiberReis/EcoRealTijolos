using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace EcoRealTijolos.App_Code.Classes
{
    public class Funcoes {
        
        

        /// <summary>
        /// Método enviar e-mail
        /// </summary>
        /// <param name="smtp"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="priority"></param>
        /// 
        



        public static string corpoEmail(string conteudo)
        {
            
            string corpo_email = "";
            return corpo_email;
        }

        public static string enviaEmail(string smtp, string from, string to, string subject, string body, bool priority)
        {
            try
            {
                SmtpClient  smtpClient = new SmtpClient();
                smtpClient.Host = smtp;
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("ecoreal925@gmail.com", "Projeto@Eco_Re@l1000!201120182210");
                

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(to));
                
                mail.Subject = subject;
                mail.Body = body;
                mail.BodyEncoding = Encoding.UTF8;
                mail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

                if (priority == false)
                {
                    mail.Priority = MailPriority.Normal;
                }
                else
                {
                    mail.Priority = MailPriority.High;
                }

                smtpClient.Send(mail);
            }
            catch (SmtpFailedRecipientException ex)
            {
                Console.WriteLine("Mensagem : {0} " + ex.Message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Mensagem SMPT Fail : {0} " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensagem Exception : {0} " + ex.Message);
            }

            string mensagem = "E-mail enviado";
            return mensagem;
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

