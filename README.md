# REST API Automation Tests - Chethika Dithmal

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
- JetBrains Rider

---

## Project Structure

RestApiTests  
├── Helpers  
│   └── ApiClient.cs   
├── Models  
│   └── ObjectModel.cs  
├── Tests  
│   ├── ApiTests.cs  
│   └── NegativeTests.cs    
└── README.md  

---

## Test Scenarios

### Positive Test Cases

1. Get list of all objects
2. Add a new object using POST
3. Get the created object by ID
4. Update the created object
5. Delete the object

### Negative Test Cases

1. Get object with an invalid ID
2. Delete object with an invalid ID
3. Update object with an invalid ID
4. Create object with invalid data

---

## Setup Instructions

### 1. Clone the repository


git clone https://github.com/YOUR_USERNAME/YOUR_REPOSITORY_NAME.git


### 2. Open the project in JetBrains Rider

Open Rider → **File → Open** → select the project folder.

Rider will automatically restore the NuGet dependencies.

---

### 3. Configure API Key

Open the file:


Helpers/ApiClient.cs


Replace the API key placeholder with your API key.


private const string ApiKey = "YOUR_API_KEY";


You can create an API key by signing up at:

https://restful-api.dev

---

## Running the Tests (Using Rider)

1. Open the project in Rider.
2. Navigate to the **Tests** folder.
3. Open **ApiTests.cs** or **NegativeTests.cs**.
4. Click the **Run (▶) icon** next to the test class or method.

You can also run all tests from the **Unit Tests window**.

When executed successfully, the test runner will show all tests as **passed**.

---

## Notes

The folders `bin` and `obj` are excluded from the repository because they contain compiled build files generated automatically during the build process.
