using Microsoft.SqlServer.Server;
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

                    if (_scores == null ) return null;
                    int[] copy = new int[_scores.Length];
                    Array.Copy(_scores, copy, copy.Length);
                    return copy;
                }
            }
            public int TotalScore
            {
                get
                {
                    if (_scores == null ) return 0;
                    return _scores.Sum();

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
                int[] temp = new int[_scores.Length + 1];
                for (int i = 0; i < temp.Length - 1; i++)
                {
                    temp[i] = _scores[i];
                }
                temp[temp.Length - 1] = result;
                _scores = temp;
            }
            public void Print()
            {
                Console.WriteLine($"Name: {Name}");
               // for (int i=0; i < _scores.Length; i++)
                //{
                ////    Console.WriteLine( _scores[i] );
               // }
               Console.WriteLine($"Total score - {TotalScore}");
            }

        }
        //
        public struct Group
        {
            private string _name;
            private Team[] _teams;
            private int _indteam;

            public string Name => _name;
            public Team[] Teams => _teams;
//            {
//get
//{

//if (_teams == null) return null;
//Team[] copy = new Team[_teams.Length];
//Array.Copy(_teams, copy, copy.Length);
//return copy;
//}
//}

            public Group(string name)
            {
                _name = name;
                _teams = new Team[12];
                _indteam = 0;
            }

           
            public void Add(Team team)
            {
                if (_teams == null) return;
                
                if (_indteam < _teams.Length)
                {
                    _teams[_indteam] = team;
                    _indteam++;
                }
            }
            public void Add(Team[] teams)
            {
                if (_teams == null || teams == null || teams.Length == 0) return;

                int i = 0;

                while (_indteam < _teams.Length && i < teams.Length)
                {
                    _teams[_indteam] = teams[i];
                    _indteam++;
                    i++;
                }
               
            }
            public void Sort()
            {
                if (_teams == null || _teams.Length == 0) return;
                for (int i = 0; i < _teams.Length; i++)
                {
                    for (int j = 0; j < _teams.Length - i - 1; j++)
                    {
                        if (_teams[j].TotalScore < _teams[j + 1].TotalScore)
                        {
                            (_teams[j], _teams[j + 1]) = (_teams[j + 1], _teams[j]);
                        }
                    }
                }
            }
            public static Group Merge(Group group1, Group group2, int size)
            {
                Group res = new Group("Финалисты");
                int n = size / 2;
                int i = 0, j = 0;
                while (i < n && j < n)
                {
                    if (group1.Teams[i].TotalScore >= group2.Teams[j].TotalScore)
                    {
                        res.Add(group1.Teams[i]);
                        i++;
                    }
                    else
                    {
                        res.Add(group2.Teams[j]);
                        j++;
                    }
                }
                while (i < n)
                {
                    res.Add(group1.Teams[i]);
                    i++;
                }
                while (j < n)
                {
                    res.Add(group2.Teams[j]);
                    j++;
                }
                return res;
            }
            public void Print()
            {
                Console.WriteLine(_name);
                for (int k = 0; k < _indteam; k++)
                    _teams[k].Print();
                Console.WriteLine();
            }
        }

        
    }

    //

    
}
