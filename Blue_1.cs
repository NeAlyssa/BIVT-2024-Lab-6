using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_1
    {
        public struct Response
        {
            //поля
            private string _name;
            private string _surname;
            private int _votes;
            //свойства
            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int Votes { get { return _votes; } }
            //конструктор 
            public Response (string name, string surname)
            {
                _name = name;
                _surname = surname;
                _votes = 0;
            }
            //методы
            public int CountVotes(Response[] responses)
            {
                if (responses == null || responses.Length == 0) return 0;
                for (int i = 0; i < responses.Length; i++)
                {
                    if (responses[i].Name == _name && responses[i].Surname == _surname) _votes++;
                }
                return _votes;
            } 
            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {_votes}");
            }
        }
    }
}
