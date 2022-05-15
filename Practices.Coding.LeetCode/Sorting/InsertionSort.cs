﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Sorting
{
    internal class InsertionSort
    {
        internal int[] Sort(int[] elements)
        {
            for(int index =1; index<elements.Length;index++)
            {
                var element = elements[index];
                var insertionIndex = index;
                while(insertionIndex>=1 && (elements[insertionIndex-1] > element))
                {
                    elements[insertionIndex] = elements[insertionIndex - 1];
                    insertionIndex--;
                }
                elements[insertionIndex] = element;
            }

            return elements;
        }
    }
}
