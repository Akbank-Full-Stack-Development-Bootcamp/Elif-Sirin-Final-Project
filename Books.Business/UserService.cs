﻿using Books.DataAccess.Repositories;
using Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books.Business
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository )
        {
            this.userRepository = userRepository;
        }
        public User GetUser(string userName, string password)
        {
            return userRepository.GetWithCriteria(x => x.Email == userName && x.Password == password).FirstOrDefault();


        }
    }
}
