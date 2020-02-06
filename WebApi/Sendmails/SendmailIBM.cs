using Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Sendmails
{
    public class SendmailIBM
    {
        public void SendMailIBM(string mailTo, List<string> mailCC, string mailTitle, string IDyc, string date, string username, string mbody)
        {
            try
            {

                NotesSession nSession = new NotesSession();
                nSession.Initialize("12345678");
                NotesDatabase nDatabase = nSession.GetDatabase("meiko_notes_hanoi2/SOUMU", "mail\\hrsystem.nsf");
                NotesDocument nDocument = nDatabase.CreateDocument();
                string[] recipients =
                  {"tu.nguyenduy/SOUMU", "duytu89@gmail.com"};

                nDocument.ReplaceItemValue("Form", "Memo");
                nDocument.ReplaceItemValue("SentTo", recipients); //To field
                nDocument.ReplaceItemValue("Subject", "Message subject"); //message subject
                nDocument.ReplaceItemValue("Body", "Something in the message body"); //set body text
                nDocument.SaveMessageOnSend = true;//save message after it's sent
                nDocument.Send(false, recipients); //send
            }
            catch
            {

            }
        }
    }
}
