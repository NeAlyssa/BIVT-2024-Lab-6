using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Purple_3
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private double[] _marks;
            private int[] _places;

            private int countmark;
            public string Name => _name;
            public string Surname => _surname;
            public double[] Marks
            {
                get
                {
                    if (_marks == null) return null;
                    double[] newarr = new double[_marks.Length];
                    Array.Copy(_marks, newarr, _marks.Length);
                    return newarr;
                }
            }
            public int[] Places
            {
                get
                {
                    if (_places == null) return null;
                    int[] newarr = new int[_places.Length];
                    Array.Copy(_places, newarr, _places.Length);
                    return newarr;
                }
            }

            public int Score
            {
                get
                {
                    if (_places == null) return 0;
                    int ans = 0;
                    for (int i = 0; i < _places.Length; i++) ans += _places[i];
                    return ans;
                }
            }

            //доп. свойства
            private int Topscore
            {
                get
                {
                    if(_places == null) return 0;
                    int res = int.MaxValue; 
                    foreach(int x in _places)
                    {
                        if (x < res) res = x;
                    }
                    return res;
                }
            }
            private double Sum
            {
                get
                {
                    if(_marks == null) return 0;
                    double s = 0;
                    foreach (double x in _marks) s += x;
                    return s;
                }
            }

            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
                _places = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

                countmark = 0;
            }

            public void Evaluate(double result)
            {
                if(_marks == null) return;
                if (countmark < 7)
                {
                    _marks[countmark] = result;
                    countmark++;
                }

            }

            public static void SetPlaces(Participant[] participants)
            {
                
                if (participants == null) return;
                Purple_3.Participant[] copy = new Purple_3.Participant[participants.Length];
                Array.Copy(participants, copy, participants.Length);
                for (int j = 0; j<7; j++)
                {
                    copy = copy.OrderByDescending(x =>x._marks!=null  ? x._marks[j] :int.MinValue).ToArray();
                    for(int i = 0; i< participants.Length; i++)
                    {
                        if(copy[i]._places != null )
                        copy[i]._places[j] = i+1;
                    }
                    
                }
                Array.Copy(copy, participants, copy.Length);
            }

            public static void Sort(Participant[] array)
            {
                Purple_3.Participant[] copy = new Purple_3.Participant[array.Length];
                Array.Copy(array, copy, array.Length);
                copy = copy.OrderBy(a => a._places != null ? a.Score : int.MaxValue).ThenBy(b=>b.Topscore).ThenByDescending(c=>c.Sum).ToArray();
                Array.Copy(copy, array, array.Length);
            }
            public void Print()
            {
                Console.WriteLine($"{_name, 9} {_surname,9}  {Score}  {Topscore}  {Sum}");
            }

        }
    }
}
