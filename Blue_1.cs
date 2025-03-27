using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_1
    {
        public struct Response
        {
            private string _name;
            private string _surname;
            private int _votes;


            public string Name => _name;
            public string Surname => _surname;
            public int Votes => _votes;


            public Response(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _votes = 0;
            }


            public int CountVotes(Response[] responses)
            {
                if (responses == null || responses.Length == 0) return 0;
                for (int i = 0;  i < responses.Length; i++)
                {
                    if (responses[i].Name == _name && responses[i].Surname == _surname) _votes++;
                }
                return _votes;
            }


            public void Print()
            {
                Console.WriteLine($"Кандидат: {Name} {Surname}, Голосов: {Votes}");
            }
        }


    }
}
