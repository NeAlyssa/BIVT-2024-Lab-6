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
                int k = 0;
                if (responses.Length == 0 || responses == null) return 0;
                foreach (Response response in responses)
                {
                    if ((response.Name == _name) && (response.Surname == _surname)) { k++; }
                }
                _votes = k;
                return _votes;
            }

            public void Print()
            {
                Console.WriteLine($"{Name} {Surname}: {Votes}");
            }
        }

    }
}
