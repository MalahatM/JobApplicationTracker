
// Display the application title
Console.WriteLine("Job Application Tracker");

// Create a JobManager object to manage job applications
JobManager manager = new JobManager();

// Store the user's menu choice
int choice = 0;

// Keep showing the menu until the user chooses 8 (Exit)
while (choice != 8)
{
    // Display the main menu options
    Console.WriteLine("1. Add job application");
    Console.WriteLine("2. Show all applications");
    Console.WriteLine("3. Filter by status");
    Console.WriteLine("4. Sort by date");
    Console.WriteLine("5. Show statistics");
    Console.WriteLine("6. Update status");
    Console.WriteLine("7. Delete application");
    Console.WriteLine("8. Exit");
	// Display the unanswered applications menu option
Console.WriteLine("9. Show unanswered applications (over 14 days)");

    // Ask the user to choose an option
    Console.Write("Enter your choice: ");

    // Try to convert the user's input to an integer
    bool isValid = int.TryParse(Console.ReadLine(), out choice);

    // Check if the user entered a valid number
    if (!isValid)
    {
        Console.WriteLine("Invalid input. Please enter a number.");

        // Skip the rest of this loop and show the menu again
        continue;
    }

    // The switch statement continues here
// Handle the user's choice using a switch statement
switch (choice)
{
// Add a new job application
case 1:
    // Ask the user to enter the company name
    Console.Write("Enter company name: ");
    string newCompanyName = Console.ReadLine()!;

    // Check if the company name is empty or contains only spaces
    if (string.IsNullOrWhiteSpace(newCompanyName))
    {
        Console.WriteLine("Company name cannot be empty.");
        break;
    }

    // Ask the user to enter the position title
    Console.Write("Enter position title: ");
    string positionTitle = Console.ReadLine()!;

    // Check if the position title is empty or contains only spaces
    if (string.IsNullOrWhiteSpace(positionTitle))
    {
        Console.WriteLine("Position title cannot be empty.");
        break;
    }

    // Ask the user to enter the expected salary
    Console.Write("Enter salary expectation: ");

    // Try to convert the user's input to an integer
    bool isSalaryValid = int.TryParse(Console.ReadLine(), out int salary);

    // Check if the salary is a valid positive number
    if (!isSalaryValid || salary <= 0)
    {
        Console.WriteLine("Invalid salary. Please enter a positive number.");
        break;
    }

    // Set the application date to today
    DateTime applicationDate = DateTime.Today;

    // Create a new job application object
    JobApplication newApplication = new JobApplication();

    // Assign the user's input to the object properties
    newApplication.CompanyName = newCompanyName;
    newApplication.PositionTitle = positionTitle;
    newApplication.SalaryExpectation = salary;
    newApplication.ApplicationDate = applicationDate;

    // Set the initial application status to Applied
    newApplication.Status = ApplicationStatus.Applied;

    // Add the new application to the list
    manager.AddJob(newApplication);

    break;

// Show all job applications
case 2:
    manager.ShowAll();
    break;

// Filter job applications by status
// Filter job applications by status
case 3:
    // Ask the user to select an application status
    Console.WriteLine("Choose status: 0. Applied, 1. Interview, 2. Offer, 3. Rejected");

    // Try to convert the user's input to an integer
    bool isStatusValid = int.TryParse(Console.ReadLine(), out int selectedStatus);

    // Check if the input is a number between 0 and 3
    if (!isStatusValid || selectedStatus < 0 || selectedStatus > 3)
    {
        Console.WriteLine("Invalid status. Please enter a number between 0 and 3.");
        break;
    }

    // Convert the number to ApplicationStatus and filter applications
    manager.ShowByStatus((ApplicationStatus)selectedStatus);
    break;

// Sort job applications by date
case 4:
    manager.SortByDate();
    break;

// Show statistics about job applications
case 5:
    manager.ShowStatistics();
    break;

// Update the status of an existing job application
case 6:
    // Ask the user to enter the company name
    Console.Write("Enter company name to update: ");
    string company = Console.ReadLine()!;
	// Check if the company name is empty or contains only spaces
   if (string.IsNullOrWhiteSpace(company))
{
    Console.WriteLine("Company name cannot be empty.");
    break;
}

    // Ask the user to select a new status
    Console.WriteLine("Choose new status: 0. Applied, 1. Interview, 2. Offer, 3. Rejected");
   // Try to convert the new status input to an integer
   bool isNewStatusValid = int.TryParse(Console.ReadLine(), out int newStatus);
   // Check if the new status is a valid number between 0 and 3
if (!isNewStatusValid || newStatus < 0 || newStatus > 3)
{
    Console.WriteLine("Invalid status. Please enter a number between 0 and 3.");
    break;
}

    // Update the application status
    manager.UpdateStatus(company, (ApplicationStatus)newStatus);
    break;

// Delete a job application
case 7:
    // Ask the user to enter the company name
    Console.Write("Enter company name to delete: ");
    string companyName = Console.ReadLine()!;
	// Check if the company name is empty or contains only spaces
if (string.IsNullOrWhiteSpace(companyName))
{
    Console.WriteLine("Company name cannot be empty.");
    break;
}

    // Delete the application from the list
    manager.DeleteJob(companyName);
    break;

// Exit the application
case 8:
    Console.WriteLine("Exiting the program.");
    break;

	

// Show applications unanswered for more than 14 days
case 9:
    manager.ShowUnansweredApplications();
    break;


// Handle invalid menu choices
default:
    Console.WriteLine("Invalid option. Please try again.");
    break;
}
}