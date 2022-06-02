using MusicMoney.Entities;

namespace MusicMoney.Repository;

public interface IExpensesRepository
{
    IEnumerable<Expense> GetExpenses();
    Expense GetExpense(Guid id);
}