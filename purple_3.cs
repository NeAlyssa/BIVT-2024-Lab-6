using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class purple_3
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private double[] _marks;
            private int[] _places;
            private int _score;
            private int _topplace;
            private double _totalmark;
            private int _numbmark;

            public string Name => _name;
            public string Surname => _surname;
            public int[] Places
            {
                get
                {
                    int[] p = new int[_places.Length];
                    for (int i = 0; i < _places.Length; i++)
                    {
                        p[i] = _places[i];
                    }
                    return p;
                }
            }
            public double[] Marks
            {
                get
                {
                    double[] p = new double[_marks.Length];
                    for (int i = 0; i < _marks.Length; i++)
                    {
                        p[i] = _marks[i];
                    }
                    return p;
                }
            }
            public int Score => _score;
            public int TopPlace => _topplace;
            public double TotalMark => _totalmark;


            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new double[7];
                _places = new int[7];
                _score = 0;
                _topplace = int.MaxValue;
                _totalmark = 0;
                _numbmark = 0;
            }
            public void Evaluate(double result)
            {
                if (_numbmark < 7)
                {
                    _marks[_numbmark] = result;
                    _totalmark += result;
                    _numbmark++;
                }
            }

            private static int min(int a, int b)
            {
                if (a < b)
                    return a;
                return b;
            }
            public static void SetPlaces(Participant[] participants)
            {
                if (participants == null) return;
                for (int p = 0; p < 7; p++)
                {
                    for (int i = 0; i < participants.Length; i++)
                    {
                        for (int j = 0; j < participants.Length - 1; j++)
                        {
                            if (participants[j]._marks[p] < participants[j + 1]._marks[p])
                            {
                                Participant l = participants[j];
                                participants[j] = participants[j + 1];
                                participants[j + 1] = l;
                            }
                        }
                    }
        
                    for (int i = 0; i < participants.Length; i++)
                    {
                        participants[i]._places[p] = i + 1;
                        participants[i]._score += i + 1;
                        participants[i]._topplace = min(participants[i]._topplace, i + 1);
                    }
                }
            }


            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j]._score > array[j + 1]._score)
                        {
                            Participant l = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = l;
                        }
                        else if (array[j]._score == array[j + 1]._score) 
                        {
                            if (array[j]._topplace > array[j + 1]._topplace)
                            {
                                Participant l = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = l;
                            }
                            else if (array[j]._topplace == array[j + 1]._topplace) 
                            { 
                                if (array[j]._totalmark < array[j + 1]._totalmark)
                                {
                                    Participant l = array[j];
                                    array[j] = array[j + 1];
                                    array[j + 1] = l;
                                }
                            }
                        }
                    }
                }
            }
            public static void Print(Participant[] participant)
            {
                foreach (Participant p in participant)
                    Console.WriteLine(p._name + " " + p._surname + " " + p._score + " " + p._topplace + " " + p._totalmark);
            }
        }
    }
}
