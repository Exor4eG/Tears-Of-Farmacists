﻿using System;

namespace Model
{
    public class Result
    {
        public string date;
        public string r1;
        public string r2;
        public string r3;
        public string r4;
        public Result(string r1, string r2, string r3, string r4, string date)
        {
            this.r1 = r1;
            this.r2 = r2;
            this.r3 = r3;
            this.r4 = r4;
            this.date = date;
        }
        public Result()
        {
            r1 = "0";
            r2 = "0";
            r3 = "0";
            r4 = "0";
            date = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
        }
    }
}
