using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http.Features;
using MusicMoney.Entities;

namespace MusicMoney.Repositories
{
    public class InMemExpensesRepository
    {
        private readonly List<Expense> expenses = new()
        {
            new Expense
            {
                Id = Guid.NewGuid(), Name = "Strings", Cost = 1099, Tax = 37, Vendor = "South Austin Music",
                CreateDate = DateTimeOffset.UtcNow
            },
            new Expense
            {
                Id = Guid.NewGuid(), Name = "Guitar", Cost = 1003499, Tax = 2780, Vendor = "South Austin Music",
                CreateDate = DateTimeOffset.UtcNow
            },
            new Expense
            {
                Id = Guid.NewGuid(), Name = "Psick", Cost = 789, Tax = 29, Vendor = "Sam Ashe",
                CreateDate = DateTimeOffset.UtcNow
            }
        };

        public IEnumerable<Expense> GetExpenses()
        {
            return expenses;
        }

        public Expense GetExpense(Guid id)
        {
            return expenses.Where(expense => expense.Id == id).SingleOrDefault();
        }
    } 
}
    

