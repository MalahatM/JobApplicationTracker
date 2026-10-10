Console.WriteLine("Job Application Tracker");

JobManager manager = new JobManager();
// Create a new job application for Volvo(testing purposes)
JobApplication volvoJob = new JobApplication();

volvoJob.CompanyName = "Volvo";
volvoJob.PositionTitle = "Frontend Developer";
volvoJob.Status = ApplicationStatus.Applied;

manager.AddJob(volvoJob);

manager.ShowAll();