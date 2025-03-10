using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using ModelLayer;
using RepoLayer.Interface;

namespace BusinessLayer.Service
{
    public class GreetBL : IGreetBL
    {
        private readonly IGreetRL _greetRL;

        public GreetBL(IGreetRL greetRL)
        {
            _greetRL = greetRL;
        }

        public Greet AddGreet(Greet greet) => _greetRL.AddGreet(greet);
        public Greet GetGreetById(int id) => _greetRL.GetGreetById(id);
        public List<Greet> GetAllGreets() => _greetRL.GetAllGreets();
        public Greet UpdateGreet(Greet greet) => _greetRL.UpdateGreet(greet);
        public bool DeleteGreet(int id) => _greetRL.DeleteGreet(id);
    }
}
