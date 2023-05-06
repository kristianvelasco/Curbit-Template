using Common.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage;

namespace Notification.Infrastructure;

public class NotificationDbContext : DbContext, IUnitOfWork
{

    public NotificationDbContext(DbContextOptions<NotificationDbContext> options) : base(options) { }
    public NotificationDbContext(string DbConnection) : base() { }

    private IDbContextTransaction? _currentTransaction;
    public IDbContextTransaction GetCurrentTransaction()
    {
        return _currentTransaction;
    }

    public bool HasActiveTransaction => _currentTransaction != null;

    public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        _ = await base.SaveChangesAsync(cancellationToken);

        return true;
    }
    public async Task<IDbContextTransaction?> BeginTransactionAsync()
    {
        if (_currentTransaction != null)
        {
            return null;
        }

        _currentTransaction = await Database.BeginTransactionAsync();

        return _currentTransaction;
    }

    public async Task CommitTransactionAsync(IDbContextTransaction transaction)
    {
        if (transaction == null)
        {
            throw new ArgumentNullException(nameof(transaction));
        }

        if (transaction != _currentTransaction)
        {
            throw new InvalidOperationException($"Transaction {transaction.TransactionId} is not current");
        }

        try
        {
            _ = await SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch
        {
            RollbackTransaction();
            throw;
        }
        finally
        {
            if (_currentTransaction != null)
            {
                _currentTransaction.Dispose();
                _currentTransaction = null;
            }
        }
    }

    public void RollbackTransaction()
    {
        try
        {
            _currentTransaction?.Rollback();
        }
        finally
        {
            if (_currentTransaction != null)
            {
                _currentTransaction.Dispose();
                _currentTransaction = null;
            }
        }
    }

}

public class NotificationContextDesignFactory : IDesignTimeDbContextFactory<NotificationDbContext>, IDatabaseContextFactory
{
    public IUnitOfWork CreateContext()
    {
        return new NotificationDbContext(Environment.GetEnvironmentVariable("DbConnection"));
    }

    public NotificationDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<NotificationDbContext> optionsBuilder = new();
        //            .UseSqlServer("Server=.;Initial Catalog=trackingDb;Integrated Security=true");

        return new NotificationDbContext(optionsBuilder.Options);
    }

}