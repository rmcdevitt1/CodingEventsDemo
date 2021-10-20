# CodingEventsDemo

1. Purpose of this app:
    The purpose of this Coding Events application is twofold. One part of the app allows organizers to input information about various events happening in the area. This info includes the name of the event, a description, its category, associated keyword tags, and contact emails for event organizers. The other purpose provides the users of this app to access all this information, to sign up for events, and to see events that other people are attending.
    
2. Current state of the app:
    Currently, the app allows organizers to input information about various events happening in the area. This info includes the name of the event, a description, its category, associated keyword tags, and contact emails for event organizers. Events can also be deleted and edited once created. The application also contains functinality to list all of the events by name, by category, or by tag, and clicking on a given event will render a page with all the details about that specific event.

3. Describe the future improvements you want to make to the app including your notes about the Person class.
    In order to make part two of the purpose of the app to come to fruition, the first thing that needs to be done is to create a Person class. This class will contain:
    public int Id
    public string Name
    public string Email
    public string Password
The person class will also contain an empty constructor as well as constructor with the name, email, and password passed in as parameters. All field will need to be required.
An EventsPeople class will also need to be created in order to relate the Person to the Events they are signed up to attend. This creates a many-to-many relationship because a person can attend multiple events and an events can have multiple people attending it.
