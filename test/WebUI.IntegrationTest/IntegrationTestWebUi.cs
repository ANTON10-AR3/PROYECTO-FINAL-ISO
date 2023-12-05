using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebUI.IntegrationTest;

public class IntegrationTestWebUI : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly WebApplicationFactory<Startup> _factory;

    public IntegrationTestWebUI(WebApplicationFactory<Startup> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("Index")]
    [InlineData("Privacy")]
    [InlineData("index2")]
    [InlineData("index3")]
    [InlineData("index4")]
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