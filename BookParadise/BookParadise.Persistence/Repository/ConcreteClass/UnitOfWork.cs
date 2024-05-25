using BookParadise.Persistence.DBContextFolder;
using BookParadise.Persistence.Repository.Interface;

public class UnitOfWork : IUnitOfWork
{
    private readonly BookParadiseDb _bookParadiseDb;
    private readonly IBookRepository _bookRepo;
    private readonly IAuthenticationRepository _authRepo;
    private readonly IOrderRepository _orderRepo;

    public UnitOfWork(IBookRepository bookRepo, IAuthenticationRepository authRepo, IOrderRepository orderRepo, BookParadiseDb bookParadiseDb)
    {
        _bookRepo = bookRepo;
        _authRepo = authRepo;
        _orderRepo = orderRepo;
        _bookParadiseDb = bookParadiseDb;
    }

    public IBookRepository BookRepo => _bookRepo;
    public IAuthenticationRepository AuthRepo => _authRepo;
    public IOrderRepository OrderRepo => _orderRepo;

    public async Task SaveChangesAsync()
    {
        await _bookParadiseDb.SaveChangesAsync();
    }
}
