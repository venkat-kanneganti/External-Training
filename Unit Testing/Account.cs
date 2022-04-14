using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing
{
    public class Account
    {
        private string accountno;
        private float balance;
        public List<Account> transferaccount;

        public Account(string accno)
        {
            this.accountno = accno;
            transferaccount = new List<Account>();
            balance = 1000.0f;
        }
        public float CheckBalance()
        {
            return balance;
        }
        public void Deposit(float amount)
        {
            balance += amount;
            CheckBalance();
        }
        public void WithDraw(float amount)
        {
            if (balance > amount)
                balance -= amount;
            else
                throw new Exception("Not Enough Funds to withdraw..");

        }
        public void AddTransferAccounts(Account accno)
        {
            transferaccount.Add(accno);
        }
        public void TransferFunds(string destinationaccount, float amount)
        {
            Account de_account = transferaccount.Find(acc => acc.accountno == destinationaccount);
            if (de_account != null)
            {
                de_account.Deposit(amount);
                CheckBalance();
            }
        }
    }
}
