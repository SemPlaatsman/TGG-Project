using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_Logic;
using TGG_Model;

namespace TGG_Logic
{
    public interface IResetPasswordController
    {
        void SendValidationEmail(string email);
        void ConfirmCode(string email, string validation);
        void UpdatePassword();

    }
}
