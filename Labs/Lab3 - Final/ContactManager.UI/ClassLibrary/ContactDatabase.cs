﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ContactDatabase : IContactDatabase
    {
        public ContactDatabase()
        {
            var contacts = new[]
            {
                new Contact() {Name = "Support", Email = "probablywontrespond@nowhere.com"}
            };

            foreach (var contact in contacts)
                Add(contact);
        }

        public Contact Add (Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            new InputValidator().Validate(contact);

            var existing = GetIndex(contact.Name);
            if (existing >= 0)
                throw new Exception("Contact must be unique.");

            contact.Id = ++_nextId;
            _items.Add(Clone(contact));

            return contact;
        }

        public void Delete(int id)
        {
            if (id <= 0)
                    throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                _items.RemoveAt(index);
        }

        public Contact Get( int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        public IEnumerable<Contact> GetAll()
        {
            var cont = new List<Contact>();
            foreach (var item in _items)
                cont.Add(Clone(item));

            return cont.ToArray();
        }

        public Contact Update (int id, Contact contact)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            new InputValidator().Validate(contact);

            var index = GetIndex(id);
            if (index < 0)
                throw new Exception("Contact doesn't exist.");

            var existingIndex = GetIndex(contact.Name);
            if (existingIndex >= 0 && existingIndex != index)
                throw new Exception("Contact must be unique.");

            contact.Id = id;
            var existing = _items[index];
            Clone(existing, contact);

            return contact;
        }

        private int GetIndex( int id)
        {
            for (var index = 0; index < _items.Count; ++index)
                if (_items[index]?.Id == id)
                    return index;

            return -1;
        }

        private int GetIndex(string name)
        {
            for (var index = 0; index < _items.Count; ++index)
                if (String.Compare(_items[index]?.Name, name, true) == 0)
                    return index;

            return -1;
        }

        private Contact Clone (Contact contact)
        {
            var newContact = new Contact();
            Clone(newContact, contact);

            return newContact;
        }

        private void Clone (Contact target, Contact source)
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Email = source.Email;
        }

        private readonly List<Contact> _items = new List<Contact>();

        private int _nextId = 0;

    }
}
