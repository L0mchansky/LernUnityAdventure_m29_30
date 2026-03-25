using UnityEngine;

namespace m29_30_task_1
{
    public class WalletUIInitializer : MonoBehaviour
    {
        [SerializeField] private WalletUIController _controller;
        [SerializeField] private WalletUIView _view;

        private Wallet _wallet;

        public void Initialize(Wallet wallet, Currency currency)
        {
            _wallet = wallet;

            _controller.Initialize(_wallet);
            _view.Initialize(currency);
        }
    }
}