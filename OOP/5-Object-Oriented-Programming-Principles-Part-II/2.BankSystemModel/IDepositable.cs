using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystemModel
{
    /// <summary>
    /// Defines a method for account deposit.
    /// </summary>
    public interface IDepositable
    {
        void Deposit(decimal amount);
    }
}
