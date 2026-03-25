using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m29_30_task_1
{
    public interface IReadOnlyCurrency
    {
        public IReadOnlyVariable<int> Amount { get; }
        public CurrencyType Type { get; }
    }
}