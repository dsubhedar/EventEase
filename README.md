# EventEase
This Blazor solution is an event attendance management system. Here’s a concise summary of its main features and structure:
---
Key Features
•	Event Registration:
Users can register for events using a form (RegisterEvent.razor). The form uses data annotations for validation and lists available events from the EventService.
•	Attendance Tracking:
The Attendance.razor page displays a table of all registered participants, showing their name, email, event, and attendance status. Organizers can mark participants as present.
•	Event Management:
Events are managed via the EventService, which provides event data to the registration and attendance components.
•	State Management:
The AttendanceService tracks registered participants and their attendance status.
•	Navigation:
The app uses Blazor’s routing and navigation features to move between pages like registration, attendance, and event lists.
---
Technical Structure
•	Blazor Components:
UI is built with Blazor components, using data binding and dependency injection for services.
•	Validation:
Forms use data annotations and Blazor’s validation system for user input.
•	.NET 9 & C# 13:
The solution targets modern .NET and C# versions, ensuring up-to-date language and framework features.
---
Typical User Flow
1.	Register for an Event:
User fills out the registration form and selects an event.
2.	View Attendance:
Admin or organizer views the attendance list and marks participants as present.
3.	Event Data:
All event and participant data is managed in-memory via services.
---
In summary:
This solution provides a simple, modern Blazor-based web app for registering event participants and tracking their attendance, using best practices for component-based UI, validation, and service-based state management.
