using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using TransChartDemo.Repositories;

namespace TransChartDemo.Pages
{
    public class ChartArrayBasicChartsJSModel : PageModel
    {
        private readonly IBankDataRepository bankDataRepository;

        public ChartArrayBasicChartsJSModel(IBankDataRepository _bankDataRepository)
        {
            bankDataRepository = _bankDataRepository;
        }

        public void OnGet()
        {
            var bankData = bankDataRepository.GetAllBankData();
            ViewData["allBankData"] = JsonSerializer.Serialize(bankData);
        }
    }
}
