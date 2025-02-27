namespace Lab_6 {
    public class White_3 {
        public struct Student {
            // Поля
            private string _name;
            private string _surname;
            private int[] _marks;
            private int _skips;

            // Свойства
            public string Name => _name;
            public string Surname => _surname;
            public int Skipped => _skips;
            public double AvgMark => (_marks != null && _marks.Length > 0) ? (double)_marks.Sum()/_marks.Length : 0;

            // Конструктор
            public Student(string name, string surname) {
                _name = name;
                _surname = surname;
                _marks = new int[0];
                _skips = 0;
            }

            // Методы
            public void Lesson(int mark) {
                if (mark < 0) {
                    Console.WriteLine("Mark can't be negative");
                    return;
                } else if (mark == 0) {
                    _skips += 1;
                } else {
                    if (_marks == null) {
                        Console.WriteLine("Array of marks wasn't initialized");
                        return;
                        // _marks = new int[0];
                    }

                    var newArray = new int[_marks.Length + 1];
                    Array.Copy(_marks, newArray, _marks.Length);
                    newArray[_marks.Length] = mark;
                    _marks = newArray;
                }
            }

            public static void SortBySkipped(Student[] array) {
                if (array == null) {
                    Console.WriteLine("Array can't be null");
                    return;
                }
                if (array.Length == 0) {
                    Console.WriteLine("Array must not be empty");
                    return;
                }

                var newArray = array.OrderByDescending(p => p.Skipped).ToArray();
                Array.Copy(newArray, array, newArray.Length);
            }

            public void Print() {
               Console.WriteLine("Name: " + Name + "\tSurname: " + Surname + "\tAverage mark: " + AvgMark + "\t Skipped: " + Skipped); 
            }
        }
    }
}