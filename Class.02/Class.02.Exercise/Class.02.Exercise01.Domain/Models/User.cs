using Class._02.Exercise01.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._02.Exercise01.Domain.Models
{
    public abstract class User : IUser
    {
        protected int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public abstract void PrintUser();

        public User(string firstname,string lastname,string username,string password) 
        {
            Id = new Random().Next(1, 999);
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;

        }
    }
}
