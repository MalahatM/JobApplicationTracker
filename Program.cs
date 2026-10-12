Console.WriteLine("Job Application Tracker");

JobManager manager = new JobManager();

int choice = 0;
while (choice != 8)
{
    Console.WriteLine("1. Add job application");
    Console.WriteLine("2. Show all applications");
    Console.WriteLine("3. Filter by status");
    Console.WriteLine("4. Sort by date");
    Console.WriteLine("5. Show statistics");
    Console.WriteLine("6. Update status");
    Console.WriteLine("7. Delete application");
    Console.WriteLine("8. Exit");

	Console.Write("Enter your choice: ");
choice = Convert.ToInt32(Console.ReadLine());
// Handle the user's choice using a switch statement
switch (choice)
{
// Add a new job application
case 1:
    // Ask the user to enter the company name
    Console.Write("Enter company name: ");
    string newCompanyName = Console.ReadLine()!;

    // Ask the user to enter the position title
    Console.Write("Enter position title: ");
    string positionTitle = Console.ReadLine()!;

    // Ask the user to enter the expected salary
    Console.Write("Enter salary expectation: ");
    int salary = Convert.ToInt32(Console.ReadLine());

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
case 3:
    // Ask the user to select a status
    Console.WriteLine("Choose status: 0. Applied, 1. Interview, 2. Offer, 3. Rejected");
    int selectedStatus = Convert.ToInt32(Console.ReadLine());

    // Show applications with the selected status
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

    // Ask the user to select a new status
    Console.WriteLine("Choose new status: 0. Applied, 1. Interview, 2. Offer, 3. Rejected");
    int newStatus = Convert.ToInt32(Console.ReadLine());

    // Update the application status
    manager.UpdateStatus(company, (ApplicationStatus)newStatus);
    break;

// Delete a job application
case 7:
    // Ask the user to enter the company name
    Console.Write("Enter company name to delete: ");
    string companyName = Console.ReadLine()!;

    // Delete the application from the list
    manager.DeleteJob(companyName);
    break;

// Exit the application
case 8:
    Console.WriteLine("Exiting the program.");
    break;


// Handle invalid menu choices
default:
    Console.WriteLine("Invalid option. Please try again.");
    break;
}
}