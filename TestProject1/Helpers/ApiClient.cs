using RestSharp;

namespace RestApiTests.Helpers;

public class ApiClient
{
    private readonly RestClient client;
    private const string ApiKey = "2d3d014d-a852-493d-b7af-f366c2ad2fd9";
    private const string Collection = "qa-test";

    public ApiClient()
    {
        client = new RestClient("https://api.restful-api.dev");
    }

    private RestRequest CreateRequest(string endpoint, Method method)
    {
        var request = new RestRequest(endpoint, method);
        request.AddHeader("x-api-key", ApiKey);
        request.AddHeader("Content-Type", "application/json");

        return request;
    }

    public RestResponse GetAllObjects()
    {
        var request = CreateRequest($"/collections/{Collection}/objects", Method.Get);
        return client.Execute(request);
    }

    public RestResponse AddObject(object body)
    {
        var request = CreateRequest($"/collections/{Collection}/objects", Method.Post);
        request.AddJsonBody(body);

        return client.Execute(request);
    }

    public RestResponse GetObject(string id)
    {
        var request = CreateRequest($"/collections/{Collection}/objects/{id}", Method.Get);
        return client.Execute(request);
    }

    public RestResponse UpdateObject(string id, object body)
    {
        var request = CreateRequest($"/collections/{Collection}/objects/{id}", Method.Put);
        request.AddJsonBody(body);

        return client.Execute(request);
    }

    public RestResponse DeleteObject(string id)
    {
        var request = CreateRequest($"/collections/{Collection}/objects/{id}", Method.Delete);
        return client.Execute(request);
    }
}