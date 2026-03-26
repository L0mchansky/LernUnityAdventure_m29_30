using System;

namespace m29_30_task_3
{
    public class InvenvotryException : Exception
    {
        public InvenvotryException(string message) : base(message) { }
    }

    public class InvenvotryIsFullException : InvenvotryException
    {
        public InvenvotryIsFullException() 
            : base($"Инвентарь полон. Невозможно добавить новый элемент.") { }
    }

    public class InventoryItemNotFoundException : InvenvotryException
    {
        public InventoryItemNotFoundException(string itemName) 
            : base($"Запрашиваемый предмет отсутствут в инвентаре. name: {itemName}") { }
    }

    public class InventoryInsufficientItemsException : InvenvotryException
    {
        public InventoryInsufficientItemsException(int itemCount) 
            : base($"Кол-во запрашиваемых предметов меньше чем есть в инвентаре. count: {itemCount}") { }
    }
}