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

            var characters = new Character[]
            {

            };

            foreach (var character in characters)
                Add(character);
            
        }

        public Character Add (Character character)
        {
            if (character == null)
                throw new ArgumentNullException(nameof(character));

            if (!character.Validate())
                throw new Exception("Character is invalid.");

            var existing = GetIndex(character.Name);
            if (existing >= 0)
                throw new Exception("Game must be unique.");

            character.Id = ++_nextId;
            _items.Add(Clone(character));

            return character;
        }

        private int GetIndex( string name )
        {
            for (var index = 0; index < _items.Count; ++index)
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

        public Character[] GetAll()
        {
            var charact = new List<Character>();
            foreach (var item in _items)
                charact.Add(Clone(item));

            return charact.ToArray();
        }

        private void Clone(Character target, Character source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;
            target.Profession = source.Profession;
            target.Race = source.Race;
            target.Strength = source.Strength;
            target.Intelligence = source.Intelligence;
            target.Agility = source.Agility;
            target.Constitution = source.Constitution;
            target.Charisma = source.Charisma;
        }

        public Character Update ( int id, Character character)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be >0.");
            if (character == null)
                throw new ArgumentNullException(nameof(character));
            if (!character.Validate())
                throw new Exception("Character is invalid");

            var index = GetIndex(id);
            if (index < 0)
                throw new Exception("Character unavailable.");

            var existingIndex = GetIndex(character.Name);
            if (existingIndex >= 0 && existingIndex != index)
                throw new Exception("Character must be unique.");

            character.Id = id;
            var existing = _items[index];
            Clone(existing, character);

            return character;
        }

        private int GetIndex( int id)
        {
            for (var index = 0; index < _items.Count; ++index)
                if (_items[index]?.Id == id)
                    return index;
            return -1;
        }

        public void Delete ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                _items.RemoveAt(index);
        }

        private readonly List<Character> _items = new List<Character>();
        private int _nextId = 0;
    }
}
