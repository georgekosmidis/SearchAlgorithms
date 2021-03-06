﻿using BasicAlgorithms.Array.DataProviders.Models;
using BasicAlgorithms.Arrays;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using BasicAlgorithmsArrays.SortingAlgorithms.Models;

namespace BasicAlgorithms.UI
{
    public class ArraySortUI : Grid
    {

        private ArraySortFactory _sortFactory;
        public ArraySortUI(ArraySortFactory sortFactory, int tableWith) : base(tableWith)
        {
            _sortFactory = sortFactory;
        }

        public void Print()
        {
            PrintLine();

            PrintRow("Ticks needed to sort " + _sortFactory.SampleSize + " integers");
            PrintLine();

            PrintLine();
            PrintRow("", "Random", "Reversed", "Sorted");
            PrintLine();

            PrintGrid("Insertion",
                _sortFactory.Estimate(eArraySortAlgorithms.Insertion, eArrayDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Insertion, eArrayDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Insertion, eArrayDataProviders.Sorted)
            );
            PrintGrid("Selection",
                _sortFactory.Estimate(eArraySortAlgorithms.Selection, eArrayDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Selection, eArrayDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Selection, eArrayDataProviders.Sorted)
            );
            PrintGrid("Bubble",
                _sortFactory.Estimate(eArraySortAlgorithms.Bubble, eArrayDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Bubble, eArrayDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Bubble, eArrayDataProviders.Sorted)
            );
            PrintGrid("Heap",
                _sortFactory.Estimate(eArraySortAlgorithms.Heap, eArrayDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Heap, eArrayDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Heap, eArrayDataProviders.Sorted)
            );
            PrintGrid("Merge",
                _sortFactory.Estimate(eArraySortAlgorithms.Merge, eArrayDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Merge, eArrayDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Merge, eArrayDataProviders.Sorted)
            );
            PrintGrid("Quick",
                _sortFactory.Estimate(eArraySortAlgorithms.Quick, eArrayDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Quick, eArrayDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Quick, eArrayDataProviders.Sorted)
            );
        }

        private void PrintGrid(string title, SortResults u, SortResults r, SortResults s)
        {

            PrintRow(title,
                u.Ticks.ToString("00000000"),
                r.Ticks.ToString("00000000"),
                s.Ticks.ToString("00000000")
            );
            PrintLine();
        }
    }
}
