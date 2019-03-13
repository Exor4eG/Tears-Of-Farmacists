using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Система классов для хранения данных путём сериализации
    /// </summary>
    [Serializable]
    public class TestData
    {
        public TestData() { subjects = new List<Subject>(); setting = new Setting(); info = string.Empty; }
        public TestData(Setting s, List<Subject> sub, string i)
        {
            setting = s;
            subjects = sub;
            info = i;
        }
        protected Setting setting;
        protected List<Subject> subjects;
        protected string info;
        public Setting Setting { get { return setting; } set { setting = value; } }
        public List<Subject> Subjects { get { return subjects; } set { subjects = value; } }
        public string Info { get { return info; } set { info = value; } }
    }
    /// <summary>
    /// Класс с дополнительными параметрами для теста
    /// </summary>
    [Serializable]
    public class Setting
    {
        public Setting() { }
        public Setting(int time)
        {
            this.time = time;
        }
        protected int time;
        public int Time { get { return time; } set { time = value; } }

    }
    /// <summary>
    /// Класс хранящий тему и ссылки на вопросы
    /// </summary>
    [Serializable]
    public class Subject
    {
        public Subject(string n) { name = n; }
        public Subject() { questions = new List<Question>(); }
        public Subject(string n, int q, List<Question> que)
        {
            Name = n;
            qCount = q;
            questions = que;
        }

        protected string name;
        protected int qCount;
        protected List<Question> questions = new List<Question>();

        public string Name { get { return name; } set { name = value; } }
        public int QCount { get { return qCount; } set { qCount = value; } }
        public List<Question> Questions { get { return questions; } set { questions = value; } }
    }
    /// <summary>
    /// Класс хранящий вопрос и ссылки на ответы
    /// </summary>
    [Serializable]
    public class Question
    {
        public Question(string s) { name = s; }
        public Question()
        {
            name = "Новый";
            answers = new List<Answer>() { new Answer(), new Answer(), new Answer(), new Answer() };
        }
        public Question(string n, List<Answer> a)
        {
            name = n;
            answers = a;
        }
        protected string name;
        protected List<Answer> answers = new List<Answer>();

        public string Name { get { return name; } set { name = value; } }
        public List<Answer> Answers { get { return answers; } set { answers = value; } }
    }
    /// <summary>
    /// Класс хранящий ответ и его параметры
    /// </summary>
    [Serializable]
    public class Answer
    {
        public Answer(string s) { name = s; }
        public Answer()
        {
            name = "Новый";
        }
        public Answer(string n, bool t)
        {
            name = n;
            isTrue = t;
        }
        protected string name;
        protected bool isTrue;

        public string Name { get { return name; } set { name = value; } }
        public bool IsTrue { get { return isTrue; } set { isTrue = value; } }
    }
}
