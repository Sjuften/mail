﻿using MailProgram.Entities.Mails;
using MailProgram.Entities.Protocols;
using MimeKit;

namespace MailProgram.Services
{
    public class MimeService : IMailService
    {
        private readonly IProtocol _client;

        private MimeMessage _emailMessage = new MimeMessage();

        public MimeService(IProtocol protocol)
        {
            _client = protocol;
        }

        public void Send(IMail mail)
        {
            _client.Send(mail);
        }
    }
}