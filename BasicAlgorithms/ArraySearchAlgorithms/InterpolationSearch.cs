﻿using BasicAlgorithms.ArraySearchAlgorithms.Interfaces;
using BasicAlgorithms.ArraySearchAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.ArraySearchAlgorithms
{
    public class InterpolationSearch : ISearch
    {

        /// <summary>
        /// Interpolation Search  [Time: O(log(log(n))), Space: O(1)]
        /// </summary>
        /// <param name="data">The array to search</param>
        /// <param name="value">The value to search</param>
        /// <returns>SearchResult object with statistics</returns>
        public SearchResult Find(List<int> data, int value)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var searchResult = new SearchResult();

            var start = 0;
            var end = data.Count - 1;
            int pos = -1;
            while (start <= end)
            {
                searchResult.Cycles++;

                pos = (int)(start + (((double)(end - start) / (data[end] - data[start])) * (value - data[start])));
                if (pos < 0 || pos > data.Count - 1)
                {
                    pos = -1;
                    break;
                }

                if (data[pos] == value)
                    break;

                if (value > data[pos])
                    start = pos + 1;
                else
                    end = pos - 1;
            }

            if (pos >= 0 && data[pos] == value)
            {
                watch.Stop();
                searchResult.PositionFound = pos;
                searchResult.Ticks = watch.ElapsedTicks;
            }

            return searchResult;
        }
    }
}