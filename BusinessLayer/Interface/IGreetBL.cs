using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace BusinessLayer.Interface
{
    public interface IGreetBL
    {
        //Greet AddGreet(Greet greet);
        //Greet GetGreetById(int id);
        //List<Greet> GetAllGreets();
        //Greet UpdateGreet(Greet greet);
        //bool DeleteGreet(int id);
        string GetGreeting(User user);

    }
}
