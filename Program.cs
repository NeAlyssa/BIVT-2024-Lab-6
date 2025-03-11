using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 номер
            /*
            Purple_1.Participant n1 = new Purple_1.Participant("Дарья", "Тихонова");
            n1.SetCriterias(new double[] { 2.58, 2.9, 3.04, 3.43 });
            n1.Jump(new int[] { 3, 4, 1, 2, 1, 3, 1 });
            n1.Jump(new int[] { 5, 3, 4, 3, 3, 3, 3 });
            n1.Jump(new int[] { 2, 4, 1, 5, 6, 1, 2 });
            n1.Jump(new int[] { 6, 4, 3, 2, 2, 1, 1 });
            n1.Print();
            Console.WriteLine();
            Purple_1.Participant n2 = new Purple_1.Participant("Максим", "Тихонов");
            n2.SetCriterias(new double[] { 3.14, 3.46, 2.96, 2.76, });
            n2.Jump(new int[] { 3, 3, 1, 4, 5, 6, 2 });
            n2.Jump(new int[] { 6, 4, 5, 4, 2, 3, 1 });
            n2.Jump(new int[] { 3, 3, 4, 2, 2, 3, 6 });
            n2.Jump(new int[] { 5, 1, 5, 5, 1, 3, 4 });
            n2.Print();
            Console.WriteLine();
            Purple_1.Participant[] arr = new Purple_1.Participant[2];
            arr[0] = n1; arr[1] = n2;
            foreach (Purple_1.Participant x in arr) x.Print();
            Console.WriteLine();
            Purple_1.Participant.Sort(arr);
            foreach (Purple_1.Participant x in arr) x.Print();
            */


            //2 номер



            
             /*
            var names = "Оксана Полина Дмитрий Евгения Савелий Евгения Егор Степан Анастасия Светлана".Split();
            var surnames = "Сидорова Полевая Полевой Распутина Луговой Павлова Свиридов Свиридов Козлова Свиридова".Split();
            int[] distances = new int[] { 135, 191, 147, 115, 112, 151, 186, 166, 112, 197 };
            var marks = "15,1,3,9,15,19,14,9,11,4,20,9,1,13,6,5,20,17,9,16,19,8,1,6,17,16,12,5,20,4,5,20,3,19,18,16,12,5,4,15,7,4,19,11,12,14,3,6,17,1".Split(',');
            Purple_2.Participant[] array = new Purple_2.Participant[10];
            int n = 0;
            for(int i = 0; i<10; i++)
            {
                Purple_2.Participant temp = new Purple_2.Participant(names[i], surnames[i]);
                int[] mark = new int[5];
                for (int j = 0; j < mark.Length; j++) mark[j] = int.Parse(marks[n++]);
                temp.Jump(distances[i], mark);
                array[i] = temp;
                array[i].Print();
            }
            Console.WriteLine("Сортировка");
            Purple_2.Participant.Sort(array);
            foreach (var x in array) x.Print();*/


            //3 номер
            /*
            var names = "Виктор,Полевой,Алиса,Козлова,Ярослав,Зайцев,Савелий,Кристиан,Алиса,Козлова,Алиса,Луговая,Александр,Петров,Мария,Смирнова,Полина,Сидорова,Татьяна,Сидорова,,".Split(',');
            var marks = new double[] { 5.93, 5.44, 1.20, 0.28, 1.57, 1.86, 5.89, 1.68, 3.79, 3.62, 2.76, 4.47, 4.26, 5.79, 2.93, 3.10, 5.46, 4.88, 3.99, 4.79, 5.56, 4.20, 4.69, 3.90, 1.67, 1.13, 5.66, 5.40, 3.27, 2.43, 0.90, 5.61, 3.12, 3.76, 3.73, 0.75, 1.13, 5.43, 2.07, 2.68, 0.83, 3.68, 3.78, 3.42, 3.84, 2.19, 1.20, 2.51, 3.51, 1.35, 3.40, 1.85, 2.02, 2.78, 3.23, 3.03, 0.55, 5.93, 0.75, 5.15, 4.35, 1.51, 2.77, 3.86, 0.19, 0.46, 5.14, 5.37, 0.94, 0.84, };
            int ind = 0;
            var part = new Purple_3.Participant[10];
            for (int i = 0; i < 10; i++)
            {
                part[i] = new Purple_3.Participant(names[i * 2], names[i * 2 + 1]);
                for (int j = 0; j < 7; j++)
                {
                    part[i].Evaluate(marks[ind++]);
                }
            }
            foreach (var x in part) x.Print();
            Console.WriteLine();
            Purple_3.Participant.SetPlaces(part);
            Console.WriteLine("УСТАНОВИЛИ МЕСТА");
            foreach (var x in part) x.Print();
            Console.WriteLine();
            Purple_3.Participant.Sort(part);
            Console.WriteLine("СОРТИРОВКА");
            foreach (var x in part) x.Print();
            */

            //4 номер:
            /*
            var names1 = "Полина,Луговая,Савелий,Козлов,Екатерина,Жаркова,Дмитрий,Иванов,Дмитрий,Полевой,Савелий,Петров,Евгения,Распутина,Екатерина,Луговая,Мария,Иванова,Степан,Павлов,Ольга,Павлова,Ольга,Полевая,Дарья,Павлова,Дарья,Свиридова,Евгения,Свиридова".Split(',');
            var names2 = "Анастасия,Жаркова,Александр,Павлов,Степан,Свиридов,Игорь,Сидоров,Евгения,Сидорова,Мария,Сидорова,Лев,Петров,Савелий,Козлов,Егор,Свиридов,Оксана,Жаркова,Светлана,Петрова,Полина,Петрова,Екатерина,Павлова,Юлия,Полевая,Евгения,Павлова".Split(',');
            var times1 = new double[] { 422.64, 142.05, 185.23, 294.32, 79.26, 230.63, 35.16, 376.12, 279.20, 292.38, 467.60, 473.82, 290.14, 368.60, 212.67 };
            var times2 = new double[] { 112.49, 472.11, 213.92, 102.13, 263.21, 350.75, 248.68, 325.28, 300.00, 252.16, 402.20, 397.33, 384.94, 8.09, 480.52 };
            var sp1 = new Purple_4.Sportsman[15];
            for (int i = 0; i < sp1.Length; i++)
            {
                sp1[i] = new Purple_4.Sportsman(names1[i * 2], names1[i * 2 + 1]);
                sp1[i].Run(times1[i]);
            }
            var sp2 = new Purple_4.Sportsman[15];
            for (int i = 0; i < sp2.Length; i++)
            {
                sp2[i] = new Purple_4.Sportsman(names2[i * 2], names2[i * 2 + 1]);
                sp2[i].Run(times2[i]);
            }
            var g1 = new Purple_4.Group("group 1");
            g1.Add(sp1);
            var g2 = new Purple_4.Group("group 2");
            g2.Add(sp2);
            Console.WriteLine("1 group:");
            g1.Print();
            Console.WriteLine("2 группа:");
            g2.Print();
            g1.Sort();
            g2.Sort();
            Console.WriteLine("СОРТИРОВКА:");
            Console.WriteLine("1 group:");
            g1.Print();
            Console.WriteLine("2 группа:");
            g2.Print();
            var g = Purple_4.Group.Merge(g1, g2);
            Console.WriteLine("TOTAL:");
            g.Print();
            */


            //5
            
            var animals = "Макака,Тануки,Тануки,Кошка,Сима_энага,Макака,Панда,Сима_энага,Серау,Панда,Сима_энага,Кошка,Панда,Кошка,Панда,Серау,Панда,Сима_энага,Панда,Кошка".Split(',');
            var characterTraits = "-,Проницательность,Скромность,Внимательность,Дружелюбность,Внимательность,Проницательность,Проницательность,Внимательность,-,Дружелюбность,Внимательность,-,Уважительность,Целеустремленность,Дружелюбность,-,Скромность,Проницательность,Внимательность".Split(',');
            var concepts = "Манга,Манга,Кимоно,Суши,Кимоно,Самурай,Манга,Суши,Сакура,Кимоно,Сакура,Кимоно,Сакура,Фудзияма,Аниме,-,Манга,Фудзияма,Самурай,Сакура".Split(',');
            var research = new Purple_5.Research("Res 1");
            for (int i = 0; i < 20; i++)
            {
                research.Add(new string[] { animals[i], characterTraits[i], concepts[i] });
            }
            
            research.Print();
        }

    }
}
