using System;
using System.Collections.Generic;
using System.Text;
using Xamls.Data;
using Xamls.Models;

namespace Xamls.ViewModels
{
    public class ContactListViewModel
    {
        public List<Contact> Contacts { get; set; }

        public ContactListViewModel()
        {
            Contacts = new List<Contact>();
            var listOfContacts = new List<Contact>();
            listOfContacts = ContactGenerator.CreateContacts();
            Contacts = listOfContacts;
        }

    }
}
