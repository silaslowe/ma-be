using Microsoft.AspNetCore.Mvc;
using MusicMoney.Entities;
using MusicMoney.Repositories;

namespace MusicMoney.Controllers
{
    [ApiController]
    [Route("expenses")]
    public class ExpensesController : ControllerBase
    {
        private readonly InMemExpensesRepository _repository;

        public ExpensesController()
        {
            _repository = new InMemExpensesRepository();
        }

        [HttpGet]
        public IEnumerable<Expense> GetExpenses()
        {
            var expenses = _repository.GetExpenses();
            return expenses;
        }

        [HttpGet("{id}")]
        public ActionResult<Expense> GetExpense(Guid id)
        {
            var expense = _repository.GetExpense(id);

            if (expense is null)
            {
                return NotFound();
            }

            return expense;
        }
    }
}