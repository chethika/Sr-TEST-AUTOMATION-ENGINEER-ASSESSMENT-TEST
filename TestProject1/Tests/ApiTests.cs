using Xunit;
using RestApiTests.Helpers;
using RestApiTests.Models;
using Newtonsoft.Json.Linq;
using System.Net;

namespace RestApiTests.Tests;

public class ApiTests
{
    private readonly ApiClient api = new ApiClient();
    private static string createdId;

    [Fact]
    public void GetAllObjects_ShouldReturn200()
    {
        var response = api.GetAllObjects();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(response.Content);
    }

    [Fact]
    public void AddObject_ShouldCreateObject()
    {
        var body = new ObjectModel
        {
            name = "Apple MacBook Pro",
            data = new Data
            {
                year = 2023,
                price = 2000,
                CPUmodel = "M2",
                HardDiskSize = "1 TB"
            }
        };

        var response = api.AddObject(body);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var json = JObject.Parse(response.Content);
        createdId = json["id"].ToString();

        Assert.False(string.IsNullOrEmpty(createdId));
    }

    [Fact]
    public void GetSingleObject_ShouldReturnCorrectObject()
    {
        // Arrange - create a new object first
        var body = new ObjectModel
        {
            name = "MacBook Test",
            data = new Data
            {
                year = 2023,
                price = 2000,
                CPUmodel = "M2",
                HardDiskSize = "1 TB"
            }
        };

        var createResponse = api.AddObject(body);
        Assert.Equal(HttpStatusCode.OK, createResponse.StatusCode);

        var createdJson = JObject.Parse(createResponse.Content);
        var createdId = createdJson["id"].ToString();

        // Act - retrieve the object using the returned ID
        var response = api.GetObject(createdId);

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var json = JObject.Parse(response.Content);

        Assert.Equal(createdId, json["id"].ToString());
        Assert.Equal("MacBook Test", json["name"].ToString());
    }

    [Fact]
    public void UpdateObject_ShouldUpdateData()
    {
        var body = new ObjectModel
        {
            name = "MacBook",
            data = new Data
            {
                year = 2023,
                price = 2000,
                CPUmodel = "M2",
                HardDiskSize = "1 TB"
            }
        };

        var createResponse = api.AddObject(body);
        var json = JObject.Parse(createResponse.Content);
        var id = json["id"].ToString();

        var updateBody = new ObjectModel
        {
            name = "MacBook Updated",
            data = new Data
            {
                year = 2024,
                price = 2500,
                CPUmodel = "M3",
                HardDiskSize = "2 TB"
            }
        };

        var updateResponse = api.UpdateObject(id, updateBody);

        Assert.Equal(HttpStatusCode.OK, updateResponse.StatusCode);
    }
    
    [Fact]
    public void DeleteObject_ShouldDeleteSuccessfully()
    {
        var body = new ObjectModel
        {
            name = "DeleteTest",
            data = new Data
            {
                year = 2024,
                price = 1000,
                CPUmodel = "Test",
                HardDiskSize = "512 GB"
            }
        };

        var createResponse = api.AddObject(body);

        var json = JObject.Parse(createResponse.Content);
        var id = json["id"].ToString();

        var response = api.DeleteObject(id);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}