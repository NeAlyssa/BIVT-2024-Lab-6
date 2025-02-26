using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_4
    {
        public struct Team
        {
            //поля
            private string _name;
            private int[] _scores;
            //свойства
            public string Name { get { return _name; } }
            public int[] Scores
            {
                get
                {
                    if (_scores == null) return null;
                    int[] copy = new int[_scores.Length];
                    for (int i = 0; i < copy.Length; i++)
                    {
                        copy[i] = _scores[i];
                    }
                    return copy;
                }
            }
            public int TotalScore
            {
                get
                {
                    if (_scores == null) return 0;
                    int count = 0;
                    for (int i = 0; i < _scores.Length; i++)
                    {
                        count += _scores[i];
                    }
                    return count;
                }
            }
            //конструктор
            public Team(string name)
            {
                _name = name;
                _scores = new int[0];
            }
            //методы
            public void PlayMatch(int result)
            {
                if (_scores == null || _scores.Length == 0)
                {
                    int[] _sc = new int[1];
                    _sc[0] = result;
                    _scores = new int[1];
                    Array.Copy(_sc, _scores, _sc.Length);
                }
                else
                {
                    int[] _sc = new int[_scores.Length + 1];
                    _sc[_sc.Length - 1] = result;
                    for (int i = 0; i < _scores.Length; i++)
                    {
                        _sc[i] = _scores[i];
                    }
                    _scores = new int[_sc.Length];
                    Array.Copy(_sc, _scores, _sc.Length);
                }
            }
            public void Print()
            {
                Console.WriteLine($"{this._name} {this.TotalScore}");
            }
        }
        public struct Group
        {
            //поля
            private string _name;
            private Team[] _teams;
            private int _count;
            //свойства
            public string Name => _name;
            public Team[] Teams => _teams;
            private int Count {get { return _count; } }
            //конструктор
            public Group (string name)
            {
                _name = name;
                _teams = new Team[12];
                _count = 0;
            }
            //методы
            public void Add(Team team)
            {
                if (_teams == null || _teams.Length == 0 || _count >= _teams.Length) return;
                _teams[_count] = team;
                _count++;
            }
            public void Add(Team[] teams)
            {
                if (_teams == null || teams == null || _teams.Length == 0 || teams.Length == 0 || _count >= _teams.Length) return;
                int i = 0;
                while (_count < _teams.Length && i < teams.Length)
                {
                    _teams[_count] = teams[i];
                    _count++;
                    i++;
                }
            }
            public void Sort()
            {
                if (_teams == null || _teams.Length == 0) return;
                for (int i = 1, j = 2; i < _teams.Length;)
                {
                    if (i == 0 || _teams[i - 1].TotalScore >= _teams[i].TotalScore)
                    {
                        i = j;
                        j++;
                    }
                    else
                    {
                        Team temp = _teams[i];
                        _teams[i] = _teams[i - 1];
                        _teams[i - 1] = temp;
                        i--;
                    }
                }
            }
            public static Group Merge(Group group1, Group group2, int size)
            {
                Group result = new Group("Финалисты");
                int n = size / 2;
                int i = 0, j = 0;
                while (i < n && j < n)
                {
                    if (group1.Teams[i].TotalScore >= group2.Teams[j].TotalScore)
                    {
                        result.Add(group1.Teams[i]);
                        i++;
                    }
                    else
                    {
                        result.Add(group2.Teams[j]);
                        j++;
                    }
                }
                while (i < n)
                {
                    result.Add(group1.Teams[i]);
                    i++;
                }
                while (j < n)
                {
                    result.Add(group2.Teams[j]);
                    j++;
                }
                return result;
            }
            public void Print()
            {
                Console.WriteLine(_name);
                for (int k = 0; k < _count; k++)
                {
                    _teams[k].Print();
                }
            }
        }
    }
}
