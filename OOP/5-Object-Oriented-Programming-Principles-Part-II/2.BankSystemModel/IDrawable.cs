using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystemModel
{
    /// <summary>
    /// Defines a method for withdraw from an account.
    /// </summary>
    public interface IDrawable
    {
        void Withdraw(decimal amount);
    }
}
