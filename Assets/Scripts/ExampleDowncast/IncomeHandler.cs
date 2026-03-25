using UnityEngine;
using System;
using System.Collections.Generic;

namespace ExampleDowncast
{
    public class IncomeHandler : IDisposable
    {
        private IReadOnlyGrid _grid;

        private List<IIncomeDealer> _incomeDealers = new();

        private float _money;

        public IncomeHandler(IReadOnlyGrid grid)
        {
            _grid = grid;
            _grid.ObjectBinded += OnGridObjectBinded;
        }

        public void Dispose()
        {
            _grid.ObjectBinded -= OnGridObjectBinded;

            foreach (IIncomeDealer incomeDealer in _incomeDealers)
            {
                incomeDealer.IncomeTrigger -= OnIncomeTriggered;
            }

            _incomeDealers.Clear();
        }

        private void OnGridObjectBinded(IGridObject gridObject)
        {
            if (gridObject is IIncomeDealer incomeDealer)
            {
                _incomeDealers.Add(incomeDealer);
                incomeDealer.IncomeTrigger += OnIncomeTriggered;
            }
        }

        private void OnIncomeTriggered(float income)
        {
            _money += income;
            Debug.Log("Money: " + _money);
        }
    }
}
