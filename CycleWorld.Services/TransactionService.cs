using CycleTransaction.Models;
using CycleTransactions.Data;
using CycleWorld.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTransactions.Services
{
    class TransactionService
    {
        private readonly Guid _userId;

        public TransactionService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateTransaction(TransactionCreate model)
        {
            var entity =
                new Transaction()
                {
                    ItemCount = model.ItemCount,
                    DateOfTransaction = DateTimeOffset.Now,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Transactions.Add(entity);
                return ctx.SaveChanges() > 0;
            }
        }
        public IEnumerable<TransactionListItem> GetParts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Transactions
                        //.Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new TransactionListItem
                                {
                                    TransactionId = e.TransactionId,
                                    UserId = e.UserId,
                                    ItemCount = e.ItemCount,
                                    DateOfTransaction = e.DateOfTransaction
                                }
                        );

                return query.ToArray();
            }
        }
        public TransactionDetail GetPartById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Transactions
                        .Single(e => e.TransactionId == id && e.OwnerId == _userId);
                return
                    new TransactionDetail
                    {
                        TransactionId = entity.TransactionId,
                        UserId = entity.UserId,
                        ItemCount = entity.ItemCount,
                        DateOfTransaction = entity.DateOfTransaction
                    };
            }
        }
        public bool UpdatePart(TransactionEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Transaction entity =
                    ctx
                        .Transactions
                        .Single(e => e.TransactionId == model.TransactionId && e.OwnerId == _userId);

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePart(int transactionId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Transactions
                        .Single(e => e.TransactionId == transactionId && e.OwnerId == _userId);

                ctx.Transactions.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
