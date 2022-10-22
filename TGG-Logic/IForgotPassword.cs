using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_Logic;
using TGG_Model;

namespace TGG_Logic
{
    public interface IForgotPassword
    {
        void SetController(IResetPasswordController controller);
        string InstructionsOrErrorLabel { set; }
        TGG_ResetPasswordStatus StatusPassword { set; }
        string Password { get; }
        string PasswordConfirmation { get; }
    }
}
