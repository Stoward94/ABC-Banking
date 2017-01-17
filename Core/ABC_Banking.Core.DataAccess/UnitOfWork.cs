﻿using System;
using ABC_Banking.Core.Models.BankAccounts;
using ABC_Banking.Core.Models.BankCards;
using ABC_Banking.Core.Models.Transactions;

namespace ABC_Banking.Core.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        //Create the instance of the context
        private readonly DatabaseContext _context = new DatabaseContext();


        //Declare all the generic type repositories
        private GenericRepository<BankAccount> _bankAccountRepository;
        private GenericRepository<BankCard> _bankCardRepository;
        private GenericRepository<DepositTransaction> _depositTransactionRepository;


        //Handle the creation and get function of each repository
        public GenericRepository<BankAccount> BankAccountRepository
        {
            get
            {
                if (this._bankAccountRepository == null)
                {
                    this._bankAccountRepository = new GenericRepository<BankAccount>(_context);
                }
                return _bankAccountRepository;
            }
        }

        public GenericRepository<BankCard> BankCardRepository
        {
            get
            {
                if (this._bankCardRepository == null)
                {
                    this._bankCardRepository = new GenericRepository<BankCard>(_context);
                }
                return _bankCardRepository;
            }
        }

        public GenericRepository<DepositTransaction> DepositTransactionRepository
        {
            get
            {
                if (this._depositTransactionRepository == null)
                {
                    this._depositTransactionRepository = new GenericRepository<DepositTransaction>(_context);
                }
                return _depositTransactionRepository;
            }
        }

        /// <summary>
        /// Call to save changes tracked by the db context
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }


        private bool disposed = false;

        /// <summary>
        /// Handle the disposal of the db context
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
