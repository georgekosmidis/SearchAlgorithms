﻿using BasicAlgorithms.ArraySearchAlgorithms.Interfaces;
using BasicAlgorithms.ArraySearchAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.ArraySearchAlgorithms
{
    public class LinearSearch : ISearch
    {
        /// <summary>
        /// Linear Search [Time: O(n), Space: O(1)]
        /// </summary>
        /// <param name="data">The array to search</param>
        /// <param name="value">The value to search</param>
        /// <returns>SearchResult object with statistics</returns>
        public SearchResult Find(List<int> data, int value)
        {
            var searchResult = new SearchResult();
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (var i = 0; i < data.Count; i++)
            {
                searchResult.Cycles++;
                if (data[i] == value)
                {
                    searchResult.PositionFound = i;
                    break;
                }
            }

            watch.Stop();
            searchResult.Ticks = watch.ElapsedMilliseconds;
            return searchResult;
        }
    }
}