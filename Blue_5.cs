using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_5;

namespace Lab_6
{
    public class Blue_5
    {
        public struct Sportsman
        {
            private string _name;
            private string _surname;
            private int _place;

            public string Name => _name;
            public string Surname => _surname;
            public int Place => _place;

            public Sportsman(string name,string surname)
            {
                _name = name;
                _surname = surname;
                _place = 0;
            }

            public void SetPlace(int place)
            {
                if (_place < 0) return;
                if (_place != 0) return;//in case this place was already taken
                _place = place;
            }
            public void Print()
            {
                Console.WriteLine($"{Name} {Surname}: {Place}");
            }
        }

        public struct Team
        {
            private string _name;
            private Sportsman[] _sportsman;
            private int _counter;
            public string Name => _name;
            public Sportsman[] Sportsmen => _sportsman;
                ////77777
            
            public int SummaryScore
            {
                get
                {
                    if (_sportsman == null || _sportsman.Length == 0) return 0;
                    int total = 0;
                    for(int i = 0; i < _sportsman.Length; i++)
                    {
                        switch (_sportsman[i].Place)
                        {
                            case 1: total += 5; break;
                            case 2: total += 4; break;
                            case 3: total += 3; break;
                            case 4: total += 2; break;
                            case 5: total += 1; break;
                            default: break;
                        }
                    }
                    return total;
                }
            }

            public int TopPlace
            {
                get
                {
                    if (_sportsman == null) return 0;///
                    int best = 18;
                    for(int i = 0; i < _sportsman.Length; i++)
                    {
                        if((_sportsman[i].Place < best) && (_sportsman[i].Place>0)) best = _sportsman[i].Place;//
                    }
                    return best;
                }
            }

            public Team(string name)
            {
                _name = name;
                _sportsman = new Sportsman[6];
                _counter = 0;
            }

            public void Add(Sportsman newsportsman)
            {
                if (_sportsman == null) return;///
                if (_counter < _sportsman.Length)
                {
                    _sportsman[_counter++] = newsportsman;
                }
                else return;///
            }

            public void Add(Sportsman[] newsportsman)
            {
                if (_sportsman.Length == 0 || newsportsman.Length == 0 || _counter >= _sportsman.Length || _sportsman == null || newsportsman == null) return;
                int k_new = 0;
                while ((_counter < _sportsman.Length) && (k_new < newsportsman.Length))
                {
                    _sportsman[_counter] = newsportsman[k_new];
                    _counter++;
                    k_new++;
                }
            }

            public static void Sort(Team[] teams)
            {
                if (teams.Length == 0 || teams == null) return;
                for (int i = 1, j = 2; i < teams.Length;)
                {
                    if (i == 0 || teams[i - 1].SummaryScore > teams[i].SummaryScore || (teams[i - 1].SummaryScore == teams[i].SummaryScore) && teams[i - 1].TopPlace <= teams[i].TopPlace) { i = j; j++; }
                    else
                    {
                        Team t = teams[i];
                        teams[i] = teams[i - 1];
                        teams[i - 1] = t;
                        i--;
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($"Команда {Name} с результатом {SummaryScore} заняла {TopPlace} место");
            }
        }

    }
    
}
