This repository is a small Blazor (Razor Components) web app using .NET 8 with Interactive Server Components.

Keep this short and focused — use these facts when making changes or drafting code.

1) Big-picture architecture
- Single ASP.NET Core project: `TechNotes/TechNotes.csproj` (TargetFramework: net8.0).
- UI is composed of Razor Components under `TechNotes/Components/` with subfolders `Layout/` and `Pages/`.
- Routing: `Components/Routes.razor` uses the app assembly router and `FocusOnNavigate` for a11y.
- Server model: interactive server components are enabled in `Program.cs` via
  `builder.Services.AddRazorComponents().AddInteractiveServerComponents()` and the app maps components with
  `app.MapRazorComponents<App>().AddInteractiveServerRenderMode()`.

2) Key patterns & conventions (use these exact examples)
- Interactive server rendering: pages that need interactivity use the `@rendermode InteractiveServer` directive (see `Components/Pages/Counter.razor`).
- Streaming rendering: `@attribute [StreamRendering]` is used to demonstrate streaming behavior (see `Components/Pages/Weather.razor`).
- Layouts: `Components/Layout/MainLayout.razor` contains the global page shell and includes `NavMenu` for navigation.
- Static assets and styling live in `TechNotes/wwwroot/` (see `app.css`, `bootstrap/`, and `favicon.png`). Generated component CSS is referenced as `TechNotes.styles.css` from `Components/App.razor`.

3) Build / run / debug (concrete commands)
- Build: `dotnet build TechNotes/TechNotes.csproj`
- Run (development): `dotnet run --project TechNotes/TechNotes.csproj` (or use the `https`/`http` profiles in `TechNotes/Properties/launchSettings.json`).
- The launch profiles include `https` with `applicationUrl` values (e.g. `https://localhost:7223;http://localhost:5083`). Use those when verifying browser behavior.

4) What to look for when changing UI or component code
- If you add interactivity to a page, prefer `@rendermode InteractiveServer` and keep component state local when possible.
- For long-running or incremental UI updates, follow the pattern in `Weather.razor` (simulate loading in `OnInitializedAsync`, produce small batches of data if streaming).
- Avoid touching `Components/App.razor` unless you need to add or remove global CSS or script includes — it is the HTML host shell.

5) Project-specific gotchas
- Antiforgery is enabled via `app.UseAntiforgery()` in `Program.cs` — preserve this unless you intentionally change request forgery handling.
- The app is not an MVC/Razor Pages app; it is Razor Components (Blazor) hosted in ASP.NET Core. Do not add MVC controller scaffolding without changing the project file.
- There are no unit tests in the repository. If you add tests, prefer xUnit and put them in a separate test project (follow .NET test project conventions).

6) Useful files to reference (quick links)
- Program bootstrap: `TechNotes/Program.cs`
- Project file: `TechNotes/TechNotes.csproj`
- Routing: `TechNotes/Components/Routes.razor`
- Layout: `TechNotes/Components/Layout/MainLayout.razor`
- Nav: `TechNotes/Components/Layout/NavMenu.razor`
- Pages: `TechNotes/Components/Pages/*.razor` (Home/Counter/Weather show common patterns)
- Launch settings: `TechNotes/Properties/launchSettings.json`

If anything above is unclear or you'd like more detail (examples of adding a new interactive page, recommended test scaffolding, or live-reload development workflow), tell me which area to expand and I will update this file.
