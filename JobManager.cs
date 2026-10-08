class JobManager
{
// List to store job applications
    public List<JobApplication> Applications { get; set; } = new List<JobApplication>();
// Method to add a job application to the list
    public void AddJob(JobApplication application)
    {
        Applications.Add(application);
    }
}