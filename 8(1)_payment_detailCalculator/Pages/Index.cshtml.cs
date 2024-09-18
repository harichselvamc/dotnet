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
                var grossAmount = Input.GrossAmount;
                var discount = Input.Discount;

                // Calculate net amount
                var totalGrossAmount = quantity * rate;
                var netAmount = totalGrossAmount - discount;

                Result = new SalaryResult
                {
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
    public float GrossAmount { get; set; }
    public float Discount { get; set; }
}

public class SalaryResult
{
    public string NetAmount { get; set; } = string.Empty;
}
