using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactManager.Models;

namespace ContactManager.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
            {
                new Contact()
                {
                    Id = 1,
                    Name = "Test1"
                },
                new Contact()
                {
                    Id = 2,
                    Name = "Test2"
                },
                new Contact()
                {
                    Id = 3,
                    Name = "Test3"
                }
            };
        }
    }
}