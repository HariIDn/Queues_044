﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_044
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Queues()
        {
            //memberi nilai pada variabel REAR dan FRONT
            FRONT = -1;
            REAR = -1;
        }

        public void insert(int element)
        {
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue Overflow\n");
                return;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
