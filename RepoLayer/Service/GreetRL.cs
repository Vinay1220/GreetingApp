using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using RepoLayer.Interface;

namespace RepoLayer.Service
{
    public class GreetRL : IGreetRL
    {
        private readonly List<Greet> _greets = new List<Greet>();
        private int _nextId = 1;

        public Greet AddGreet(Greet greet)
        {
            greet.Id = _nextId++;
            _greets.Add(greet);
            return greet;
        }

        public Greet GetGreetById(int id)
        {
            return _greets.FirstOrDefault(g => g.Id == id);
        }

        public List<Greet> GetAllGreets()
        {
            return _greets;
        }

        public Greet UpdateGreet(Greet greet)
        {
            var existing = _greets.FirstOrDefault(g => g.Id == greet.Id);
            if (existing != null)
            {
                existing.Message = greet.Message;
            }
            return existing;
        }

        public bool DeleteGreet(int id)
        {
            var greet = _greets.FirstOrDefault(g => g.Id == id);
            if (greet != null)
            {
                _greets.Remove(greet);
                return true;
            }
            return false;
        }

        public string GetSimpleGreeting()
        {
            return "Hello World";
        }
    }
}
