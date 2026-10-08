Console.WriteLine("Job Application Tracker");
JobManager manager = new JobManager();
// Create a new job application for Volvo (example)
JobApplication volvoJob = new JobApplication();

volvoJob.CompanyName = "Volvo";
volvoJob.PositionTitle = "Frontend Developer";
volvoJob.Status = ApplicationStatus.Applied;
// Add the job application to the manager
manager.AddJob(volvoJob);
Console.WriteLine(manager.Applications.Count);