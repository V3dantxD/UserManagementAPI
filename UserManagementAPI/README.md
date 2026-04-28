# User Management API

## Project Overview

This project is an ASP.NET Core Web API developed for the TechHive Solutions scenario. The API allows HR and IT teams to manage internal user records through standard CRUD operations.

The project includes:

- CRUD endpoints for user management
- Input validation for valid user data
- Custom request logging middleware
- Swagger/OpenAPI support for testing and documentation
- Documentation of Microsoft Copilot usage

---

## Technology Stack

- ASP.NET Core Web API
- .NET 8
- C#
- Swagger / OpenAPI
- In-memory data storage for assignment/demo purposes

---

## How to Run the Project

### 1. Clone the Repository

```bash
git clone YOUR_GITHUB_REPOSITORY_URL
cd UserManagementAPI
```

### 2. Restore Dependencies

```bash
dotnet restore
```

### 3. Run the API

```bash
dotnet run
```

### 4. Open Swagger UI

After running the project, open the Swagger URL shown in the terminal.

Common local URLs:

```text
https://localhost:5001/swagger
http://localhost:5000/swagger
```

---

## API Endpoints

### Get All Users

```http
GET /api/users
```

Returns the full list of users.

---

### Get User by ID

```http
GET /api/users/{id}
```

Returns a single user by ID.

Example:

```http
GET /api/users/1
```

---

### Create User

```http
POST /api/users
```

Request body:

```json
{
  "name": "Riya Sharma",
  "email": "riya.sharma@example.com",
  "role": "HR Executive"
}
```

Expected response:

```http
201 Created
```

---

### Update User

```http
PUT /api/users/{id}
```

Request body:

```json
{
  "name": "Riya Sharma",
  "email": "riya.updated@example.com",
  "role": "Senior HR Executive"
}
```

Expected response:

```http
204 No Content
```

---

### Delete User

```http
DELETE /api/users/{id}
```

Expected response:

```http
204 No Content
```

---

## Validation

The API validates user input before processing data.

Validation rules include:

- `Name` is required
- `Name` must be between 2 and 100 characters
- `Email` is required
- `Email` must be in a valid email format
- `Role` is required
- `Role` must be between 2 and 50 characters

Invalid requests return:

```http
400 Bad Request
```

---

## Middleware Implementation

This project includes custom middleware named `RequestLoggingMiddleware`.

The middleware records:

- HTTP method
- Request path
- Response status code
- Request processing time in milliseconds

This helps evaluate performance and identify slow API requests.

Example log output:

```text
HTTP GET /api/users responded 200 in 15 ms
```

---

## How Microsoft Copilot Assisted

Microsoft Copilot was used as a development assistant during the project.

Copilot helped with:

1. Scaffolding the initial ASP.NET Core Web API structure.
2. Generating CRUD endpoint patterns for GET, POST, PUT, and DELETE operations.
3. Improving controller code by suggesting proper HTTP status codes such as `200 OK`, `201 Created`, `204 No Content`, `400 Bad Request`, and `404 Not Found`.
4. Adding validation attributes such as `[Required]`, `[EmailAddress]`, and `[StringLength]`.
5. Debugging issues related to request models, route parameters, and null handling.
6. Creating custom middleware for logging request processing time.
7. Improving code organization by separating models, DTOs, services, controllers, and middleware.

---

## Testing Performed

The API was tested using Swagger UI and can also be tested using Postman.

Test cases included:

- Getting all users
- Getting a user by valid ID
- Getting a user by invalid ID
- Creating a user with valid data
- Creating a user with invalid email
- Updating an existing user
- Updating a non-existing user
- Deleting an existing user
- Deleting a non-existing user

---

## Project Structure

```text
UserManagementAPI/
│
├── Controllers/
│   └── UsersController.cs
│
├── DTOs/
│   ├── CreateUserRequest.cs
│   └── UpdateUserRequest.cs
│
├── Middleware/
│   └── RequestLoggingMiddleware.cs
│
├── Models/
│   └── User.cs
│
├── Services/
│   ├── IUserService.cs
│   └── UserService.cs
│
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
├── UserManagementAPI.csproj
└── README.md
```

---

## Notes

This project uses in-memory storage for simplicity. Data will reset when the application restarts. For a production application, this could be extended to use a database such as SQL Server with Entity Framework Core.
