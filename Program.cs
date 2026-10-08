Console.WriteLine("Job Application Tracker");

// Create a JobManager object
JobManager manager = new JobManager();

// Create a job application for Volvo
JobApplication volvoJob = new JobApplication();

volvoJob.CompanyName = "Volvo";
volvoJob.Status = ApplicationStatus.Applied;

// Add the job application to the list
manager.AddJob(volvoJob);

// Update the status from Applied to Interview
manager.UpdateStatus("Volvo", ApplicationStatus.Interview);

// Display the updated status
Console.WriteLine(volvoJob.Status);