Console.WriteLine("Job Application Tracker");
// Create an instance of JobManager to manage job applications
JobManager manager = new JobManager();

JobApplication volvoJob = new JobApplication();
volvoJob.CompanyName = "Volvo";
volvoJob.PositionTitle = "Frontend Developer";
volvoJob.Status = ApplicationStatus.Applied;

JobApplication ikeaJob = new JobApplication();
ikeaJob.CompanyName = "IKEA";
ikeaJob.PositionTitle = "Backend Developer";
ikeaJob.Status = ApplicationStatus.Interview;

manager.AddJob(volvoJob);
manager.AddJob(ikeaJob);

manager.ShowByStatus(ApplicationStatus.Rejected);

