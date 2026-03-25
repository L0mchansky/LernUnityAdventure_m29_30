using UnityEngine;

namespace ExampleDowncast
{
    public class GridTest: MonoBehaviour
    {
        [SerializeField] private Bank _bankPrefab;
        [SerializeField] private float _bankIncomePerSecond;

        private Grid _grid;
        private IncomeHandler _incomeHandler;

        private void Awake()
        {
            _grid = new Grid();

            _incomeHandler = new IncomeHandler(_grid);

            CreateBanks();
        }

        private void OnDestroy()
        {
            _incomeHandler.Dispose();
        }

        public void CreateBanks()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Bank bank = Instantiate(_bankPrefab);
                    bank.Initialize(_bankIncomePerSecond);

                    _grid.Bind(bank, new Vector2Int(i, j));
                }
            }
        }
    }
}