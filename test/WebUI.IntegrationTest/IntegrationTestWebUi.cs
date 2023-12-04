using System.Net;
using Microsoft.AspNetCore.Mvc.testing;

namespace WebUI.IntegrationTest;

public class IntegrationTestWebUI : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public IntegrationTestWebUI(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("Index")]
    [InlineData("Privacy")]
    public async Task TestGetPages(string url)
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync(url);

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}