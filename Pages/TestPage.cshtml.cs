using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learn_razor_pages.Pages;

public class TestPageModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string TestValue = "This is the test value";

    public TestPageModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
}
