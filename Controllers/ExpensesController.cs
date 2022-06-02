using Microsoft.AspNetCore.Mvc;
using MusicMoney.Entities;
using MusicMoney.Repository;

namespace MusicMoney.Controllers
{
    [ApiController]
    [Route("expenses")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpensesRepository repository;

        public ExpensesController( IExpensesRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Expense> GetExpenses()
        {
            var expenses = repository.GetExpenses();
            return expenses;
        }

        [HttpGet("{id}")]
        public ActionResult<Expense> GetExpense(Guid id)
        {
            var expense = repository.GetExpense(id);

            if (expense is null)
            {
                return NotFound();
            }

            return expense;
        }
    }
}