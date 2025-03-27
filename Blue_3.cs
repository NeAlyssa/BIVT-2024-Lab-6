using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_3
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private int[] _out_min;

            public string Name => _name;
            public string Surname => _surname;
            public int[] PenaltyTimes { 
                get {
                    
                    if (_out_min == null) return null;//
                    int[]copiedarray = new int[_out_min.Length];
                    for (int i = 0; i < _out_min.Length; i++)
                    {
                        copiedarray[i] = _out_min[i];
                    }
                    return copiedarray;
                } 
            }

            public int TotalTime
            {
                get
                {
                    if (_out_min == null || _out_min.Length == 0) return 0;
                    int total = 0;
                    for(int i = 0; i < _out_min.Length; i++)
                    {
                        total += _out_min[i];
                    }
                    return total;
                }
            }

            public bool IsExpelled
            {
                get
                {
                    if (_out_min == null || _out_min.Length == 0) return false;//
                    for (int i = 0; i<_out_min.Length; i++)
                    {
                        if (_out_min[i] == 10) return true;
                    }
                    return false;
                }
            }

            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _out_min= new int[0];

            }

            public void PlayMatch(int time)
            {
                if (_out_min == null) return;
                int[] new_penalty_min = new int[_out_min.Length+1];

                for (int i = 0; i < new_penalty_min.Length-1; i++) 
                {
                    new_penalty_min[i] = _out_min[i];
                }
                new_penalty_min[new_penalty_min.Length-1] = time;
                _out_min = new_penalty_min;
            }

            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length==0) return;
                for (int i = 1, j = 2; i < array.Length;)
                {
                    if (i == 0 || array[i].TotalTime >= array[i - 1].TotalTime) { i = j; j++; }
                    else
                    {
                        var temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        i--;
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($"{Name} {Surname}: {TotalTime}  {IsExpelled}");
            }
        }
    }
}
