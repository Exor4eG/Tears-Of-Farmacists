using System.Collections.Generic;

namespace Model
{
    public class User
    {
        public string id;
        public string name;
        public List<Result> results;

        public User(string name, string id)
        {
            this.name = name;
            this.id = id;
            results = new List<Result>();
        }

        /// <summary>
        /// Добавление нового результата
        /// </summary>
        /// <param Обьект с результатами="result"></param>
        public void UpdateResult(Result result)
        {
            results.Add(result);
        }
    }
}
