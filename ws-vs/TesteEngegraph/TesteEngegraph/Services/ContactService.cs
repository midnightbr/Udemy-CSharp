using System.Collections.Generic;
using System.Linq;
using TesteEngegraph.Database;
using TesteEngegraph.Models;

namespace TesteEngegraph.Services
{
    public class ContactService : IContactService
    {
        private readonly DataContext _context;

        public ContactService(DataContext data)
        {
            _context = data;
        }

        public List<Contact> GetAll()
        {
            return _context.Contacts.ToList();
        }

        public Contact Insert(Contact contato)
        {
            _context.Contacts.Add(contato);
            _context.SaveChanges();

            return contato;
        }
    }
}
