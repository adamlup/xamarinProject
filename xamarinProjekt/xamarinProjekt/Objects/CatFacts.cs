﻿using System;
using System.Collections.Generic;
using System.Text;

namespace xamarinProjekt.Objects
{
    public class CatFacts
    {
        public CatFacts()
        {}

        public bool used { get; set; }
        public string source { get; set; }
        public string type { get; set; }
        public bool deleted { get; set; }
        public string _id { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
        public string user { get; set; }
        public string text { get; set; }
        public int __v { get; set; }
        public Status status { get; set; }
    }

    public class Status
    {
        public bool verified { get; set; }
        public int sentCount { get; set; }
    }

}
