using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_5
    {
        public struct Sportsman
        {
            //поля
            private string _name;
            private string _surname;
            private int _place;
            //свойства
            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int Place { get { return _place; } }
            //конструктор 
            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _place = 0;
            }
            //методы
            public void SetPlace(int place)
            {
                if (_place != 0) return;
                _place = place;
            }
            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {_place}");
            }
        }
        public struct Team
        {
            //поля
            private string _name;
            private Sportsman[] _sportsmen;
            private int _count;
            //свойства 
            public string Name { get { return _name; } }
            public Sportsman[] Sportsmen
            {
                get
                {
                    if (_sportsmen == null || _sportsmen.Length == 0) return null;
                    Sportsman[] copy = new Sportsman[_sportsmen.Length];
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        copy[i] = _sportsmen[i];
                    }
                    return copy;
                }
            }
            private int Count { get { return _count; } }
            public int SummaryScore
            {
                get
                {
                    if (_sportsmen == null || _sportsmen.Length == 0) return 0;
                    int sum = 0;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        if (_sportsmen[i].Place == 1) sum += 5;
                        else if (_sportsmen[i].Place == 2) sum += 4;
                        else if (_sportsmen[i].Place == 3) sum += 3;
                        else if (_sportsmen[i].Place == 4) sum += 2;
                        else if (_sportsmen[i].Place == 5) sum += 1;
                    }
                    return sum;
                }
            }
            public int TopPlace
            {
                get
                {
                    if (_sportsmen == null || _sportsmen.Length == 0) return 0;
                    int maxPlace = 18;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        if (_sportsmen[i].Place > 0 && _sportsmen[i].Place < maxPlace) maxPlace = _sportsmen[i].Place;
                    }
                    return maxPlace;
                }
            }

            //конструктор 
            public Team (string name)
            {
                _name = name;
                _sportsmen = new Sportsman[6];
                _count = 0;
            }
            //методы
            public void Add(Sportsman sportsman)
            {
                if (_sportsmen == null || _sportsmen.Length == 0 || _count >= _sportsmen.Length) return;
                _sportsmen[_count] = sportsman;
                _count++;
            }
            public void Add(Sportsman[] sportsman)
            {
                if (_sportsmen.Length == 0 || _sportsmen == null || sportsman == null || sportsman.Length == 0 || _count >= _sportsmen.Length) return;
                int i = 0;
                while (_count < _sportsmen.Length && i < sportsman.Length)
                {
                    _sportsmen[_count] = sportsman[i];
                    _count++;
                    i++;
                }
            }
            public static void Sort(Team[] teams)
            {
                if (teams == null || teams.Length == 0) return;
                for (int i = 1, j = 2; i < teams.Length;)
                {
                    if (i == 0 || teams[i - 1].SummaryScore > teams[i].SummaryScore)
                    {
                        i = j;
                        j++;
                    }
                    else if (teams[i - 1].SummaryScore == teams[i].SummaryScore && teams[i - 1].TopPlace <= teams[i].TopPlace)
                    {
                        i = j;
                        j++;
                    }
                    else
                    {
                        Team temp = teams[i];
                        teams[i] = teams[i - 1];
                        teams[i - 1] = temp;
                        i--;
                    }
                }
            }
            public void Print()
            {
                for (int i = 0; i < _sportsmen.Length; i++)
                {
                    Console.WriteLine($"{_name} {SummaryScore} {TopPlace}");
                }
            }
        }
    }
}
