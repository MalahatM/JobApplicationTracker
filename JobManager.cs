class JobManager
{
// List to store job applications
    public List<JobApplication> Applications { get; set; } = new List<JobApplication>();
// Method to add a job application to the list
    public void AddJob(JobApplication application)
    {
        Applications.Add(application);
    }
	// Method to update the status of a job application based on the company name
	public void UpdateStatus(string companyName, ApplicationStatus newStatus)
	{
		var application = Applications.FirstOrDefault(a => a.CompanyName == companyName);
		if (application != null)
		{
			application.Status = newStatus;
		}
		
	}
	// Display all job applications
public void ShowAll()

{  // Check if there are any applications to display
	 if (Applications.Count == 0)
    {
        Console.WriteLine("No job applications found.");
        return;
    }
	// Loop through each application and print its summary
    foreach (var application in Applications)
    {
        Console.WriteLine(application.GetSummary());
    }
}
/// Display job applications filtered by their status
public void ShowByStatus(ApplicationStatus status)
{
    var filteredApplications = Applications.Where(
        application => application.Status == status
    );

    // Check if there are any applications with the specified status
    if (!filteredApplications.Any())
    {
        Console.WriteLine("No applications found with this status.");
        return;
    }
// Loop through each filtered application and print its summary
    foreach (var application in filteredApplications)
    {
        Console.WriteLine(application.GetSummary());
    }
}
// Method to sort job applications by date
public void SortByDate()
	{
		 var sortedApplications = Applications.OrderByDescending(
        application => application.ApplicationDate
    );
	foreach (var application in sortedApplications)
{// Print the application date and its summary
	Console.WriteLine($"{application.ApplicationDate:yyyy-MM-dd} - {application.GetSummary()}");
}
	}
	// Display statistics about job applications
public void ShowStatistics()
{
    int totalApplications = Applications.Count;
    Console.WriteLine($"Total applications: {totalApplications}");


	// Group job applications by their status using LINQ
var statusGroups = Applications.GroupBy(
    application => application.Status
);

// Display each status and the number of applications in that group
foreach (var group in statusGroups)
{
    Console.WriteLine($"{group.Key}: {group.Count()}");
}
// Filter job applications that have received a response
var respondedApplications = Applications.Where(
    application => application.ResponseDate.HasValue
);
// Calculate the average number of days to receive a response

if (respondedApplications.Any())
{// Calculate the average number of days to receive a response
    double averageResponseDays = respondedApplications.Average(
        application => (application.ResponseDate!.Value - application.ApplicationDate).TotalDays
    );

    Console.WriteLine($"Average days to respond: {averageResponseDays:F2}");
}
// If there are no applications that have received a response, display a message
else
{
    Console.WriteLine("No responses received yet.");
}
}
}