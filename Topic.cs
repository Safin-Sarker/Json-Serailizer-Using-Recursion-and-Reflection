﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_Serailizer_Using_Recursion_and_Reflection
{
    public class Topic
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Session> Sessions { get; set; }
    }
}