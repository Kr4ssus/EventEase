# EventEase

EventEase is a Blazor WebAssembly event browser and registration app.

## GitHub Pages Deployment

This repository is configured for GitHub Pages as a repo site at `https://kr4ssus.github.io/EventEase/`.

### What was changed

- Updated `EventEase/wwwroot/index.html` to use `<base href="/EventEase/" />`.
- Added a GitHub Actions workflow at `.github/workflows/gh-pages.yml`.
- The workflow builds the app and publishes the output to the `gh-pages` branch.

### How to use it

1. Push your changes to `main`.
2. GitHub Actions will build and deploy the site automatically.
3. Configure GitHub Pages in repository settings, if needed:
   - Source: `gh-pages` branch
   - Folder: `/`

## Copilot assistance summary

### Stage 1: Event card UI and routing

- Created the reusable `EventCard` component.
- Built the event list page so events render in a responsive card grid.
- Added route structure and navigation to move between event views.
- Helped design card-based behavior and improve the event browsing UX.

### Stage 2: Upgrade to .NET 8

- Verified the project targets `.NET 8` in `EventEase.csproj`.
- Ensured the app built cleanly with the new framework.
- Addressed compatibility updates required for the Blazor WebAssembly app.

### Stage 3: Login/register flow and session protection

- Implemented `UserSessionService` and authentication state handling.
- Built the login/register UI with validation.
- Added protected navigation and route checks so only logged-in users can access events.
- Added direct event registration and session logout behavior.

## Notes

- The app is a static Blazor WebAssembly site and runs entirely in the browser.
- The GitHub Actions workflow publishes the static build output automatically.
