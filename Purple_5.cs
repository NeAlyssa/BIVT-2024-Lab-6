using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using static Lab_6.Purple_4;

namespace Lab_6
{
    public class Purple_5
    {
        public struct Response
        {
            private string[] _answers;

            public string Animal
            {
                get
                {
                    if (_answers == null) return null;
                    string a = _answers[0];
                    return a;
                }
            }
            public string CharacterTrait
            {
                get
                {
                    if (_answers == null) return null;
                    string a = _answers[1];
                    return a;
                }
            }
            public string Concept
            {
                get
                {
                    if (_answers == null) return null;
                    string a = _answers[2];
                    return a;
                }
            }
            //private string[] Answers
            //{
            //    get
            //    {
            //        string[] p = new string[_answers.Length];
            //        for (int i = 0; i < _answers.Length; i++)
            //        {
            //            p[i] = _answers[i];
            //        }
            //        return p;
            //    }
            //}

            public Response(string animal, string charactertrait, string concept)
            {
                _answers = new string[3];
                _answers[0] = animal;
                _answers[1] = charactertrait;
                _answers[2] = concept;
            }

            public int CountVotes(Response[] responses, int questionNumber)
            {
                if (responses == null || questionNumber > 3 || questionNumber < 1) return 0;
                int s = 0;
                foreach (Response response in responses)
                {
                    if (response._answers[questionNumber - 1] != null && response._answers[questionNumber - 1] != "" && response._answers[questionNumber - 1] == _answers[questionNumber - 1])
                        s++;
                }
                return s;
            }
            public void Print()
            {
                Console.WriteLine(_answers[0] + " " + _answers[1] + " " + _answers[2]);
            }
        }
        public struct Research
        { 
            private string _name;
            private Response[] _responses;

            public string Name => _name;
            public Response[] Responses => _responses;


            public Research(string name)
            { 
                _name = name;
                _responses = new Response[0];
            }

            public void Add(string[] answers)
            {
                if (answers == null) return;
                Response[] r = new Response[_responses.Length + 1];
                for (int i = 0; i < _responses.Length; i++)
                {
                    r[i] = _responses[i];
                }
                Response n = new Response(answers[0], answers[1], answers[2]);
                r[_responses.Length] = n;
                _responses = r;
            }

            public string[] GetTopResponses(int question)
            {
                if (question == 1)
                {
                    string[] ans = new string[0];
                    for (int i = 0; i < _responses.Length; i++)
                    {
                        if (_responses[i].Animal == null || _responses[i].Animal == "") continue;
                        int flag = 0;
                        for (int j = 0; j < ans.Length; j++)
                        {
                            if (ans[j] == _responses[i].Animal)
                            {
                                flag = 1;
                                break;
                            }
                        }
                        if (flag != 1)
                        {
                            string[] anss = new string[ans.Length + 1];
                            for (int g = 0; g < ans.Length; g++)
                            {
                                anss[g] = ans[g];
                            }
                            anss[ans.Length] = _responses[i].Animal;
                            ans = anss;
                        }
                    }
                    int[] amount = new int[ans.Length];
                    for (int i = 0; i < ans.Length; i++)
                    {
                        for (int j = 0; j < _responses.Length; j++)
                        {
                            if (_responses[j].Animal == ans[i])
                            {
                                amount[i] += 1;
                            }
                        }
                    }

                    for (int i = 0; i < amount.Length; i++)
                    {
                        for (int j = 0; j < amount.Length - 1; j++)
                        {
                            if (amount[j] < amount[j + 1])
                            {
                                int l = amount[j];
                                string ll = ans[j];
                                amount[j] = amount[j + 1];
                                ans[j] = ans[j + 1];
                                amount[j + 1] = l;
                                ans[j + 1] = ll;
                            }
                        }
                    }
                    string[] an = new string[Math.Min(5, ans.Length)];
                    for (int i = 0; i < Math.Min(5, ans.Length); i++)
                    {
                        an[i] = ans[i];
                    }
                    return an;
                }
                else if (question == 2)
                {
                    string[] ans = new string[0];
                    for (int i = 0; i < _responses.Length; i++)
                    {
                        if (_responses[i].CharacterTrait == null || _responses[i].CharacterTrait == "") continue;
                        int flag = 0;
                        for (int j = 0; j < ans.Length; j++)
                        {
                            if (ans[j] == _responses[i].CharacterTrait)
                            {
                                flag = 1;
                                break;
                            }
                        }
                        if (flag != 1)
                        {
                            string[] anss = new string[ans.Length + 1];
                            for (int g = 0; g < ans.Length; g++)
                            {
                                anss[g] = ans[g];
                            }
                            anss[ans.Length] = _responses[i].CharacterTrait;
                            ans = anss;
                        }
                    }
                    int[] amount = new int[ans.Length];
                    for (int i = 0; i < ans.Length; i++)
                    {
                        for (int j = 0; j < _responses.Length; j++)
                        {
                            if (_responses[j].CharacterTrait == ans[i])
                            {
                                amount[i] += 1;
                            }
                        }
                    }

                    for (int i = 0; i < amount.Length; i++)
                    {
                        for (int j = 0; j < amount.Length - 1; j++)
                        {
                            if (amount[j] < amount[j + 1])
                            {
                                int l = amount[j];
                                string ll = ans[j];
                                amount[j] = amount[j + 1];
                                ans[j] = ans[j + 1];
                                amount[j + 1] = l;
                                ans[j + 1] = ll;
                            }
                        }
                    }
                    string[] an = new string[Math.Min(5, ans.Length)];
                    for (int i = 0; i < Math.Min(5, ans.Length); i++)
                    {
                        an[i] = ans[i];
                    }
                    return an;
                }
                else
                {
                    string[] ans = new string[0];
                    for (int i = 0; i < _responses.Length; i++)
                    {
                        if (_responses[i].Concept == null || _responses[i].Concept == "") continue;
                        int flag = 0;
                        for (int j = 0; j < ans.Length; j++)
                        {
                            if (ans[j] == _responses[i].Concept)
                            {
                                flag = 1;
                                break;
                            }
                        }
                        if (flag != 1)
                        {
                            string[] anss = new string[ans.Length + 1];
                            for (int g = 0; g < ans.Length; g++)
                            {
                                anss[g] = ans[g];
                            }
                            anss[ans.Length] = _responses[i].Concept;
                            ans = anss;
                        }
                    }
                    int[] amount = new int[ans.Length];
                    for (int i = 0; i < ans.Length; i++)
                    {
                        for (int j = 0; j < _responses.Length; j++)
                        {
                            if (_responses[j].Concept == ans[i])
                            {
                                amount[i] += 1;
                            }
                        }
                    }

                    for (int i = 0; i < amount.Length; i++)
                    {
                        for (int j = 0; j < amount.Length - 1; j++)
                        {
                            if (amount[j] < amount[j + 1])
                            {
                                int l = amount[j];
                                string ll = ans[j];
                                amount[j] = amount[j + 1];
                                ans[j] = ans[j + 1];
                                amount[j + 1] = l;
                                ans[j + 1] = ll;
                            }
                        }
                    }
                    string[] an = new string[Math.Min(5, ans.Length)];
                    for (int i = 0; i < Math.Min(5, ans.Length); i++)
                    {
                        an[i] = ans[i];
                    }
                    return an;
                }
            }
            public void Print()
            { 
                foreach (Response r in _responses)
                    r.Print();
            }
        }
    }
}
