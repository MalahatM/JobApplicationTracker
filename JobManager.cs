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
	
}