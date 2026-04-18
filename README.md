# EventEase

EventEase is a Blazor WebAssembly app for browsing events, registering for events, and tracking attendance.
## Copilot-assisted development summary

This README summarizes how Microsoft Copilot helped through the three original stages of the EventEase project.

### Activity 1: Foundation and routing

- Copilot helped scaffold the first Blazor components, including the reusable `EventCard` component.
- It suggested the component structure and the properties needed for event name, date, and location.
- Copilot assisted with data binding syntax so event details rendered dynamically from a simple model.
- It helped establish the initial routing between the event list, event details, and registration pages.
- The result was a working foundation with component-based UI and basic page navigation.

### Activity 2: Debugging and optimization

- Copilot guided the debugging of data binding and validation issues in the event card.
- It suggested fixes for routing edge cases and invalid paths to improve navigation reliability.
- Copilot also helped identify performance issues in the event list rendering.
- By applying those suggestions, the app became more stable and responsive with larger event sets.

### Activity 3: Advanced features and deployment readiness

- Copilot assisted with adding user session state and login/register validation.
- It helped implement an attendance tracker and event registration flow.
- Copilot suggested best practices for session protection, logout behavior, and user-specific views.
- It also helped prepare the app for GitHub Pages hosting by confirming the correct static deployment path.

## Current state

- The app supports event browsing, registration, and protected navigation.
- User login state is tracked and cleared on logout.
- Event registration is handled directly from the event cards.
