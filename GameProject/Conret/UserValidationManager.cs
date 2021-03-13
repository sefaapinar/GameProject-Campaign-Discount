using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(User user)
        {
            //if (user.BirthYear == 2000 && user.FirstName =="Sefa" && user.LastName=="Pınar" && user.IdentityNumber==121321321321)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return true;
        }
    }
}
