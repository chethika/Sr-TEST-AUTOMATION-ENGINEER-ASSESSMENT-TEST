using Xunit;
using RestApiTests.Helpers;
using RestApiTests.Models;
using Newtonsoft.Json.Linq;
using System.Net;

namespace RestApiTests.Tests;

public class NegativeTests
{
    private readonly ApiClient api = new ApiClient();

    [Fact]
    public void GetObject_WithInvalidId_ShouldReturnNotFound()
    {
        // Arrange
        string invalidId = "invalid123";

        // Act
        var response = api.GetObject(invalidId);

        // Assert
        Assert.True(
            response.StatusCode == HttpStatusCode.NotFound ||
            response.StatusCode == HttpStatusCode.BadRequest
        );
    }

    [Fact]
    public void DeleteObject_WithInvalidId_ShouldReturnNotFound()
    {
        // Arrange
        string invalidId = "invalid123";

        // Act
        var response = api.DeleteObject(invalidId);

        // Assert
        Assert.True(
            response.StatusCode == HttpStatusCode.NotFound ||
            response.StatusCode == HttpStatusCode.BadRequest
        );
    }

    [Fact]
    public void GetObject_WithInvalidId_ShouldReturnError()
    {
        string invalidId = "invalid123";

        var response = api.GetObject(invalidId);

        Assert.True(
            response.StatusCode == HttpStatusCode.NotFound ||
            response.StatusCode == HttpStatusCode.BadRequest
        );
    }

    [Fact]
    public void UpdateObject_WithInvalidId_ShouldReturnError()
    {
        // Arrange
        string invalidId = "invalid123";

        var body = new ObjectModel
        {
            name = "Invalid Update",
            data = new Data
            {
                year = 2024,
                price = 100,
                CPUmodel = "Test",
                HardDiskSize = "256 GB"
            }
        };

        // Act
        var response = api.UpdateObject(invalidId, body);

        // Assert
        Assert.True(
            response.StatusCode == HttpStatusCode.NotFound ||
            response.StatusCode == HttpStatusCode.BadRequest
        );
    }
}