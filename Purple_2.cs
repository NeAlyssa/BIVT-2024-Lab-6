using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Purple_2
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private int _distance;
            private int[] _marks;
            private int _result;

            public string Name => _name;
            public string Surname => _surname;
            public int Distance => _distance;
            public int[] Marks
            {
                get
                {
                    if (_marks == null) return null;
                    int[] p = new int[_marks.Length];
                    for (int i = 0; i < _marks.Length; i++)
                    {
                        p[i] = _marks[i];
                    }
                    return p;
                }
            }
            public int Result => _result;


            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _distance = 0;
                _marks = new int[5];
                _result = 0;
            }

            public void Jump(int distance, int[] marks)
            { 
                _distance = distance;
                if (marks == null) return;
                int sm = 0;
                int mn = int.MaxValue;
                int mx = 0;
                for (int i = 0; i < marks.Length; i++)
                {
                    _marks[i] = marks[i];
                    if (marks[i] < mn)
                        mn = marks[i];
                    if (marks[i] > mx)
                        mx = marks[i];
                    sm += marks[i];
                }
                _result = Math.Max(0, sm - mn - mx + 60 + (_distance - 120) * 2);
                
            }
            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j]._result < array[j + 1]._result)
                        {
                            Participant l = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = l;
                        }
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine(_name + " " + _surname + " " + _result);
            }
        }
    }
}
