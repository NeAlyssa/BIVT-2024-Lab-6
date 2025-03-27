using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_4
    {
        public struct Team
        {
            private string _name;
            private int[] _scores;


            public string Name => _name;
            public int[] Scores
            {
                get
                {
                    if (_scores == null) return null;
                    int[] copy_scores = new int[_scores.Length];
                    for (int i = 0; i < copy_scores.Length; i++)
                    {
                        copy_scores[i] = _scores[i];
                    }
                    return copy_scores;
                }
            }

            public int TotalScore
            {
                get
                {
                    if (_scores == null) return 0;
                    int res = 0;
                    for (int i = 0; i < _scores.Length; i++)
                    {
                        res += _scores[i];
                    }
                    return res;
                }
            }


            public Team(string name)
            {
                _name = name;
                _scores = new int[0];
            }

            public void PlayMatch(int result)
            {
                if (_scores == null) return;
                int[] copy = new int[_scores.Length + 1];
                for (int i = 0; i < _scores.Length; i++)
                {
                    copy[i] = _scores[i];
                }
                copy[copy.Length - 1] = result;
                _scores = copy;
            }


            public void Print()
            {
                Console.WriteLine($"{_name}  {TotalScore}");
            }
        }


        public struct Group
        {
            private string _name;
            private Team[] _teams;
            private int _cnt;


            public string Name => _name;
            public Team[] Teams
            {
                get
                {
                    if (_teams == null) return null;
                    return _teams;
                }
            }


            public Group(string name)
            {
                _name = name;
                _teams = new Team[12];
                _cnt = 0;
            }

            public void Add(Team team)
            {
                if (_teams == null) return;
                if (_cnt <  _teams.Length) _teams[_cnt++] = team;
            }


            public void Add(Team[] teams)
            {
                if (_teams == null || teams.Length == 0 || teams == null) return;
                for (int i = 0; i < teams.Length; i++)
                {
                    Add(teams[i]);
                }
            }


            public void Sort()
            {
                for (int i = 0; i < _teams.Length; i++)
                {
                    for (int j = 0; j < _teams.Length - i - 1; j++)
                    {
                        if (_teams[j].TotalScore < _teams[j+1].TotalScore) (_teams[j], _teams[j + 1]) = (_teams[j + 1], _teams[j]); ;
                    }
                }
            }


            public static Group Merge(Group group1, Group group2, int size)
            {
                Group result = new Group("Финалисты");
                int cnt1 = 0, cnt2 = 0;
                while (cnt1 < size/2 && cnt2 < size/2) {
                    if (group1._teams[cnt1].TotalScore >= group2._teams[cnt2].TotalScore)
                    {
                        result.Add(group1._teams[cnt1]);
                        cnt1++;
                    } else
                    {
                        result.Add(group2._teams[cnt2]);
                        cnt2++;
                    }

                }
                while (cnt1 < size/2)
                {
                    result.Add(group1._teams[cnt1]);
                    cnt1++;
                }
                while (cnt2 < size / 2)
                {
                    result.Add(group2._teams[cnt2]);
                    cnt2++;
                }
                return result;
            }

            public void Print()
            {

                for (int i = 0; i < _teams.Length; i++)
                {
                    Console.WriteLine($" {_teams[i].Name} {_teams[i].TotalScore}");
                }

            }
        }
    }
}
