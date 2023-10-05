using CRUD_2023.DAL;
using CRUD_2023.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_2023.BLL
{
    internal class LoginBLL
    {
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            LoginDAL loginDAL = new LoginDAL();
            bool retorno = loginDAL.GetLoginDAL(loginDTO);

            if (retorno)
            {
                return true;
            }
            return false;
        }
    }
}
