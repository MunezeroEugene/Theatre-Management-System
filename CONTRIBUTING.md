# Contributing to Theatre Management System

Thank you for your interest in contributing! This guide will help you understand our development workflow and coding standards.

## Getting Started

### 1. Fork & Clone
```bash
git clone https://github.com/YOUR-USERNAME/Theatre-Management-System.git
cd Theatre-Management-System
```

### 2. Create Feature Branch
```bash
git checkout -b feature/your-feature-name
```

### 3. Set Up Environment
**Frontend:**
```bash
cd tms-fn
npm install
npm run dev
```

**Backend:**
```bash
cd TheatreMs.Api
cp appsettings.example.json appsettings.Development.json
# Update with your local settings
dotnet restore
dotnet ef database update
dotnet run
```

## Development Workflow

### Frontend (React/JavaScript)

**Code Style:**
- Use ESLint configuration provided
- Follow functional components pattern
- Use React Hooks for state management
- Implement proper error handling

**File Structure:**
```
tms-fn/src/
├── api/           # API calls
├── components/    # Reusable components
├── pages/         # Page components
├── hooks/         # Custom hooks
├── services/      # Business logic
├── utils/         # Helper functions
└── contexts/      # React Context
```

**Component Template:**
```jsx
/**
 * Component Description
 * @param {Object} props - Component props
 * @returns {JSX.Element} Rendered component
 */
function MyComponent({ prop1, prop2 }) {
  // Implementation
  return <div>Content</div>;
}

export default MyComponent;
```

**Linting:**
```bash
npm run lint      # Check for issues
npm run lint:fix  # Auto-fix issues
```

### Backend (C#/.NET)

**Code Style:**
- Follow C# naming conventions (PascalCase for public members)
- Use async/await for I/O operations
- Implement proper error handling
- Add XML documentation comments

**File Structure:**
```
TheatreMs.Api/
├── Controllers/       # API endpoints
├── Models/           # Data models
├── Services/         # Business logic
│   ├── Interfaces/   # Service contracts
│   └── Implementations/
├── DTOs/             # Data transfer objects
├── Middleware/       # Custom middleware
└── Data/             # Database context
```

**Class Template:**
```csharp
using System;
using TheatreMs.Api.Common;

namespace TheatreMs.Api.Services;

/// <summary>
/// Description of what this service does
/// </summary>
public interface IMyService
{
    Task<MyDto> GetAsync(int id);
}

public class MyService(AppDbContext context) : IMyService
{
    /// <summary>
    /// Gets an item by ID
    /// </summary>
    /// <param name="id">The item ID</param>
    /// <returns>The requested item</returns>
    public async Task<MyDto> GetAsync(int id)
    {
        // Implementation
        return await context.MyEntities.FindAsync(id);
    }
}
```

## Commit Guidelines

Use conventional commits:
```
feat: Add new booking feature
fix: Resolve login validation issue
docs: Update API documentation
refactor: Improve error handling
test: Add unit tests for AuthService
chore: Update dependencies
```

Format:
```
<type>(<scope>): <subject>

<body (optional)>

<footer (optional)>
```

Examples:
```
feat(auth): Add two-factor authentication
fix(booking): Correct seat availability calculation
docs(readme): Update installation instructions
```

## Pull Request Process

1. **Create PR from your feature branch to `develop`**
   ```bash
   git push origin feature/your-feature-name
   ```

2. **Fill PR Template:**
   - Title: Clear description of changes
   - Description: What, why, and how
   - Tests: What testing was done
   - Screenshots: If UI changes

3. **Ensure checks pass:**
   - ✅ All tests passing
   - ✅ No linting errors
   - ✅ Code coverage acceptable
   - ✅ No merge conflicts

4. **Await review** - At least 2 approvals required

5. **Squash & merge** to `develop`

## Testing Requirements

### Frontend
```bash
npm run test        # Run tests
npm run test:ui     # Interactive UI
npm run test:coverage
```

### Backend
```bash
dotnet test
dotnet test /p:CollectCoverage=true
```

**Minimum Coverage:** 80%

## Documentation

- **Code comments:** Explain WHY, not WHAT
- **Complex logic:** Add detailed comments
- **Public APIs:** Add XML documentation
- **Database changes:** Update schema docs

## Security Guidelines

- ✅ Never commit secrets or sensitive data
- ✅ Use environment variables
- ✅ Validate all user inputs
- ✅ Sanitize database queries
- ✅ Use HTTPS in production
- ✅ Follow OWASP best practices

## Reporting Issues

Use GitHub Issues with template:
- **Description:** Clear problem statement
- **Steps to reproduce:** Exact steps
- **Expected behavior:** What should happen
- **Actual behavior:** What actually happens
- **Environment:** OS, browser, versions
- **Screenshots:** If applicable

## Code Review Checklist

Reviewers should verify:
- [ ] Code follows style guidelines
- [ ] All tests pass
- [ ] No security vulnerabilities
- [ ] Documentation updated
- [ ] No hardcoded values
- [ ] Error handling proper
- [ ] No console.log/debug code
- [ ] Performance acceptable

## Helpful Resources

- Frontend Setup: `tms-fn/README.md`
- Backend Setup: `BACKEND_SETUP.md`
- API Documentation: `/swagger-ui`
- Security Policy: `SECURITY.md`
- Architecture: `README.md`

## Questions?

- Check existing issues and PRs
- Review documentation
- Ask in PR comments
- Contact maintainers

## Code of Conduct

- Be respectful and inclusive
- Provide constructive feedback
- Acknowledge good contributions
- Respect different perspectives
- Report inappropriate behavior

Thank you for contributing! 🚀
