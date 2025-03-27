using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_2
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private int[,] _marks;
            private int _counter;

            public string Name => _name;
            public string Surname => _surname;
            public int[,] Marks {
                get {
                    if (_marks == null) return null;
                    int[,]copiedarrayofmarks=new int[_marks.GetLength(0), _marks.GetLength(1)];
                    for(int i = 0; i < _marks.GetLength(0); i++)
                    {
                        for(int j=0; j < _marks.GetLength(1); j++)
                        {
                            copiedarrayofmarks[i,j] = _marks[i,j];
                        }
                    }
                    return copiedarrayofmarks;
                }
            }
            public int TotalScore { 
                get { 
                    if (_marks==null) return 0;
                    int total = 0;
                    for (int i = 0; i < _marks.GetLength(0); i++)
                    {
                        for (int j = 0; j < _marks.GetLength(1); j++)
                        {
                            total += _marks[i, j];
                        }
                    }
                    return total;
                } 
            }
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new int[2, 5];
                _counter = 0;
            }

            public void Jump(int[] result) 
            {
                if (_marks == null || _marks.GetLength(0) == 0) return;
                if (result.Length == 0 || result == null) return;
                if (_counter > 1) return;
                for (int i = 0; i < 5; i++)
                {
                    _marks[_counter,i] = result[i];
                }
                _counter++;
            }

            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;
                for(int i = 1, j = 2; i < array.Length;)
                {
                    if (i == 0 || array[i].TotalScore <= array[i - 1].TotalScore) { i = j; j++; }
                    else { var temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        i--;
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine($"{Name} {Surname}: {TotalScore}");
            }
        }
    }
}
