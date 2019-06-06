using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;
using Xamls.Models;

namespace Xamls.Data
{
   public class ContactDatabase
    {
        private SQLiteConnection database;

        static object locker = new object();

        public ContactDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Contact>();
        }

        public IEnumerable<Contact> saveContact(Contact contact ) {
            return (from c in database.Table<Contact>()
                    select c).ToList();
        }



    }
}
