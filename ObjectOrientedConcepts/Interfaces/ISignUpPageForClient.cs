using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ISignUpPageForClient
    {
        bool PasswordVerificationLogic(string password);
        bool IsUsernameAvailable(string username);
    }
}
