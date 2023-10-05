using CRUD_2023.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_2023.DAL
{
    internal class LoginDAL
    {
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            if (loginDTO.User == "Rafael" && loginDTO.Secret == "0205")
            {
                return true;
            }
            return false;
        }
    }
}
