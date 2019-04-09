# Contact Manager (ITSE 1430)

## Version 1.2

In this lab you will create a Windows Forms application to manage contacts for someone. In this application we will only track their name and email address.

*Note: This program will not actually send any emails. We are going to simulate that functionality.*

## Skills Needed

- C# 
  - Abstract Classes
  - Error Handling
  - Extension Methods
  - Generic Types
  - Interfaces
  - Lists
- Windows Forms
  - Child Forms
  - Layouts
  - List Controls
  - Validation

## Story 1 - Set Up Main Window

Set up the main window.

### Description

Create a new Windows Forms project to hold your code. The project should be named such that it is clear it is the UI portion of the solution (e.g. `ContactManager.UI`).

Ensure the main form is reasonably sized, is appropriately named and has the appropriate title.

Add a main menu to the form. The main menu should have the following functionality as in past labs.

- `File \ Exit` that exits the program.
- `Help \ About` that displays an about box with your basic information. The hotkey is `F1`

### Notes

1. ENSURE event handlers have reasonable names.
1. DO use descriptive control names for fields you will be interacting with in code. Other controls can use their default names.
1. ENSURE the form title is descritive.

### Acceptance Criteria

1. The application compiles cleanly without warnings or errors.
1. The application runs.
1. The exit functionality works.
1. The help functionality works.

## Story 2 - Define the Business Layer

Define the business layer to contain the types needed to support the application.

### Description

Create a new `Class Library` project to manage contacts. This project represents the business layer of the application and should be named accordingly. Add a reference to the class library to the main UI project.

#### Contact Type

Create a `Contact` type to represent a contact in the system. It should contain the data needed to represent a contact.

- `Name` - [Required] The unique name of the contact.
- `Email` - [Required] The email address of the contact.

The type should validate that the data is valid.

#### Contact Database Interface

Create an interface (e.g. `IContactDatabase`) to store contacts. This interface needs to have methods similar to the following:

- `Add` method to add a new contact to the database. Method should validate the contact is valid. Contact names should be unique.
- `Get` method to get a specific contact.
- `GetAll` method to get all the contacts in the database.
- `Remove` method to remove a contact from the database.
- `Update` method to update an existing contact's information. Method should validate the contact is valid. Contact names should be unique.

#### Contact Database

Create an implementation of the `IContactDatabase` interface that uses a simple list to store the contacts. Feel free to add any data needed by the implementation to the `Contact` type (or a derived type).

#### Message Type

Create a `Message` type to represent a message to be sent. It should contain the data needed to send a message.

- `Contact` - [Required] Represents the contact to receive the message.
- `Subject` - [Required] Provides the subject of the message.
- `Body` - [Required] Provides the body of the message.

The type should validate the required properties are set.

#### Message Service Interface

Create the `IMessageService` interface to "send" messages. The interface should contain the following.

- `Send` method that takes a `Message` and "sends" it. The message should be validated to ensure it is correct before sending.

*Note: This interface DOES NOT save messages to a database. Assume it does nothing at this point. *

### Notes

1. DO NOT reference Windows Forms or `Console` in the business project. It must remain UI agnostic.
1. CONSIDER using a base name for the business project and a more specialized name for the UI project. (e.g. `ContactManager` and `ContactManager.UI`) This will reduce the number of
   `using` statements you'll need.
1. DO start interface names with `I`.
1. DO drop the `I` on base classes used to implement base interface functionality.

### Acceptance Criteria

1. The application compiles cleanly without warnings or errors.
1. The application runs.
1. The new type(s) are properly documented.

## Story 3 - Add Support for Adding a Contact

Add support for adding contacts in the UI.

### Description

In the main form add a new menu to support working with contacts. Add an option to add a new contact. Add an appropriate hotkey (e.g. `Insert`). When clicked display a form to collect the contact information.

1. The form should be appropriately titled and sized.
1. The form should allow for entering the contact information.
1. Email addresses should be in the valid format but do not have to be valid. Refer to the Notes section for more information.
1. The form should allow for saving or cancelling the request.
1. If the user clicks save the form should ensure the contact is vaild before closing. Display an errors as appriopriate.
1. If the user clicks the cancel option then no validation is done and the form closes.

*Note: Allow the user to navigate away from invalid controls. Just do not allow saving of invalid data.*

### Notes

1. ENSURE contact information is stored in the business project and not the UI. This allows it to be reused in other UI projects.
1. ENSURE each form is appropriately titled.
1. REMOVE the minimize and maximize buttons if a form does not suppor them. Optionally remove the entire control box for child forms.
1. ENSURE the form's layout flows top to bottom and left to right. This includes using the keyboard to navigate.
1. ENSURE form controls resize properly on forms that support resizing. In cases where resizing is not useful then ensure the form does not resize.
1. ENSURE cancellation buttons do not trigger any validation and do not modify existing data.
1. ENSURE affirmative buttons handle validation before performing their action.
1. ENSURE that form buttons set `DialogResult` to an appropriate value before closing the form.
1. ENSURE that any errors trying to add a contact are handled and reported to the user.

### Acceptance Criteria

1. Adding a contact is available in menu.
1. Menu hotkey works.
1. Clicking menu displays appropriate form. Form layout is clean and usable.
1. Form can be cancelled without validation.
1. Attempting to save with data missing reports the correct errors.
1. Clicking save with valid data works.
1. Errors during saving are reported to the user.

## Story 4 - Display the Contacts in the Main Window

The main form will need to track the contacts that have been added. Each time a contact is added the main window should update to show the new contact.

### Description

The main form should have a field for the contact database interface being used Whenever the main form manipulates a contact it should update the database as needed.

The main form should display a list of contacts in the main window. The list should show the contact name, sorted by name. The contact list will be one of two views in the main window so use a split container to separate them.

### Acceptance Criteria

1. Adding a new contact adds them to the list being displayed.
1. Attempting to add an invalid contact fails. The user receives a message and the form appears again with the previous data.
1. Contacts are shonw in sorted order.

## Story 5 - Add Support for Sending Emails

Add support for collecting information and sending the emails.

### Description

Add a menu item to the contacts menu to send a message. When clicked get the currently selected contact (if any). If there is a contact then display a form to collect the subject and message to send to the contact.

1. The form should be appropriately titled and sized.
1. The form should show the contact name but it should not be editable.
1. The form should allow for entering the subject and message. Subject is required but message is not.
1. The form should allow for sending or cancelling the request.
1. If the user clicks the send option then ensure the fields are vaild before closing. Display any errors as appriopriate.
1. If the user clicks the cancel option then no validation is done and the form closes.

*Note: Allow the user to navigate away from invalid controls. Just do not allow saving of invalid data.*

### Acceptance Criteria

1. Clicking the menu item shows the send message form if there is a selected contact.
1. Clicking the menu item does nothing if there is no selected contact.
1. The form shows the contact's name and email. They are not editable.
1. The form allows for entering subject and message. Appropriate validation is done.
1. The user can move between fields even with validation errors.

## Story 6 - Show Sent Messages

Shows the message(s) sent to a contact.

### Description

Update the main form to show a view in the main window where messages will be shown. Use a simple control like `TextBox` or `ListBox` to show the messages that have been sent. The displayed information should include the contact name, subject and message. The UI should be scrollable and resize with the form so the information can be more easily seen.

Implement the `IMessageService` interface to write to the control being used. Since the implementation is tied to the UI it can go in the UI project where the control is defined.

### Notes

1. There is no database component here. The implementation does not need to "save" messages. It just needs to make the message appear in the UI.

### Acceptance Criteria

1. Main window shows a list of messages that have been sent including email address, subject and message.
1. Clicking send in the send message form causes the correct information to appear in the UI.

## Story 7 - Add Support for Editing Contacts

Add support for editing an existing contact.

### Description

Update the add contact form to support editing a contact as well. When the form is loaded and a contact is provided then show the initial contact information. If the user clicks save then update the existing contact otherwise ignore the changes.

Add a new menu item to the contacts menu to allow editing. Get the currently selected contact, if any, and display the form for editing. If there is no selected contact then do nothing.

Update the contact list to allow double clicking a contact. If a contact is double clicked then treat it like the menu and display the edit form.

### Acceptance Criteria

1. Using the menu to edit a selected contact shows the form appropriate populated.
1. Clicking save in the form updates the contact information.
1. Clicking cancel in the form does not update the contact information.
1. Double clicking a contact in the contact list edits the contact.
1. Trying to edit a contact when none is selected does nothing.
1. Editing a contact updates the contact list appropriately.
1. Errors modifying a contact are reported to the user.

## Story 8 - Add Support for Removing Contacts

Add support for deleting a contact.

### Description

Add a menu item to allow deleting a contact. When clicked display a confirmation message with the contact's name. If the user confirms then remove the contact. Otherwise do nothing.

Allow the user to press the `DEL` key to delete a contact as well.

### Acceptance Criteria

1. Clicking delete menu item on selected contact displays a confirmation.
1. Confirming the delete prompt removes the contact from the list and UI.
1. Declining the delete prmopt leaves the user.
1. Using `DEL` key triggers deletion prompt.

## Hints

### Naming

- Types represent entities and are nouns. (e.g. `Contact`)
- Types are singular unless they represent a set of items (e.g. `Contact` not `Contacts`)
- Properties are data and use nouns.
- Methods are actions and use verbs.
- Fields are data and use nouns. Fields traditionally start with an underscore to separate them from variables. (e.g. `_name` instead of `name`)

### Members

- Members are implicitly associated with the type and therefore do not need to include it (e.g. `Rectangle` class with an `AreaOfRectangle` method is not descriptive, use `Area` instead)
- Public members and types are Pascal cased.
- Private members are generally Pascal cased except for fields which use camel casing.
- Parameters are camel cased.
- Properties should have no side effects and be deterministic.
- If a method starts with `Get` or `Set` then it likely needs to be a property, unless it is non-deterministic.

### Validating an Email Address

To help with validating email addresses use the following code. It is wrapped in a function but you can use it however you need.

```csharp
bool IsValidEmail ( string source )
{
   try
   {
      new System.Net.Mail.MailAddress(source);
      return true;
   } catch
   { };

   return false;
}
```

## Requirements

- DO ensure code compiles cleanly without warnings or errors (unless otherwise specified).
- DO ensure all acceptance criteria are met.
- DO Ensure each file has a file header indicating the course, your name and date.
- DO ensure you are using the provided `.gitignore` file in your repository.
- DO ensure the entire solution directory is uploaded to Github (except those files excluded by `.gitignore`).
- DO submit your lab in MyTCC by providing the link to the Github repository.
