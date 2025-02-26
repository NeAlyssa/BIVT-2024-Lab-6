using System;
using System.CodeDom.Compiler;
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
           //
            private string _name;
            private string _surname;
            private int[] _penaltyTimes;
            //
            public string Name => _name;
            public string Surname => _surname;
            public int[] PenaltyTimes 
            {
                get
                {

                    if (_penaltyTimes == null) return null; 
                    int[] copy = new int[_penaltyTimes.Length];
                    Array.Copy(_penaltyTimes, copy, copy.Length);
                    return copy;
                }
            }
            //
            public int TotalTime
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return 0;
                    return _penaltyTimes.Sum();

                }
            }
            public bool IsExpelled
            {
                get
                {
                    if (_penaltyTimes == null) return false ;
                    for (int s =0;  s < _penaltyTimes.Length; s++)
                    {
                        if (_penaltyTimes[s] == 10) return true;
                    }
                    return false;
                }
            }
            //
            public Participant(string name,string surname)
            {
                _name = name;
                _surname = surname;
                _penaltyTimes = new int[0];


            }
            public void PlayMatch(int time)
            {
                if (_penaltyTimes== null) return;
                int[] temp = new int[_penaltyTimes.Length+1];
                for (int i=0; i<temp.Length-1; i++)
                {
                    temp [i] = _penaltyTimes[i];
                }
                temp[temp.Length-1] = time;
                _penaltyTimes = temp;
            }
            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].TotalTime > array[j + 1].TotalTime)
                        {
                            (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        }
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine($"Name: {Name}, Surname: {Surname}, TotalTime: {TotalTime}, IsExpelled:{ IsExpelled}");
               
            }
        }
    }
}
