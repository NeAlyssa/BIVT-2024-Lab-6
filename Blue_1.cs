using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_1
    {
        public struct Response
        {
            //pola
            private string _name;
            private string _surname;
            private int _votes;

            //svoystva
            public string Name => _name;
            public string Surname => _surname;
            public int Votes => _votes;

            //konstructor
            public Response(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _votes = 0;
            }

            //metod
            public int CountVotes(Response[] responses)
            {
                //_votes = 0;
                if (responses == null || responses.Length == 0) return 0;
                foreach (Response response in responses)
                {
                    if (response.Name == _name && response.Surname == _surname) _votes++;

                }
                
                return _votes;
            }
            public void Print()
            {
                Console.WriteLine($"Имя: {Name}");
                Console.WriteLine($"Фамилия: {Surname}");
                Console.WriteLine($"Количество голосов: {Votes}");
            }

        }
        
    }
}
