using System;
using System.Collections.Generic;
using System.Collections;

namespace QueueUI
{
    ///////////// MyNode //////////////////

    public class MyNode
    {
        public int Value { get; set; }
        public MyNode Next { get; set; }
        public MyNode Prev { get; set; }
    }
}