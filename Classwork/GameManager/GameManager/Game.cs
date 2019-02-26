using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    /// <summary>Represents a game </summary>
    public class Game
    {
        //Ctors

        //Default, no return type
        // 1) Cannot be called directly
        // 2) Errors are very bad
        // 3) Should behave no different than doing it manually
        public Game()
        {
            //Complex init
            var x = 1 + 2;
        }

        //Constructor chaining
        public Game ( string name ) : this(name, 0)
        {
            //uName = name;
        }

        //As soon as you define a ctor, no default ctor anymore
        public Game ( string name, decimal price )//: this()
        {
            Name = name;
            Price = price;
        }
        /// <summary>Name of the game</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        private string _name = "";

        /// <summary>Publisher of the game</summary>
        public string Publisher
        {
            get { return _publisher ?? ""; }
            set { _publisher = value; }
        }
        private string _publisher = "";

        //Calculated property
        public bool IsCoolGame
        {
            get { return Publisher != "EA"; }
        }

        //Setter only
        //public string Password
        //{
        //    set { }
        //}

        //auto property
        public decimal Price { get; set; }
        //public decimal price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}
        //private decimal _price;

        public bool Owned { get; set; } = true;
        // public bool Owned
        // {
        //     get { return _owned; }
        //     set { _owned = value; }
        // }
        // private bool _owned;

        public bool Completed { get; set; }
        //public bool Completed
        //{
        //    get { return _completed; }
        //    set { _completed = value; }
        //}
        //private bool _completed;

        //mixed accessibility
        public double Rate
        {
            get;
            internal set;
        }

        public void Foo()
        {
            //NOT DETERMINISTIC should have been a method
            var now = DateTime.Now;
        }

        public override string ToString()
        {
            return Name;
        }

        //Can init the data as well
        //public string [] Genres { get; set; }
        //Don't use array properties because they require cloning
        //and are inefficient
        //public string [] Genres
        //{
        //    get 
        //    {
        //        var temp = new string[_genres.Length];
        //        Array.Copy(_genres, temp, _genres.Length);
        //        return temp;
        //    }
        //}
        //private string[] _genres;
        //public string[] genres = new string[10];
        //private decimal realPrice = Price;

        /// <summary>Validates the object</summary>
        /// <returns></returns>
        public bool Validate(/* Game this*/)
        {
            //Redundant
            //var str = this.Name;

            //Name is required
            if (String.IsNullOrEmpty(Name))
                return false;
            //Price >= 0
            if (Price < 0)
                return false;
            //Only if you need to pass the instance to somebody else
            //MyType.Foo(this);

            return true;
        }
    }
}
