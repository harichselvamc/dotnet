using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public AttendanceInput Input { get; set; } = new AttendanceInput();

    public AttendanceResult? Result { get; private set; }

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
                var totalDays = Input.TotalDays;
                var presentDays = Input.PresentDays;
                var absentDays = Input.AbsentDays;

                // Calculate percentage
                var percentage = ((float)presentDays / totalDays) * 100;

                // Determine fine
                string fine;
                if (percentage >= 75)
                {
                    fine = "No Fine";
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    fine = "Rs 1000";
                }
                else if (percentage >= 40 && percentage < 60)
                {
                    fine = "Rs 2000";
                }
                else
                {
                    fine = "Not Eligible for Exam";
                }

                Result = new AttendanceResult
                {
                    Percentage = percentage.ToString("0.00"),
                    Fine = fine
                };
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"An error occurred: {ex.Message}");
            }
        }
    }
}

public class AttendanceInput
{
    public string Name { get; set; } = string.Empty;
    public string RegNo { get; set; } = string.Empty;
    public int TotalDays { get; set; }
    public int PresentDays { get; set; }
    public int AbsentDays { get; set; }
}

public class AttendanceResult
{
    public string Percentage { get; set; } = string.Empty;
    public string Fine { get; set; } = string.Empty;
}
