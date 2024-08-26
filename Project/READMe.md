# Library Management Software

This project involves the design and development of a Library Management Software, aimed at creating an ideal application for libraries. The software is designed to meet the needs of both regular users (with limited access) and administrators (with full access). The goal is to provide a user-friendly interface that addresses all the requirements of both user groups while ensuring the security and integrity of the data.

## Project Abstract

The primary objective of this project is to design and build software that is both functional and easy to use for library environments. The software includes separate panels for users and librarians (Admins), with each panel offering specific functionalities tailored to the respective user's role. 

Due to the nature of the project being a course assignment, there were no financial constraints or client-imposed requirements. This allowed for flexibility in design choices but also led to the use of certain tools and resources that were either limited or inaccessible due to sanctions, resulting in some compromises, such as using cracked software or unauthorized files.

The software features a secure database designed to store all operations performed by users and administrators, ensuring that no data is lost. However, for enhanced security, the current version of the database is non-transferable to other systems.

## Directory Structure

### Important Files and Directories

#### Project Files

- **AdminLogin_UserControl.cs**: Contains the code for the Admin login user control, managing the authentication process for library administrators.
- **AdminLogin_UserControl.Designer.cs**: Designer file associated with the Admin login user control, defining the layout and design components.
- **AdminLogin_UserControl.resx**: Resource file for the Admin login user control, storing string and other resource data.
  
- **Login_Form.cs**: The main login form code, responsible for handling user authentication (both Admin and regular users).
- **Login_Form.Designer.cs**: Designer file for the main login form, specifying the form's UI components and layout.
- **Login_Form.resx**: Resource file for the main login form.

- **UserForm.cs**: The form that manages the interface and functionalities for regular users, such as borrowing books or checking account details.
- **UserForm.Designer.cs**: Designer file for the User form, managing the form's visual elements.
- **UserForm.resx**: Resource file for the User form.

- **UserLogin_UserControl.cs**: Code file managing the user login control, which handles the authentication process for regular users.
- **UserLogin_UserControl.Designer.cs**: Designer file for the User login control, defining its layout and design components.
- **UserLogin_UserControl.resx**: Resource file for the User login control.

- **Program.cs**: The entry point of the application, initializing the software and setting up the main forms.

- **Project.csproj**: The main project file for the C# application, containing metadata about the project and its configuration.

#### Properties

- **AssemblyInfo.cs**: Metadata about the assembly, such as version information and description.
- **Resources.Designer.cs**: Designer file for managing project resources, such as images and strings.
- **Resources.resx**: Resource file containing project-specific resources.
- **Settings.Designer.cs**: Designer file for managing user settings.
- **Settings.settings**: XML-based settings file storing user preferences and configurations.

### How to Use

1. **Admin Login**: 
   - The Admin can log in using the `AdminLogin_UserControl`. Upon successful authentication, the Admin is directed to a dashboard where they can manage library resources, view user activities, and perform administrative tasks.

2. **User Login**: 
   - Regular users log in via the `UserLogin_UserControl`. After authentication, users can access functionalities such as searching for books, borrowing or returning books, and viewing their borrowing history.

3. **Database**:
   - The software interacts with a built-in database to store all operations securely. The database ensures that all activities are logged, and no data is lost. However, note that this database is fixed and cannot be transferred to other systems.

4. **Running the Application**:
   - To run the application, execute the `Project.exe` file located in the `bin/Debug` directory. This will launch the software and present the login interface.

This project provides a foundational framework for a library management system, demonstrating key concepts in user interface design, database interaction, and software security. It serves as a starting point for further development and refinement.
