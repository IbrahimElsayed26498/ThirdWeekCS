// In the name of Allah, the Gracious, the Merciful
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class User
    {

        // constructor chaining
        public User()
        {

        }

        public User(string name)
        {
            this.Name = name;
        }

        public User(string name, string job) : this(name)
            
        {
            this.Job = job;
        }

        public User(string name, string job, string phone) : this(name, job)

        {
            this.Phone = phone;
        }

        public User(string name, string job, string phone, string address) : this(name, job, phone)
        {
            this.Address = address;
        }

        public User(string name, string job, string phone, string address, string email) : this(name, job, phone, address)
        {
            this.Email = email;
        }

        public User(string name, string job, string phone, string address, string email, string password) 
            : this(name, job, phone, address, email)
        {
            this.Password = password;
        }

        // properties
        public string Name { get; set; }
        public string Job { get; set; }
        public string Phone{ get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Name : {0}\nJob : {1}\nPhone : {2}\nAdress : {3}\nEmail : {4}\nPassWord : {5}\n",
                Name, Job, Phone, Address, Email, Password);
        }
    }
}
