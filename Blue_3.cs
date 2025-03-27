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
            private int[] _penaltytimes;

            public string Name => _name;
            public string Surname => _surname;

            public int[] PenaltyTimes
            {
                get
                {
                    if (_penaltytimes == null) return null;
                    int[] copy = new int[_penaltytimes.Length];
                    for (int i = 0; i < copy.Length; i++)
                    {
                        copy[i] = _penaltytimes[i];
                    }
                    return copy;
                }
            }

            public int TotalTime
            {
                get
                {
                    if (_penaltytimes == null) return 0;
                    int cnt = 0;
                    for (int i = 0; i < _penaltytimes.Length; i++)
                    {
                        cnt += _penaltytimes[i];
                    }
                    return cnt;
                }
            }


            public bool IsExpelled
            {
                get
                {
                    bool k = true;
                    if (_penaltytimes == null) return true;
                    for (int i = 0; i < _penaltytimes.Length; i++)
                    {
                        if (_penaltytimes[i] == 10)
                        {
                            k = false;
                            break;
                        }
                    }
                    return k;
                }
            }


            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _penaltytimes = new int[0];
            }


            public void PlayMatch(int time)
            {
                if (_penaltytimes == null) return;
                int[] newpenaltytimes = new int[_penaltytimes.Length + 1];
                for (int i = 0; i < newpenaltytimes.Length - 1; i++)
                {
                    newpenaltytimes[i] = _penaltytimes[i];
                }
                newpenaltytimes[_penaltytimes.Length] = time;
                _penaltytimes = newpenaltytimes;
            }



            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;
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
                Console.WriteLine($"{_name}   {_surname}   {TotalTime}  {IsExpelled}");
            }
        }
    }
}
