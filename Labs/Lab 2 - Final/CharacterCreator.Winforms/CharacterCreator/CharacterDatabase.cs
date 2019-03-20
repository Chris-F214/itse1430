using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class CharacterDatabase
    {
        public CharacterDatabase()
        {
            var character = new Character();
            character.Name = "dadadaad";
            character.Description = "Example";
            character.Strength = 100;
            character.Intelligence = 1;
            character.Agility = 50;
            character.Constitution = 75;
            character.Charisma = 2;
            Add(character);
        }
        public Character Add( Character character)
        {
            if (character == null)
                throw new ArgumentNullException(nameof(character));

            if (!character.Validate())
                throw new Exception("character is invalid.");

            var existing = GetIndex(character.Name);
            if (existing >= 0)
                throw new Exception("Cannot duplicate character.");

            for (var index = 0; index < _items.Length; ++index)
            {
                if (_items[index] == null)
                {
                    character.Id = ++_nextId;
                    _items[index] = Clone(character);
                    break;
                }
            }

            return character;
        }

        public Character Get (int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        private int GetIndex( int id )
        {
            for (var index = 0; index < _items.Length; ++index)
            if (_items[index]?.Id == id)
                return index;

            return -1;

        }
        private int GetIndex( string name)
        {
            for (var index = 0; index < _items.Length; ++index)
                if (String.Compare(_items[index]?.Name, name, true) == 0)
                    return index;

            return -1;
        }

        private Character Clone( Character character )
        {
            var newCharacter = new Character();
            Clone(newCharacter, character);

            return newCharacter;
        }

        private void Clone ( Character target, Character source)
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;
            target.Strength = source.Strength;
            target.Intelligence = source.Intelligence;
            target.Agility = source.Agility;
            target.Constitution = source.Constitution;
            target.Charisma = source.Charisma;
        }

        public Character Update ( int id, Character character )
        {
            var index = GetIndex(id);

            character.Id = id;
            var existing = _items[index];
            Clone(existing, character);

            return character;
        }

        public Character[] GetAll()
        {
            int count = 0;
            foreach (var item in _items)
                if (item != null)
                    ++count;
            var characterIndex = 0;
            var character = new Character[count];
            for (var index = 0; index < _items.Length; ++index)
                if (_items[index] != null)
                    character[characterIndex++] = Clone(_items[index]);

            return character;
        }

        private readonly Character[] _items = new Character[100];
        private int _nextId = 0;
    }
}
