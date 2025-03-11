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

            public string Name => _name;
            public string Surname
            {
                get
                {
                    return _surname;
                }
            }
            public int Distance => _distance;
            public int[] Marks
            {
                get
                {
                    if (_marks == null) return null;
                    int[] newarr = new int[_marks.Length];
                    Array.Copy(_marks, newarr, _marks.Length);
                    return newarr;
                }
            }

            public int Result
            {
                get
                {
                    if(_marks == null) return 0;
                    int answer = 60;
                    int maxres = 0, minres = int.MaxValue;
                    for(int i = 0; i< _marks.Length; i++)
                    {
                        if (_marks[i] > maxres) maxres = _marks[i];
                        if (_marks[i]<minres) minres = _marks[i];
                        answer += _marks[i];
                    }
                    answer=answer-maxres-minres;
                    int razn = _distance - 120;
                    answer += razn * 2;
                    
                    return Math.Max(answer, 0);

                    
                        
                }
            }

            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _distance = 0;
                _marks = new int[5] { 0, 0, 0, 0, 0 };
            }


            public void Jump(int distance, int[] marks)
            {
                _distance = distance;
                for (int i = 0; i < 5; i++) _marks[i] = marks[i];
            }
            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for(int i=1, j=2; i<array.Length; )
                {
                    if(i==0 || array[i].Result <= array[i - 1].Result)
                    {
                        i = j; j++;
                    }
                    else
                    {
                        Participant temp = array[i];
                        array[i] = array[i-1];
                        array[i-1] = temp;
                        i--;
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine($"{Surname,-12}  -  {Result}");
            }
        }
    }
}
