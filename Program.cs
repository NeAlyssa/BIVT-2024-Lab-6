using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6 
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("\n========================================================================");
            Console.WriteLine("White_1");
            Console.WriteLine("========================================================================\n");

            White_1.Participant[] participants1 = new White_1.Participant[] {
                new White_1.Participant("Лисицына", "Рубин"),
                new White_1.Participant("Ушакова", "Василек"),
                new White_1.Participant("Смирнова", "Югра"), 
                new White_1.Participant("Луговая", "Зенит"),
                new White_1.Participant("Чехова", "Магнит"),
                new White_1.Participant("Зайцева", "Звери"),
                new White_1.Participant("Сидорова", "Метеор"),
                new White_1.Participant("Степанова", "Магнит"),
                new White_1.Participant("Сидорова", "Метеор"),
                new White_1.Participant("Степанова", "Рубин"),
            };

            participants1[0].Jump(7.39);
            participants1[0].Jump(6.96);
            participants1[1].Jump(7.43);
            participants1[1].Jump(5.55);
            participants1[2].Jump(6.34);
            participants1[2].Jump(3.83);
            participants1[3].Jump(5.50);
            participants1[3].Jump(3.18);
            participants1[4].Jump(0.59);
            participants1[4].Jump(5.31);
            participants1[5].Jump(8.74);
            participants1[5].Jump(0.82);
            participants1[6].Jump(3.96);
            participants1[6].Jump(0.83);
            participants1[7].Jump(8.99);
            participants1[7].Jump(1.35);
            participants1[8].Jump(8.57);
            participants1[8].Jump(5.21);
            participants1[9].Jump(3.27);
            participants1[9].Jump(8.85);

            White_1.Participant.Sort(participants1);

            foreach (var participant in participants1) {
                participant.Print();
            }

            Console.WriteLine("\n========================================================================");
            Console.WriteLine("White_2");
            Console.WriteLine("========================================================================\n");

            White_2.Participant[] participants2 = new White_2.Participant[] {
                new White_2.Participant("Дмитрий", "Лисицын"),
                new White_2.Participant("Савелий", "Зайцев"),
                new White_2.Participant("Анастасия", "Полевая"),
                new White_2.Participant("Мария", "Сидорова"),
                new White_2.Participant("Мария", "Смирнова"),
                new White_2.Participant("Анастасия", "Свиридова"),
                new White_2.Participant("Савелий", "Павлов"),
                new White_2.Participant("Оксана", "Зайцева"),
                new White_2.Participant("Игорь", "Свиридов"),
                new White_2.Participant("Иван", "Смирнов")
            };

            participants2[0].Jump(3.16);
            participants2[0].Jump(2.42);
            participants2[1].Jump(1.28);
            participants2[1].Jump(1.97);
            participants2[2].Jump(1.41);
            participants2[2].Jump(3.22);
            participants2[3].Jump(1.26);
            participants2[3].Jump(3.91);
            participants2[4].Jump(1.83);
            participants2[4].Jump(3.59);
            participants2[5].Jump(3.20);
            participants2[5].Jump(2.99);
            participants2[6].Jump(1.73);
            participants2[6].Jump(3.54);
            participants2[7].Jump(2.20);
            participants2[7].Jump(2.28);
            participants2[8].Jump(3.77);
            participants2[8].Jump(3.46);
            participants2[9].Jump(2.09);
            participants2[9].Jump(3.84);

            White_2.Participant.Sort(participants2);

            foreach (var participant in participants2) {
                participant.Print();
            }

            Console.WriteLine("\n========================================================================");
            Console.WriteLine("White_3");
            Console.WriteLine("========================================================================\n");

            White_3.Student[] students = new White_3.Student[]
            {
                new White_3.Student("Савелий", "Полевой"),
                new White_3.Student("Игорь", "Полевой"),
                new White_3.Student("Анастасия", "Жаркова"),
                new White_3.Student("Ольга", "Распутина"),
                new White_3.Student("Оксана", "Иванова"),
                new White_3.Student("Алевтина", "Иванова"),
                new White_3.Student("Мирослав", "Жарков"),
                new White_3.Student("Егор", "Петров"),
                new White_3.Student("Екатерина", "Петрова"),
                new White_3.Student("Мирослав", "Петров"),
                new White_3.Student("Егор", "Луговой"),
                new White_3.Student("Дарья", "Козлова"),
                new White_3.Student("Александр", "Полевой"),
                new White_3.Student("Оксана", "Козлова"),
                new White_3.Student("Дарина", "Козлова"),
                new White_3.Student("Евгения", "Луговая"),
                new White_3.Student("Дарья", "Иванова"),
                new White_3.Student("Степан", "Козлов"),
                new White_3.Student("Светлана", "Полевая"),
                new White_3.Student("Игорь", "Иванов")
            };

            students[0].Lesson(3); students[0].Lesson(4); students[0].Lesson(4); students[0].Lesson(3); students[0].Lesson(3); students[0].Lesson(5); students[0].Lesson(5); students[0].Lesson(4); students[0].Lesson(4); students[0].Lesson(0);
            students[1].Lesson(4); students[1].Lesson(4); students[1].Lesson(3); students[1].Lesson(0); students[1].Lesson(2); students[1].Lesson(2); students[1].Lesson(5); students[1].Lesson(5); students[1].Lesson(2); students[1].Lesson(2);
            students[2].Lesson(2); students[2].Lesson(2); students[2].Lesson(2); students[2].Lesson(5); students[2].Lesson(2); students[2].Lesson(4); students[2].Lesson(5); students[2].Lesson(4); students[2].Lesson(0); students[2].Lesson(0);
            students[3].Lesson(3); students[3].Lesson(3); students[3].Lesson(3); students[3].Lesson(4); students[3].Lesson(4); students[3].Lesson(4); students[3].Lesson(5); students[3].Lesson(0); students[3].Lesson(0); students[3].Lesson(0);
            students[4].Lesson(4); students[4].Lesson(2); students[4].Lesson(2); students[4].Lesson(5); students[4].Lesson(3); students[4].Lesson(3); students[4].Lesson(2); students[4].Lesson(5); students[4].Lesson(0); students[4].Lesson(0);
            students[5].Lesson(2); students[5].Lesson(3); students[5].Lesson(3); students[5].Lesson(3); students[5].Lesson(5); students[5].Lesson(3); students[5].Lesson(3); students[5].Lesson(4); students[5].Lesson(0); students[5].Lesson(0);
            students[6].Lesson(3); students[6].Lesson(5); students[6].Lesson(2); students[6].Lesson(4); students[6].Lesson(3); students[6].Lesson(4); students[6].Lesson(3); students[6].Lesson(3); students[6].Lesson(0); students[6].Lesson(0);
            students[7].Lesson(3); students[7].Lesson(4); students[7].Lesson(3); students[7].Lesson(4); students[7].Lesson(2); students[7].Lesson(4); students[7].Lesson(4); students[7].Lesson(3); students[7].Lesson(2); students[7].Lesson(0);
            students[8].Lesson(3); students[8].Lesson(3); students[8].Lesson(4); students[8].Lesson(3); students[8].Lesson(4); students[8].Lesson(3); students[8].Lesson(4); students[8].Lesson(2); students[8].Lesson(0); students[8].Lesson(0);
            students[9].Lesson(5); students[9].Lesson(3); students[9].Lesson(5); students[9].Lesson(4); students[9].Lesson(5); students[9].Lesson(2); students[9].Lesson(4); students[9].Lesson(0); students[9].Lesson(0); students[9].Lesson(0);
            students[10].Lesson(3); students[10].Lesson(3); students[10].Lesson(3); students[10].Lesson(2); students[10].Lesson(5); students[10].Lesson(5); students[10].Lesson(3); students[10].Lesson(0); students[10].Lesson(0); students[10].Lesson(0);
            students[11].Lesson(4); students[11].Lesson(2); students[11].Lesson(4); students[11].Lesson(3); students[11].Lesson(2); students[11].Lesson(3); students[11].Lesson(0); students[11].Lesson(0); students[11].Lesson(0); students[11].Lesson(0);
            students[12].Lesson(3); students[12].Lesson(2); students[12].Lesson(4); students[12].Lesson(5); students[12].Lesson(2); students[12].Lesson(4); students[12].Lesson(4); students[12].Lesson(0); students[12].Lesson(0); students[12].Lesson(0);
            students[13].Lesson(2); students[13].Lesson(2); students[13].Lesson(2); students[13].Lesson(4); students[13].Lesson(2); students[13].Lesson(4); students[13].Lesson(3); students[13].Lesson(4); students[13].Lesson(3); students[13].Lesson(5);
            students[14].Lesson(4); students[14].Lesson(5); students[14].Lesson(2); students[14].Lesson(4); students[14].Lesson(4); students[14].Lesson(2); students[14].Lesson(0); students[14].Lesson(0); students[14].Lesson(0); students[14].Lesson(0);
            students[15].Lesson(3); students[15].Lesson(3); students[15].Lesson(2); students[15].Lesson(3); students[15].Lesson(4); students[15].Lesson(5); students[15].Lesson(3); students[15].Lesson(5); students[15].Lesson(4); students[15].Lesson(2);
            students[16].Lesson(4); students[16].Lesson(2); students[16].Lesson(5); students[16].Lesson(3); students[16].Lesson(2); students[16].Lesson(4); students[16].Lesson(3); students[16].Lesson(2); students[16].Lesson(5); students[16].Lesson(0);
            students[17].Lesson(4); students[17].Lesson(5); students[17].Lesson(4); students[17].Lesson(3); students[17].Lesson(5); students[17].Lesson(4); students[17].Lesson(4); students[17].Lesson(3); students[17].Lesson(4); students[17].Lesson(4);
            students[18].Lesson(4); students[18].Lesson(2); students[18].Lesson(5); students[18].Lesson(2); students[18].Lesson(2); students[18].Lesson(2); students[18].Lesson(4); students[18].Lesson(2); students[18].Lesson(0); students[18].Lesson(0);
            students[19].Lesson(4); students[19].Lesson(4); students[19].Lesson(3); students[19].Lesson(5); students[19].Lesson(4); students[19].Lesson(3); students[19].Lesson(5); students[19].Lesson(5); students[19].Lesson(5); students[19].Lesson(3);

            White_3.Student.SortBySkipped(students);

            foreach (var student in students)
            {
                student.Print();
            }

            Console.WriteLine("\n========================================================================");
            Console.WriteLine("White_4");
            Console.WriteLine("========================================================================\n");

            White_4.Participant[] participants4 = new White_4.Participant[]
            {
                new White_4.Participant("Мирослав", "Тихонов"),
                new White_4.Participant("Артем", "Лисицын"),
                new White_4.Participant("Алиса", "Ушакова"),
                new White_4.Participant("Никита", "Батов"),
                new White_4.Participant("Игорь", "Ушаков"),
                new White_4.Participant("Екатерина", "Тихонова"),
                new White_4.Participant("Екатерина", "Луговая"),
                new White_4.Participant("Артем", "Иванов"),
                new White_4.Participant("Дмитрий", "Распутин"),
                new White_4.Participant("Александр", "Полевой")
            };

            participants4[0].PlayMatch(0.5); participants4[0].PlayMatch(1.0); participants4[0].PlayMatch(0.5); participants4[0].PlayMatch(1.0);
            participants4[0].PlayMatch(0); participants4[0].PlayMatch(0.5); participants4[0].PlayMatch(0.5); participants4[0].PlayMatch(0.5);
            participants4[0].PlayMatch(0.5); participants4[0].PlayMatch(0.5);

            participants4[1].PlayMatch(0.0); participants4[1].PlayMatch(1.0); participants4[1].PlayMatch(0.0); participants4[1].PlayMatch(1.0);
            participants4[1].PlayMatch(1.0); participants4[1].PlayMatch(0.0); participants4[1].PlayMatch(0.0); participants4[1].PlayMatch(1.0);
            participants4[1].PlayMatch(0.0); participants4[1].PlayMatch(1.0);

            participants4[2].PlayMatch(0.0); participants4[2].PlayMatch(0.5); participants4[2].PlayMatch(0.0); participants4[2].PlayMatch(1.0);
            participants4[2].PlayMatch(1.0); participants4[2].PlayMatch(1.0); participants4[2].PlayMatch(0.5); participants4[2].PlayMatch(0.5);
            participants4[2].PlayMatch(1.0); participants4[2].PlayMatch(0.5);

            participants4[3].PlayMatch(0.0); participants4[3].PlayMatch(1.0); participants4[3].PlayMatch(0.5); participants4[3].PlayMatch(0.5);
            participants4[3].PlayMatch(0.5); participants4[3].PlayMatch(1.0); participants4[3].PlayMatch(0.5); participants4[3].PlayMatch(1.0);
            participants4[3].PlayMatch(0.5); participants4[3].PlayMatch(1.0);

            participants4[4].PlayMatch(0.5); participants4[4].PlayMatch(1.0); participants4[4].PlayMatch(0.5); participants4[4].PlayMatch(1.0);
            participants4[4].PlayMatch(1.0); participants4[4].PlayMatch(0.5); participants4[4].PlayMatch(0.0); participants4[4].PlayMatch(0.0);
            participants4[4].PlayMatch(0.0); participants4[4].PlayMatch(0.0);

            participants4[5].PlayMatch(0.5); participants4[5].PlayMatch(1.0); participants4[5].PlayMatch(0.5); participants4[5].PlayMatch(0.0);
            participants4[5].PlayMatch(0.0); participants4[5].PlayMatch(0.0); participants4[5].PlayMatch(1.0); participants4[5].PlayMatch(0.5);
            participants4[5].PlayMatch(1.0); participants4[5].PlayMatch(1.0);

            participants4[6].PlayMatch(0.5); participants4[6].PlayMatch(0.0); participants4[6].PlayMatch(1.0); participants4[6].PlayMatch(0.5);
            participants4[6].PlayMatch(0.5); participants4[6].PlayMatch(1.0); participants4[6].PlayMatch(1.0); participants4[6].PlayMatch(1.0);
            participants4[6].PlayMatch(1.0); participants4[6].PlayMatch(0.0);

            participants4[7].PlayMatch(0.0); participants4[7].PlayMatch(0.0); participants4[7].PlayMatch(1.0); participants4[7].PlayMatch(0.0);
            participants4[7].PlayMatch(0.5); participants4[7].PlayMatch(0.5); participants4[7].PlayMatch(0.5); participants4[7].PlayMatch(1.0);
            participants4[7].PlayMatch(0.5); participants4[7].PlayMatch(0.5);

            participants4[8].PlayMatch(0.0); participants4[8].PlayMatch(1.0); participants4[8].PlayMatch(1.0); participants4[8].PlayMatch(1.0);
            participants4[8].PlayMatch(0.5); participants4[8].PlayMatch(0.0); participants4[8].PlayMatch(1.0); participants4[8].PlayMatch(0.5);
            participants4[8].PlayMatch(0.0); participants4[8].PlayMatch(1.0);

            participants4[9].PlayMatch(0.5); participants4[9].PlayMatch(0.0); participants4[9].PlayMatch(0.0); participants4[9].PlayMatch(0.0);
            participants4[9].PlayMatch(0.0); participants4[9].PlayMatch(0.0); participants4[9].PlayMatch(0.5); participants4[9].PlayMatch(0.0);
            participants4[9].PlayMatch(0.0); participants4[9].PlayMatch(1.0);

            White_4.Participant.Sort(participants4);

            foreach (var participant in participants4) {
                participant.Print();
            }

            Console.WriteLine("\n========================================================================");
            Console.WriteLine("White_5");
            Console.WriteLine("========================================================================\n");

            White_5.Team[] teams = new White_5.Team[] {
                new White_5.Team("Югра"), new White_5.Team("СПБ"), new White_5.Team("Металлург"), new White_5.Team("СКА"),
                new White_5.Team("Львы"), new White_5.Team("Нефтехим"), new White_5.Team("Ак-барс"), new White_5.Team("Магнит"),
                new White_5.Team("Урал"), new White_5.Team("Василек")
            };

            ///
            /// Ошибка в Output: Львы должны идти прежде, чем Василек, т.к. сортировка устойчивая
            ///
            teams[0].PlayMatch(0, 2); teams[0].PlayMatch(0, 0); teams[0].PlayMatch(2, 4); teams[0].PlayMatch(2, 4);
            teams[0].PlayMatch(3, 0); teams[0].PlayMatch(0, 1); teams[0].PlayMatch(1, 1); teams[0].PlayMatch(4, 0);
            teams[0].PlayMatch(4, 3); teams[0].PlayMatch(5, 3);
            
            teams[1].PlayMatch(0, 3); teams[1].PlayMatch(0, 1); teams[1].PlayMatch(5, 2); teams[1].PlayMatch(2, 4);
            teams[1].PlayMatch(3, 4); teams[1].PlayMatch(4, 0); teams[1].PlayMatch(3, 0); teams[1].PlayMatch(5, 3);
            teams[1].PlayMatch(4, 1); teams[1].PlayMatch(2, 2);
            
            teams[2].PlayMatch(4, 0); teams[2].PlayMatch(4, 4); teams[2].PlayMatch(0, 1); teams[2].PlayMatch(0, 1);
            teams[2].PlayMatch(1, 0); teams[2].PlayMatch(4, 1); teams[2].PlayMatch(0, 0); teams[2].PlayMatch(2, 4);
            teams[2].PlayMatch(5, 3); teams[2].PlayMatch(5, 3);
            
            teams[3].PlayMatch(0, 2); teams[3].PlayMatch(4, 4); teams[3].PlayMatch(0, 1); teams[3].PlayMatch(5, 1);
            teams[3].PlayMatch(3, 3); teams[3].PlayMatch(5, 0); teams[3].PlayMatch(0, 4); teams[3].PlayMatch(3, 2);
            teams[3].PlayMatch(0, 3); teams[3].PlayMatch(4, 2);
            
            teams[4].PlayMatch(5, 3); teams[4].PlayMatch(2, 0); teams[4].PlayMatch(5, 2); teams[4].PlayMatch(1, 3);
            teams[4].PlayMatch(4, 3); teams[4].PlayMatch(1, 3); teams[4].PlayMatch(0, 3); teams[4].PlayMatch(4, 2);
            teams[4].PlayMatch(3, 3); teams[4].PlayMatch(3, 2);
            
            teams[5].PlayMatch(3, 4); teams[5].PlayMatch(1, 2); teams[5].PlayMatch(1, 1); teams[5].PlayMatch(4, 0);
            teams[5].PlayMatch(4, 2); teams[5].PlayMatch(2, 3); teams[5].PlayMatch(0, 3); teams[5].PlayMatch(4, 0);
            teams[5].PlayMatch(2, 2); teams[5].PlayMatch(2, 3);
            
            teams[6].PlayMatch(4, 0); teams[6].PlayMatch(1, 2); teams[6].PlayMatch(2, 2); teams[6].PlayMatch(1, 1);
            teams[6].PlayMatch(1, 2); teams[6].PlayMatch(1, 1); teams[6].PlayMatch(2, 0); teams[6].PlayMatch(2, 1);
            teams[6].PlayMatch(3, 1); teams[6].PlayMatch(0, 2);
            
            teams[7].PlayMatch(2, 2); teams[7].PlayMatch(4, 4); teams[7].PlayMatch(0, 0); teams[7].PlayMatch(1, 4);
            teams[7].PlayMatch(3, 0); teams[7].PlayMatch(4, 0); teams[7].PlayMatch(1, 0); teams[7].PlayMatch(0, 1);
            teams[7].PlayMatch(0, 0); teams[7].PlayMatch(4, 1);
            
            teams[8].PlayMatch(2, 4); teams[8].PlayMatch(2, 4); teams[8].PlayMatch(5, 4); teams[8].PlayMatch(3, 4);
            teams[8].PlayMatch(4, 3); teams[8].PlayMatch(1, 1); teams[8].PlayMatch(1, 2); teams[8].PlayMatch(0, 1);
            teams[8].PlayMatch(0, 4); teams[8].PlayMatch(0, 2);
            
            teams[9].PlayMatch(1, 3); teams[9].PlayMatch(5, 2); teams[9].PlayMatch(4, 1); teams[9].PlayMatch(5, 1);
            teams[9].PlayMatch(1, 0); teams[9].PlayMatch(4, 1); teams[9].PlayMatch(1, 0); teams[9].PlayMatch(4, 4);
            teams[9].PlayMatch(1, 3); teams[9].PlayMatch(1, 2);

            foreach (var team in teams) {
                team.Print();
            }

            Console.WriteLine("\n\n\n");

            White_5.Team.SortTeams(teams);

            foreach (var team in teams) {
                team.Print();
            }
        }
    }
}