using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public interface IContactDatabase
    {
        Contact Add( Contact contact );
        void DeleteContact( int id );
        Contact Get( int id );
        IEnumerable<Contact> GetAll();
        Contact Update( int id, Contact contact );
    }
}
