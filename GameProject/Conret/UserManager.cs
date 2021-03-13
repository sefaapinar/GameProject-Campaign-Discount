using GameProject.Adapters;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserManager : IUserService
        
    {
        ////IUserValidation _userValidation;

        ////public UserManager(IUserValidation userValidation)
        ////{
        ////    _userValidation = userValidation;
        ////}

        //////MicroService dışarıdan gelen servislerdir.
        ////public void Add(User user)
        ////{
        ////    if (_userValidation.Validate(user)==true)
        ////    {
        ////        Console.WriteLine("User Registered.");
        ////    }
        ////    else
        ////    {
        ////        Console.WriteLine("Registration Failed.");
        ////    }

        ////}
        MernisServiceAdapter _mernisServiceAdapter;

        public UserManager()
        {
        }

        public UserManager(MernisServiceAdapter mernisServiceAdapter)
        {
            _mernisServiceAdapter = mernisServiceAdapter;
        }
        public void Add(User user)
        {
            if (_mernisServiceAdapter.Validate(user) == true)
            {
                Console.WriteLine("Information Added");
            }
            else
            {
                Console.WriteLine("Try Again");
            }
            
        }

        public void Delete(User user)
        {
            Console.WriteLine("Information Updated.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Information Deleted.");
        }

        internal void Add(UserManager users1)
        {
            throw new NotImplementedException();
        }
    }
}
