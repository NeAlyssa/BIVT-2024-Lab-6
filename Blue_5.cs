using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _place = 0;
            }

            public void SetPlace(int place)
            {
                if (_place != 0) return;
                _place = place;
            }

            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {_place}");
            }
        }


        public struct Team
        {
            private string _name;
            private Sportsman[] _sportsmen;
            private int _cnt;

            public string Name => _name;
            public Sportsman[] Sportsmen
            {
                get
                {
                    if (_sportsmen == null) return null;
                    return _sportsmen;
                }
            }
            public int SummaryScore
            {
                get
                {
                    int sum = 0;
                    if (_sportsmen == null) return 0;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        if (_sportsmen[i].Place == 1) sum += 5;
                        if (_sportsmen[i].Place == 2) sum += 4;
                        if (_sportsmen[i].Place == 3) sum += 3;
                        if (_sportsmen[i].Place == 4) sum += 2;
                        if (_sportsmen[i].Place == 5) sum += 1;
                    }
                    return sum;
                }
            }

            public int TopPlace
            {
                get
                {
                    if (_sportsmen == null) return 18;
                    int max = 18;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        if (_sportsmen[i].Place < max && _sportsmen[i].Place > 0) max = _sportsmen[i].Place;
                    }
                    return max;
                }
            }


            public Team(string name)
            {
                _name = name;
                _sportsmen = new Sportsman[6];
                _cnt = 0;
            }


            public void Add(Sportsman sportsman)
            {
                if (_sportsmen == null || _cnt >= 6) return;
                _sportsmen[_cnt] = sportsman;
                _cnt++;
            }
            public void Add(Sportsman[] sportsman)
            {
                if (_cnt >= 6 || _sportsmen == null) return;
                foreach (var s in sportsman)
                {
                    Add(s);
                }
            }

            public static void Sort(Team[] teams)
            {
                for (int i = 0; i < teams.Length; i++)
                {
                    for (int j = 0; j < teams.Length - i - 1; j++)
                    {
                        if (teams[j].SummaryScore < teams[j + 1].SummaryScore)
                        {
                            (teams[j], teams[j + 1]) = (teams[j + 1], teams[j]);
                        }
                        else if (teams[j].SummaryScore == teams[j + 1].SummaryScore && teams[j].TopPlace > teams[j + 1].TopPlace)
                        {
                            (teams[j], teams[j + 1]) = (teams[j + 1], teams[j]);
                        }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine(_name);
                for (int i = 0; i < _cnt; i++)
                {
                    _sportsmen[i].Print();
                }
            }
        }
    }
}