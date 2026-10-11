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
{
	Console.WriteLine($"{application.ApplicationDate:yyyy-MM-dd} - {application.GetSummary()}");
}
	}
}