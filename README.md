# REST API Automation Tests
Chethika Dithmal
This project contains automated API tests written in **C# using .NET 8 and xUnit** to validate CRUD operations of the API available at:

https://restful-api.dev

The tests verify that the API correctly supports creating, retrieving, updating, and deleting objects.

---

## Technologies Used

- C#
- .NET 8
- xUnit
- RestSharp
- Newtonsoft.Json

---

## Project Structure

RestApiTests  
│  
├── Helpers  
│   └── ApiClient.cs  
│  
├── Models  
│   └── ObjectModel.cs  
│  
├── Tests  
│   ├── ApiTests.cs  
│   └── NegativeTests.cs  
│  
└── README.md  

### Folder Description

Helpers  
Contains the API client used to send HTTP requests.

Models  
Contains the request body models used for serialization.

Tests  
Contains positive and negative API test scenarios.

---

## Test Scenarios

### Positive Tests

1. Get list of all objects
2. Add a new object using POST
3. Get a single object using the created ID
4. Update the object
5. Delete the object

### Negative Tests

1. Get object with invalid ID
2. Delete object with invalid ID
3. Update object with invalid ID

---

## Setup Instructions

### 1. Clone the repository
git clone https://github.com/YOUR_USERNAME/YOUR_REPOSITORY_NAME.git


### 2. Navigate to the project folder


cd RestApiTests


### 3. Restore dependencies


dotnet restore


### 4. Configure API Key

Open the following file:


Helpers/ApiClient.cs


Replace the placeholder API key with your own key:


private const string ApiKey = "YOUR_API_KEY";


You can obtain an API key by creating an account at:

https://restful-api.dev

---

### 5. Run the tests

Run the following command:


dotnet test


You can also run the tests directly from Rider or Visual Studio.

---

## Notes

The `bin` and `obj` folders are excluded from the repository because they contain compiled build files that are generated automatically during the build process.
Before uploading manually to GitHub

Make sure you delete these folders from your project before uploading:

bin
obj
.idea
.vs

These are build files and should not be included in the repository.
