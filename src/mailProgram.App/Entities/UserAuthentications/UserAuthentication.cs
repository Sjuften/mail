﻿namespace MailProgram.Entities.UserAuthentications
{
    public class UserAuthentication : IUserAuthentication
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}