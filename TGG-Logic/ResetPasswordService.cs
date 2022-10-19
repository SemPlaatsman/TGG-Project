using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_DAL;
using TGG_Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TGG_Logic
{
    public class ResetPasswordService
    {
        private ResetPasswordDAO resetPasswordDAO;
        public ResetPasswordService()
        {
            resetPasswordDAO = new ResetPasswordDAO();
        }
        public void InsertValidationCode(TGGValidation validationUser)
        {
            resetPasswordDAO.AddValidationCodes(validationUser);

        }
    }
}
