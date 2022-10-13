using Microsoft.Playwright;
using Xunit;

namespace PlaywrightXUnit
{
    public class FirstTests
    {
        [Fact]
        public async Task FirstTest()
        {
            // Inits playwright
            using var playwright = await Playwright.CreateAsync();

            // Inits browser
            await using var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false });

            // Starts new page in browser
            var page = await browser.NewPageAsync();

            // Navigates to URL
            await page.GotoAsync("https://playwright.dev/dotnet");
            
            // Pauses execution for debugging, getting selectors, etc.
            await page.PauseAsync();

            // 1 second delay
            await Task.Delay(1000);
        }
    }
}