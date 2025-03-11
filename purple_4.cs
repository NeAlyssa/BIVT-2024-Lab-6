using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class purple_4
    {
        public struct Sportsman
        {
            private string _name;
            private string _surname;
            private double _time;

            public string Name => _name;
            public string Surname => _surname;
            public double Time => _time;


            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _time = 0;
            }

            public void Run(double time)
            { 
                _time = time;
            }
            
            public static void Print(Sportsman[] sportsman)
            {
                if (sportsman == null) return;
                foreach (Sportsman p in sportsman)
                    Console.WriteLine(p._name + " " + p._surname + " " + p._time);
            }
        }
        public struct Group
        { 
            private string _name;
            private Sportsman[] _sportsmen;

            public string Name => _name;
            public Sportsman[] Sportsmen => _sportsmen;

            public Group(string name)
            { 
                _name = name;
                _sportsmen = new Sportsman[0];
            }
            public Group(Group group)
            {
                _name = group._name;
                _sportsmen = new Sportsman[group._sportsmen.Length];
                for (int i = 0; i < group._sportsmen.Length; i++)
                {
                    _sportsmen[i] = group._sportsmen[i];
                }
            }
            public void Add(Sportsman s)
            {
                Sportsman[] sp = new Sportsman[_sportsmen.Length + 1];
                int i = 0;
                for (; i < _sportsmen.Length; i++)
                {
                    sp[i] = _sportsmen[i];
                }
                sp[i] = s;
                _sportsmen = sp;
            }
            public void Add(Sportsman[] s)
            {
                if (s == null) return;
                if (_sportsmen == null || s.Length == 0) return;
                Sportsman[] sp = new Sportsman[_sportsmen.Length + s.Length];
                int i = 0;
                for (; i < _sportsmen.Length; i++)
                {
                    sp[i] = _sportsmen[i];
                }
                for (int j = 0; j < s.Length; j++, i++)
                {
                    sp[i] = s[j];
                }
                _sportsmen = sp;
            }
            public void Add(Group g)
            {
                Sportsman[] sp = new Sportsman[_sportsmen.Length + g._sportsmen.Length];
                int i = 0;
                for (; i < _sportsmen.Length; i++)
                {
                    sp[i] = _sportsmen[i];
                }
                for (int j = 0; j < g._sportsmen.Length; j++, i++)
                {
                    sp[i] = g._sportsmen[j];
                }
                _sportsmen = sp;
            }
            public void Sort()
            {
                for (int i = 0; i < _sportsmen.Length; i++)
                {
                    for (int j = 0; j < _sportsmen.Length - 1; j++)
                    {
                        if (_sportsmen[j].Time > _sportsmen[j + 1].Time)
                        {
                            Sportsman l = _sportsmen[j];
                            _sportsmen[j] = _sportsmen[j + 1];
                            _sportsmen[j + 1] = l;
                        }
                    }
                }
            }
            public static Group Merge(Group group1, Group group2)
            { 
                Group g = new Group("Финилисты");
                for (int i = 0, j = 0; i < group1._sportsmen.Length || j < group2._sportsmen.Length;)
                {
                    if (!(i < group1._sportsmen.Length))
                    {
                        g.Add(group2._sportsmen[j]);
                        j++;
                    }
                    else if (!(j < group2._sportsmen.Length))
                    {
                        g.Add(group1._sportsmen[i]);
                        i++;
                    }
                    else
                    {
                        if (group1._sportsmen[i].Time < group2._sportsmen[j].Time)
                        {
                            g.Add(group1._sportsmen[i]);
                            i++;
                        }
                        else
                        {
                            g.Add(group2._sportsmen[j]);
                            j++;
                        }
                    }
                }
                return g;
            }
            public static void Print(Group g)
            {
                foreach (Sportsman p in g._sportsmen)
                    Console.WriteLine(p.Name + " " + p.Surname + " " + p.Time);
            }
        }
    }
}
