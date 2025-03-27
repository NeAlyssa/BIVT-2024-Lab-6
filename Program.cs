using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_1;
using static Lab_6.Blue_5;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
        }
        static void Task1()
        {
            var names = "Татьяна Никита Мирослав Артем Алевтина Максим Марина Григорий Екатерина Оксана Марина Инесса Алиса Влада Дарья Сергей Степан Ольга Михаил Григорий Инесса Юрий Григорий Игорь Ольга Юрий Татьяна Михаил Дарья Степан".Split(' ');
            var surnames = "Степанова Жарков Петров Тихонов Тихонова Степанов Батова Сидоров Чехова Кристиан Пономарева Смирнова Распутина Степанова Пономарева Тихонов Иванов Зайцева Иванов Ушаков Лисицына Иванов Козлов Петров Тихонова Иванов Чехова Свиридов Павлова Павлов".Split(' ');
            var r = new Blue_1.Response[30];
            for (int i = 0; i < 30; i++) 
            { 
                r[i]= new Blue_1.Response(names[i],surnames[i]);
            }
            for (int i = 0; i < 30; i++)
            {
                r[i].CountVotes(r);
            }
            for (int i = 0; i < 30; i++)
            {
                r[i].Print();
            }
        }

        static void Task2()
        {
            var name = "Александр Артем Мария Игорь Николай Инесса Марина Александр Сергей Александра".Split(' ');
            var surname = "Петров Луговой Свиридова Смирнов Зайцев Кристиан Свиридова Петров Батов Сидорова".Split(' ');
            Blue_2.Participant[] participant = new Blue_2.Participant[10];
            for (int i = 0;i < 10; i++)
            {
                participant[i]=new Blue_2.Participant(name[i],surname[i]);
            }
            participant[0].Jump(new int[] { 11, 0, 8, 7, 12 });
            participant[0].Jump(new int[] { 2, 3, 10, 13, 16 });
            participant[1].Jump(new int[] { 18, 17, 20, 7, 11 });
            participant[1].Jump(new int[] { 3, 7, 12, 19, 2 });
            participant[2].Jump(new int[] { 17, 13, 2, 19, 2 });
            participant[2].Jump(new int[] { 10, 0, 0, 6, 5 });
            participant[3].Jump(new int[] { 15, 7, 14, 19, 15 });
            participant[3].Jump(new int[] { 5, 13, 16, 18, 16 });
            participant[4].Jump(new int[] { 20, 5, 4, 3, 0 });
            participant[4].Jump(new int[] { 18, 4, 12, 18, 7 });
            participant[5].Jump(new int[] { 5, 17, 20, 2, 11 });
            participant[5].Jump(new int[] { 10, 18, 9, 7, 12 });
            participant[6].Jump(new int[] { 18, 1, 10, 5, 20 });
            participant[6].Jump(new int[] { 19, 1, 5, 1, 18 });
            participant[7].Jump(new int[] { 2, 17, 5, 11, 3 });
            participant[7].Jump(new int[] { 7, 18, 3, 5, 3 });
            participant[8].Jump(new int[] { 2, 0, 5, 18, 20 });
            participant[8].Jump(new int[] { 3, 12, 4, 2, 10 });
            participant[9].Jump(new int[] { 12, 2, 17, 5, 7 });
            participant[9].Jump(new int[] { 5, 15, 15, 5, 11});
           
            Blue_2.Participant.Sort(participant);

            for (int i = 0; i < 10; i++)
            {
                participant[i].Print();
            }
        }

        static void Task3()
        {
            var name = "Инна Юрий Дмитрий Иван Татьяна Александра Дарья Мирослав Юлия Дарья".Split(' ');
            var surname = "Пономарева Ушаков Иванов Кристиан Ушакова Козлова Павлова Лисицын Чехова Лисицына".Split(' ');
            var p0 = new int[] { 2, 2, 0, 2, 0, 0, 0, 5, 2, 5 };
            var p1 = new int[] { 0, 10, 10, 0, 5, 5, 2, 10, 10, 10 };
            var p2 = new int[] { 2, 5, 5, 2, 0, 10, 5, 2, 0, 0 };
            var p3 = new int[] { 2, 10, 2, 5, 2, 2, 10, 10, 5, 0 };
            var p4 = new int[] { 5, 2, 0, 10, 10, 2, 10, 5, 0, 2 };
            var p5 = new int[] { 5, 2, 5, 0, 0, 10, 5, 5, 2, 10 };
            var p6 = new int[] { 0, 2, 0, 2, 0, 10, 5, 0, 2, 10 };
            var p7 = new int[] { 0, 2, 2, 10, 10, 2, 5, 2, 5, 0 };
            var p8 = new int[] { 0, 10, 5, 10, 5, 5, 5, 2, 5, 2 };
            var p9 = new int[] { 5, 2, 5, 0, 10, 10, 0, 0, 0, 2 };


            Blue_3.Participant[] participant = new Blue_3.Participant[10];
            for (int i = 0; i < 10; i++)
            {
                participant[i] = new Blue_3.Participant(name[i], surname[i]);
            }
            foreach (var p in p0) participant[0].PlayMatch(p);
            foreach (var p in p1) participant[1].PlayMatch(p);
            foreach (var p in p2) participant[2].PlayMatch(p);
            foreach (var p in p3) participant[3].PlayMatch(p);
            foreach (var p in p4) participant[4].PlayMatch(p);
            foreach (var p in p5) participant[5].PlayMatch(p);
            foreach (var p in p6) participant[6].PlayMatch(p);
            foreach (var p in p7) participant[7].PlayMatch(p);
            foreach (var p in p8) participant[8].PlayMatch(p);
            foreach (var p in p9) participant[9].PlayMatch(p);

            Blue_3.Participant.Sort(participant);
            foreach (var n in participant) n.Print();
        }
        static void Task4()
        {
            var name1 = "Энергия Спартак Барс Нефтехим Байкал Василек Урал Быки Метеор Быки ЦСКА Русь".Split(' ');
            var name2 = "Локомотив СКА Энергия Нефтехим Ак-брс Барс СПБ Быки Метеор Быки ЦСКА Русь".Split(' ');
            Blue_4.Team[] oneplayteams = new Blue_4.Team[12];
            for(int i = 0; i < 12; i++)
            {
                oneplayteams[i] = new Blue_4.Team(name1[i]);
            }
            foreach (var score in new int[] { 1, 0, 0, 0, 3, 0, 1, 0, 1, 3, 0, 0 }) oneplayteams[0].PlayMatch(score);
            foreach (var score in new int[] { 0, 0, 1, 3, 3, 1, 0, 3, 0, 3, 1, 3, 3, 0, 1, 1, 1, 1, 0, 1 }) oneplayteams[1].PlayMatch(score);
            foreach (var score in new int[] { 0, 3, 0, 0, 3, 1, 0, 1, 0, 3, 0, 0, 3, 1, 1, 3, 0, 1, 0, 0 }) oneplayteams[2].PlayMatch(score);
            foreach (var score in new int[] { 3, 1, 1, 0, 1, 0, 1, 3, 1, 3, 1, 0, 1, 1, 0, 1, 3, 3, 3, 0 }) oneplayteams[3].PlayMatch(score);
            foreach (var score in new int[] { 1, 0, 1, 0, 0, 1, 3, 1, 3, 3, 3, 1, 3, 3, 0, 1, 0, 0, 0, 0 }) oneplayteams[4].PlayMatch(score);
            foreach (var score in new int[] { 1, 3, 3, 3, 3, 3, 1, 3, 3, 0, 1, 3, 3, 0, 1, 0, 0, 3, 0, 3 }) oneplayteams[5].PlayMatch(score);
            foreach (var score in new int[] { 0, 1, 3, 1, 1, 0, 0, 0, 3, 3, 1, 3, 3, 3, 0, 0, 3, 3, 3, 0 }) oneplayteams[6].PlayMatch(score);
            foreach (var score in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) oneplayteams[7].PlayMatch(score);
            foreach (var score in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) oneplayteams[8].PlayMatch(score);
            foreach (var score in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) oneplayteams[9].PlayMatch(score);
            foreach (var score in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) oneplayteams[10].PlayMatch(score);
            foreach (var score in new int[] { 1, 1, 1, 3, 0, 3, 3, 0, 3, 3, 3, 1 }) oneplayteams[11].PlayMatch(score);

            Blue_4.Group group1 = new Blue_4.Group("группа1");
            foreach (var team in oneplayteams) { group1.Add(team); }
            group1.Sort();

            Blue_4.Team[] twoplayteams = new Blue_4.Team[12];
            for (int i = 0; i < 12; i++)
            {
                twoplayteams[i] = new Blue_4.Team(name2[i]);
            }
            foreach (var score in new int[] { 1, 1, 3, 0, 3, 0, 1, 0, 3, 3, 3, 3 }) twoplayteams[0].PlayMatch(score);
            foreach (var score in new int[] { 0, 0, 1, 0, 3, 1, 0, 3, 1, 3, 1, 3, 3, 1, 1, 1, 0, 3, 1, 1 }) twoplayteams[1].PlayMatch(score);
            foreach (var score in new int[] { 1, 1, 3, 3, 0, 0, 3, 3, 1, 0, 3, 0, 0, 1, 0, 3, 1, 1, 0, 1 }) twoplayteams[2].PlayMatch(score);
            foreach (var score in new int[] { 1, 3, 3, 1, 1, 3, 3, 1, 3, 3, 1, 1, 0, 3, 0, 3, 1, 3, 1, 1 }) twoplayteams[3].PlayMatch(score);
            foreach (var score in new int[] { 0, 3, 1, 1, 1, 0, 3, 1, 0, 3, 0, 0, 1, 3, 3, 1, 1, 3, 0, 0 }) twoplayteams[4].PlayMatch(score);
            foreach (var score in new int[] { 3, 1, 0, 0, 3, 1, 0, 1, 3, 0, 0, 1, 3, 0, 0, 0, 3, 0, 3, 1 }) twoplayteams[5].PlayMatch(score);
            foreach (var score in new int[] { 0, 1, 1, 3, 0, 1, 3, 0, 3, 3, 0, 0, 0, 3, 3, 1, 1, 0, 3, 1 }) twoplayteams[6].PlayMatch(score);
            foreach (var score in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) twoplayteams[7].PlayMatch(score);
            foreach (var score in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) twoplayteams[8].PlayMatch(score);
            foreach (var score in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) twoplayteams[9].PlayMatch(score);
            foreach (var score in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) twoplayteams[10].PlayMatch(score);
            foreach (var score in new int[] { 1, 1, 1, 3, 0, 3, 3, 0, 3, 3, 3, 1 }) twoplayteams[11].PlayMatch(score);
            Blue_4.Group group2 = new Blue_4.Group("группа2");
            foreach (var team in twoplayteams) { group2.Add(team); }
            group2.Sort();
            Blue_4.Group.Merge(group1, group2, 12).Print();
        }
        static void Task5()
        {
            Blue_5.Sportsman[] Sportsman = new Blue_5.Sportsman[]
            {
                new Blue_5.Sportsman("Мирослав", "Распутин"),
                new Blue_5.Sportsman("Игорь", "Павлов"),
                new Blue_5.Sportsman("Полина", "Свиридова"),
                new Blue_5.Sportsman("Савелий", "Луговой"),
                new Blue_5.Sportsman("Николай", "Козлов"),
                new Blue_5.Sportsman("Юлия", "Сидорова"),

                new Blue_5.Sportsman("Полина", "Луговая"),
                new Blue_5.Sportsman("Светлана", "Иванова"),
                new Blue_5.Sportsman("Александр", "Петров"),
                new Blue_5.Sportsman("Игорь", "Распутин"),
                new Blue_5.Sportsman("Савелий", "Свиридов"),
                new Blue_5.Sportsman("Мария", "Свиридова"),

                new Blue_5.Sportsman("Дмитрий", "Свиридов"),
                new Blue_5.Sportsman("Светлана", "Козлова"),
                new Blue_5.Sportsman("Екатерина", "Луговая"),
                new Blue_5.Sportsman("Степан", "Жарков"),
                new Blue_5.Sportsman("Степан", "Распутин"),
                new Blue_5.Sportsman("Дарья", "Свиридова") };

            int[] places = { 
                12, 2, 17, 13, 5, 6, 
                7, 8, 9, 10, 11, 1,
                4, 14, 15, 16, 3, 18 };
            for (int i = 0; i < Sportsman.Length; i++) 
            { 
                Sportsman[i].SetPlace(places[i]); 
            }
            for (int i = 0; i < Sportsman.Length; i++)
            {
                Sportsman[i].Print();
            }
            
            Blue_5.Team[] teams = new Blue_5.Team[]
            {
                new Blue_5.Team("Локомотив"),
                new Blue_5.Team("Динамо"),
                new Blue_5.Team("Спартак") };

            teams[0].Add(new Sportsman[] { 
                Sportsman[0], Sportsman[1], Sportsman[2],
                Sportsman[3], Sportsman[4], Sportsman[5] });

            teams[1].Add(new Sportsman[] {
                Sportsman[6], Sportsman[7], Sportsman[8],
                Sportsman[9], Sportsman[10], Sportsman[11] });

            teams[2].Add(new Sportsman[] { 
                Sportsman[12], Sportsman[13], Sportsman[14], 
                Sportsman[15], Sportsman[16], Sportsman[17] });

            Blue_5.Team.Sort(teams);
        
            foreach (var team in teams)
            {
                team.Print();
            }
        }
    }
}
