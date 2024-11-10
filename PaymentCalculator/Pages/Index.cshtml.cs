using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public SalaryInput Input { get; set; } = new SalaryInput();

    public SalaryResult? Result { get; private set; }

    public void OnGet()
    {
        // Initialize Result if needed
    }

    public void OnPost()
    {
        if (ModelState.IsValid)
        {
            try
            {
                // Retrieve values from Input
                var quantity = Input.Quantity;
                var rate = Input.Rate;
                var discount = Input.Discount;

                // Calculate the Gross Amount (actual price before discount)
                var grossAmount = quantity * rate;

                // Calculate Net Amount after applying the discount
                var netAmount = grossAmount - discount;

                // Set the results to display
                Result = new SalaryResult
                {
                    GrossAmount = grossAmount.ToString("0.00"),
                    NetAmount = netAmount.ToString("0.00")
                };
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"An error occurred: {ex.Message}");
            }
        }
    }
}

public class SalaryInput
{
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public float Rate { get; set; }
    public float Discount { get; set; }
}

public class SalaryResult
{
    public string GrossAmount { get; set; } = string.Empty;
    public string NetAmount { get; set; } = string.Empty;
}
