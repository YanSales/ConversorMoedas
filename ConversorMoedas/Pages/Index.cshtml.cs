using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConversorMoedas.Pages // ❗ Confira o namespace do seu projeto!
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;

        // Propriedades VINCULADAS (obrigatório [BindProperty])
        [BindProperty]
        public decimal Amount { get; set; } = 1;

        [BindProperty]
        public string FromCurrency { get; set; } = "USD";

        [BindProperty]
        public string ToCurrency { get; set; } = "BRL";

        // Propriedade para exibir o resultado (não precisa de [BindProperty])
        public decimal ConvertedAmount { get; set; }

        public IndexModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var client = _clientFactory.CreateClient();
            string apiKey = "4994c7d1ff84f87f743b4f6b"; // 👈 Obtenha em https://www.exchangerate-api.com/
            string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/pair/{FromCurrency}/{ToCurrency}/{Amount}";

            try
            {
                string response = await client.GetStringAsync(url);
                var result = JsonConvert.DeserializeObject<ExchangeRateResponse>(response);
                ConvertedAmount = result.conversion_result;
            }
            catch
            {
                ConvertedAmount = -1; // Indica erro
            }

            return Page();
        }

        // Classe para a resposta da API
        private class ExchangeRateResponse
        {
            public string? result { get; set; }
            public decimal conversion_result { get; set; }
        }
    }
}