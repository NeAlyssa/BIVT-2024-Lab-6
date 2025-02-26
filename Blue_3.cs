using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_3
    {
        public struct Participant
        {
            //поля
            private string _name;
            private string _surname;
            private int[] _penaltyTimes;
            //свойства 
            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int[] PenaltyTimes
            {
                get
                {
                    if (_penaltyTimes == null) return null;
                    if (_penaltyTimes.Length == 0) return _penaltyTimes;
                    int[] copy = new int[_penaltyTimes.Length];
                    for (int i = 0; i < copy.Length; i++)
                    {
                        copy[i] = _penaltyTimes[i];
                    }
                    return copy;
                }
            }
            public int TotalTime
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return 0;
                    int count = 0; 
                    for (int i = 0; i < _penaltyTimes.Length;i++)
                    {
                        count += _penaltyTimes[i];
                    }
                    return count;
                }
            }
            public bool IsExpelled
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return true;
                    bool t = false;
                    for (int i = 0; i < _penaltyTimes.Length; i++)
                    {
                        if (_penaltyTimes[i] == 10) return true;
                    }
                    return t;
                }
            }
            //конструктор
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _penaltyTimes = new int[0];
            }
            //методы 
            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;
                for (int i = 1, j = 2; i < array.Length;)
                {
                    if (i == 0 || array[i - 1].TotalTime <= array[i].TotalTime)
                    {
                        i = j;
                        j++;
                    }
                    else
                    {
                        Participant temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        i--;
                    }
                }
            }
            public void PlayMatch(int time)
            {
                if (_penaltyTimes == null) return;
                if (_penaltyTimes.Length == 0)
                {
                    int[] _pT = new int[1];
                    _pT[0] = time;
                    _penaltyTimes = new int[1];
                    Array.Copy(_pT, _penaltyTimes, _pT.Length);
                }
                else
                {
                    int[] _pT = new int[_penaltyTimes.Length + 1];
                    _pT[_pT.Length - 1] = time;
                    for (int i = 0; i < _penaltyTimes.Length;i++)
                    {
                        _pT[i] = _penaltyTimes[i];
                    }
                    _penaltyTimes = new int[_pT.Length];
                    Array.Copy(_pT, _penaltyTimes, _pT.Length);
                }
            }
            public void Print()
            {
                Console.WriteLine($"{this._name} {this._surname} {this.TotalTime} {this.IsExpelled}");
            }
        }
    }
}
