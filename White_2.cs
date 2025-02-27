namespace Lab_6 {
    public class White_2 {
        public struct Participant {

            // Поля
            private string _name;
            private string _surname;
            private double _firstJump;
            private double _secondJump;

            // Свойства
            public string Name => _name;
            public string Surname => _surname;
            public double FirstJump => _firstJump;
            public double SecondJump => _secondJump;
            public double BestJump => _firstJump >= _secondJump ? _firstJump : _secondJump;

            // Конструктор
            public Participant(string name, string surname) {
                _name = name;
                _surname = surname;
                _firstJump = 0;
                _secondJump = 0;
            }

            // Методы
            public static void Sort(Participant[] array) {
                if (array == null) {
                    Console.WriteLine("Array can't be null");
                    return;
                }
                if (array.Length == 0) {
                    Console.WriteLine("Array must not be empty");
                    return;
                }

                var newArray = array.OrderByDescending(p => p.BestJump).ToArray();
                Array.Copy(newArray, array, newArray.Length);
            }

            public void Jump(double result) {
                if (result < 0) {
                    Console.WriteLine("Result can't be negative");
                    return;
                }

                if (_firstJump == 0) {
                    _firstJump = result;
                }
                else if (_secondJump == 0) {
                    _secondJump = result;
                }
            }

            public void Print() {
                Console.WriteLine("Name: " + Name + "\tSurname: " + Surname + "\tBestJump: " + BestJump);
            }
        }
    }
}