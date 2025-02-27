namespace Lab_6 {
    public class White_1 {
        public struct Participant {

            // Поля
            private string _surname;
            private string _club;
            private double _firstJump;
            private double _secondJump;
            
            // Свойства
            public string Surname => _surname;
            public string Club => _club;
            public double FirstJump => _firstJump;
            public double SecondJump => _secondJump;
            public double JumpSum => _firstJump + _secondJump;

            // Конструктор
            public Participant(string surname, string club) {
                _surname = surname;
                _club = club;
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

                var newArray = array.OrderByDescending(p => p.JumpSum).ToArray();
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
                Console.WriteLine("Surname: " + Surname + "\tClub: " + Club + "\tJumpSum: " + JumpSum);
            }
        }
    }
}