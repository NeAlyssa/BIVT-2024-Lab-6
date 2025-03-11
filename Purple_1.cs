using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Purple_1
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private double[] _coefs;
            private int[,] _marks;

            private int _jump;

            public string Name => _name;
            public string Surname => _surname;
            public double[] Coefs
            {
                get
                {
                    if (_coefs == null) return null;
                    double[] newarray = new double[_coefs.Length];
                    Array.Copy(_coefs, newarray, _coefs.Length);
                    return newarray;

                }
            }

            public int[,] Marks
            {

                get
                {
                    if (_marks == null) return null;
                    int[,] newmatrix = new int[_marks.GetLength(0), _marks.GetLength(1)];
                    Array.Copy(_marks, newmatrix, _marks.Length);
                    return newmatrix;

                }
            }
            public double TotalScore
            {
                get
                {
                    if(_marks == null || _coefs==null) return 0;
                    double answer =0;
                    for (int i = 0; i<4; i++)
                    {
                        double sum = 0;
                        int minind = 0, maxind = 0;
                        for (int j = 0;j<7; j++)
                        {
                            if (_marks[i, j] > _marks[i, maxind]) maxind = j;
                            if (_marks[i, j] < _marks[i, minind]) minind = j;
                        }
                        for(int j = 0; j<7; j++)
                        {
                            if(j!=maxind && j!= minind) sum+= _marks[i, j];
                        }
                        answer += sum * _coefs[i];
                    }
                    return answer;
                }
            }
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _coefs = new double[4];
                _marks = new int[4, 7];

                _jump = 0;
                for (int i = 0; i<4; i++)
                {
                    _coefs[i] = 2.5;
                    for (int j = 0; j<7; j++)
                    {
                        _marks[i, j] = 0;
                    }
                }
            }
            //методы
            public void SetCriterias(double[] coefs)
            {
                if(_coefs == null || coefs == null || _coefs.Length !=4 || coefs.Length!=4) return;
                for (int i = 0; i<4;i++) _coefs[i] = coefs[i];
            }

            public void Jump(int[] marks)
            {
                if (marks == null || _marks == null || _jump >3 || marks.Length != 7) return;
                for (int i = 0; i<marks.Length; i++)
                {
                    _marks[_jump, i] = marks[i];
                }
                _jump++;

            }

            
            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                double[] temp1 = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                    temp1[i] = array[i].TotalScore;
                Participant temp2;
                for(int i = 1, j=2; i < array.Length;)
                {
                    if(i==0 || temp1[i] < temp1[i - 1])
                    {
                        i = j;
                        j++;
                    }
                    else
                    {
                        double temp = temp1[i];
                        temp1[i] = temp1[i - 1];
                        temp1[i-1] = temp;

                        temp2 = array[i];
                        array[i] = array[i-1];
                        array[i-1] = temp2;
                        i--;
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine($"{Name}   {Surname}   {TotalScore}");
            }
        }
    }
}
