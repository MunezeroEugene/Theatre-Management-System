# Contributing to Theatre Management System

Welcome to the team! To maintain a clean and stable codebase, please follow these guidelines when contributing.

## Branching Strategy

We use a feature-branching workflow. 

1. **`main`**: Production-ready code only. No direct pushes.
2. **`develop`**: Integration branch for features. This is where most work happens.
3. **`staging`**: Pre-production testing branch.
4. **`feature/*`**: Individual features or tasks (e.g., `feature/movie-catalog`).
5. **`bugfix/*`**: Critical fixes.

## What should you push?

- **New Features**: Create a branch from `develop` (e.g., `git checkout -b feature/your-feature-name`).
- **Code**: 
    - Frontend changes in `tms-fn`.
    - Backend changes in `TheatreMs.Api`.
- **Tests**: Always push tests along with your logic changes.
- **Documentation**: Update `README.md` or API docs if you change how something works.

## Workflow

1. **Pull** the latest changes from `develop`.
2. **Create** your branch: `git checkout -b feature/awesome-feature`.
3. **Commit** your changes with descriptive messages.
4. **Push** your branch: `git push origin feature/awesome-feature`.
5. **Open a Pull Request (PR)**: Request a review before merging into `develop`.

## Code Style

- **Frontend**: Follow React best practices. Use functional components and hooks.
- **Backend**: Follow .NET coding conventions (PascalCase for methods, dependency injection).
- **Commit Messages**: Use the imperative mood (e.g., "Add authentication service" instead of "Added authentication service").
