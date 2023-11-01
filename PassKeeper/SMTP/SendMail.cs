using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper.SMTP
{
    public static class SendMail
    {
        public static void Send(string? toMail, string? vertificationCode)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("seid13463@gmail.com", "swktloogmsahqlwr"),
                EnableSsl = true,
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress("seid13463@gmail.com"),
                Subject = "F R O M   S A E D   K U R D I",
                Body = $@"<!DOCTYPE html>
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">
<head>
  <meta charset=""UTF-8"">
  <meta name=""viewport"" content=""width=device-width,initial-scale=1"">
  <meta name=""x-apple-disable-message-reformatting"">
  <title></title>
  <!--[if mso]>
  <noscript>
    <xml>
      <o:OfficeDocumentSettings>
        <o:PixelsPerInch>96</o:PixelsPerInch>
      </o:OfficeDocumentSettings>
    </xml>
  </noscript>
  <![endif]-->
  <style>
    table, td, div, h1, p {{font-family: Arial, sans-serif;}}
  </style>
</head>
<body style=""margin:0;padding:0;"">
  <table role=""presentation"" style=""width:100%;border-collapse:collapse;border:0;border-spacing:0;background:#ffffff;"">
    <tr>
      <td align=""center"" style=""padding:0;"">
        <table role=""presentation"" style=""width:602px;border-collapse:collapse;border:1px solid #cccccc;border-spacing:0;text-align:left;"">
          <tr>
            <td align=""center"" style=""padding:40px 0 30px 0;background:#70bbd9;"">
              <img src=""https://assets.codepen.io/210284/h1.png"" alt="""" width=""300"" style=""height:auto;display:block;"" />
            </td>
          </tr>
          <tr>
            <td style=""padding:36px 30px 42px 30px;"">
              <table role=""presentation"" style=""width:100%;border-collapse:collapse;border:0;border-spacing:0;"">
                <tr>
                  <td style=""padding:0 0 36px 0;color:#153643;"">
                    <h1 style=""font-size:24px;margin:0 0 20px 0;font-family:Arial,sans-serif;"">Vertification Code : {vertificationCode} </h1>
                    <p style=""margin:0 0 12px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;"">Proyektden istifade etdiyiniz ucun tesekkur edirem !</p>
                    <p style=""margin:0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;""><a href=""https://github.com/"" style=""color:#ee4c50;text-decoration:underline;"">Git-Hub hesabima daxil olub meni izleye bilersiniz</a></p>
                  </td>
                </tr>
                <tr>
                  <td style=""padding:0;"">
                    <table role=""presentation"" style=""width:100%;border-collapse:collapse;border:0;border-spacing:0;"">
                      <tr>
                        <td style=""width:260px;padding:0;vertical-align:top;color:#153643;"">
                          <p style=""margin:0 0 25px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;""><img src=""https://cloud-epoint.fra1.digitaloceanspaces.com/images/users/middle/6308cca82ac8b.png"" alt="""" width=""260"" style=""height:auto;display:block;"" /></p>
                          <p style=""margin:0 0 12px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;""></p>
                          <p style=""margin:0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;""><a href=""https://itstep.az/ru?gclid=Cj0KCQjw0vWnBhC6ARIsAJpJM6cEyBCH8AKvqigL7-QlHeHj3nr8s3H4tRUDuQH42SqpiamQfryvxEAaAhMFEALw_wcB"" style=""color:#ee4c50;text-decoration:underline;"">Step IT Site ni da izleye bilersiniz</a></p>
                        </td>
                        <td style=""width:20px;padding:0;font-size:0;line-height:0;"">&nbsp;</td>
                        <td style=""width:260px;padding:0;vertical-align:top;color:#153643;"">
                          <p style=""margin:0 0 25px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;""><img src=""https://content.linkedin.com/content/dam/brand/site/img/logo/logo-hero.png"" alt="""" width=""260"" style=""height:auto;display:block;"" /></p>
                          <p style=""margin:0 0 12px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;"">Sehifelere bas cekdiyiniz ucun tesekkurler !</p>
                          <p style=""margin:0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;""><a href=""http://linkedin.com/in/cavid-atamoglanov-4901a4137"" style=""color:#ee4c50;text-decoration:underline;"">Cavid Muellimi de izleye bilersiniz !</a></p>
                        </td>
                      </tr>
                    </table>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
          <tr>
            <td style=""padding:30px;background:#ee4c50;"">
              <table role=""presentation"" style=""width:100%;border-collapse:collapse;border:0;border-spacing:0;font-size:9px;font-family:Arial,sans-serif;"">
                <tr>
                  <td style=""padding:0;width:50%;"" align=""left"">
                    <p style=""margin:0;font-size:14px;line-height:16px;font-family:Arial,sans-serif;color:#ffffff;"">
                      &reg; Someone, Somewhere 2021<br/><a href=""http://www.example.com"" style=""color:#ffffff;text-decoration:underline;"">Unsubscribe</a>
                    </p>
                  </td>
                  <td style=""padding:0;width:50%;"" align=""right"">
                    <table role=""presentation"" style=""border-collapse:collapse;border:0;border-spacing:0;"">
                      <tr>
                        <td style=""padding:0 0 0 10px;width:38px;"">
                          <a href=""http://www.twitter.com/"" style=""color:#ffffff;""><img src=""https://assets.codepen.io/210284/tw_1.png"" alt=""Twitter"" width=""38"" style=""height:auto;display:block;border:0;"" /></a>
                        </td>
                        <td style=""padding:0 0 0 10px;width:38px;"">
                          <a href=""http://www.facebook.com/"" style=""color:#ffffff;""><img src=""https://assets.codepen.io/210284/fb_1.png"" alt=""Facebook"" width=""38"" style=""height:auto;display:block;border:0;"" /></a>
                        </td>
                      </tr>
                    </table>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
        </table>
      </td>
    </tr>
  </table>
</body>
</html>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(toMail!);
            smtpClient.Send(mailMessage);
        }
    }
}
