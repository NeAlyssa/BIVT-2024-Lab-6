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
                    int[] copscores = new int[_scores.Length];
                    for (int i = 0; i < copscores.Length; i++)
                    {
                        copscores[i] = _scores[i];
                    }
                    return copscores;
                }
            }
            public int TotalScore
            {
                get
                {
                    if (_scores == null) return 0;
                    int total = 0;
                    for (int i = 0; i < _scores.Length; i++)
                    {
                        total += _scores[i];
                    }
                    return total;
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
                int[] new_scores = new int[_scores.Length + 1];
                for (int i = 0; i < _scores.Length; i++)
                {
                    new_scores[i] = _scores[i];
                }
                new_scores[new_scores.Length - 1] = result;
                _scores = new_scores;
            }

            public void Print()
            {
                Console.WriteLine($"{Name}: {TotalScore}");
            }
        }

        public struct Group
        {
            private string _name;
            private Team[] _teams;
            private int _team_number;

            public string Name => _name;
            public Team[] Teams => _teams;

            public Group(string name)
            {
                _name = name;
                _teams = new Team[12];
                _team_number = 0;
            }

            public void Add(Team team)
            {
                if (_teams == null || _teams.Length == 0) return;
                if (_team_number >= _teams.Length) return;
                else { _teams[_team_number] = team; _team_number++; }
            }

            public void Add(Team[] teams)
            {
                if (teams == null || _teams == null || teams.Length == 0) return;
                int i = 0;
                while (_team_number < _teams.Length && i < teams.Length)
                {
                    _teams[_team_number] = teams[i];
                    _team_number++;
                    i++;
                }
            }

            public void Sort()
            {
                if (_teams == null || _teams.Length==0) return;
                for (int i = 1, j = 2; i < _teams.Length;)
                {
                    if (i == 0 || _teams[i].TotalScore <= _teams[i - 1].TotalScore) { i = j; j++; }
                    else
                    {
                        var temp = _teams[i];
                        _teams[i] = _teams[i - 1];
                        _teams[i - 1] = temp;
                        i--;
                    }
                }
            }

            public static Group Merge(Group group1, Group group2,int size)
            {
                Group finale = new Group("Финалисты");
                int[] merged_array= new int[size];
                int i=0, j=0;
                while(i < size/2 && j < size/2)////
                {
                    if (group1.Teams[i].TotalScore >= group2.Teams[j].TotalScore)
                    {
                        finale.Add(group1.Teams[i]);
                        i++;
                    }
                    else
                    {
                        finale.Add(group2.Teams[j]);
                        j++;
                    }
                }

                while (i < size/2)///
                {
                    finale.Add(group1.Teams[i]);
                    i++;

                }
                while (j < size/2)///
                {
                    finale.Add(group2.Teams[j]);
                    j++;

                }
                return finale;///
            }

            public void Print()
            {
                Console.WriteLine(_name);
                for(int i = 0; i < _team_number; i++)
                {
                    _teams[i].Print();
                }
            }
        }
    }
}
