using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_6
{
    public class Blue_2
    {
        public struct Participant
        {
            //поля
            private string _name;
            private string _surname;
            private int[,] _marks;
            private int _count;
            //свойства
            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int[,] Marks
            {
                get
                { 
                    if (_marks == null) return null;
                    int[,] copy = new int[2, 5];
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            copy[i, j] = _marks[i, j];
                        }
                    }
                    return copy;
                }
            }
            private int Count { get { return _count; } }
            public int TotalScore
            {
                get
                {
                    if (_marks == null || _marks.GetLength(0) == 0 || _marks.GetLength(1) == 0) return 0;
                    int count = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            count += _marks[i, j]; 
                        }
                    }
                    return count;
                }
            }
            //конструктор
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new int[2, 5];
                _count = 0;
            }
            //методы
            public void Jump(int[] result)
            {
                if (result == null || _marks == null || result.Length == 0 || _marks.GetLength(0) < 2 || _marks.GetLength(1) < 5) return;
                if (_count == 0)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        _marks[0,j] = result[j];
                    }
                    _count++;
                }
                else if (_count == 1)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        _marks[1, j] = result[j];
                    }
                    _count++;
                }
            }
            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;
                for (int i = 1, j = 2; i < array.Length;)
                {
                    if (i == 0 || array[i - 1].TotalScore >= array[i].TotalScore)
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
            public void Print()
            {
                Console.WriteLine($"{this._name} {this._surname} {this.TotalScore}");
            }
        }
    }
}
