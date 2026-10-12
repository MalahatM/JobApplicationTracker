Console.WriteLine("Job Application Tracker");

JobManager manager = new JobManager();
// Create test job applications
JobApplication volvoJob = new JobApplication();
volvoJob.CompanyName = "Volvo";
volvoJob.Status = ApplicationStatus.Applied;
volvoJob.ApplicationDate = new DateTime(2026, 10, 1);
volvoJob.ResponseDate = new DateTime(2026, 10, 5);

JobApplication ikeaJob = new JobApplication();
ikeaJob.CompanyName = "IKEA";
ikeaJob.Status = ApplicationStatus.Interview;
ikeaJob.ApplicationDate = new DateTime(2026, 10, 2);
ikeaJob.ResponseDate = new DateTime(2026, 10, 10);

// Add test applications to the manager
manager.AddJob(volvoJob);
manager.AddJob(ikeaJob);
// Create a test application without a response
JobApplication spotifyJob = new JobApplication();
spotifyJob.CompanyName = "Spotify";
spotifyJob.Status = ApplicationStatus.Applied;
spotifyJob.ApplicationDate = new DateTime(2026, 10, 3);

manager.AddJob(spotifyJob);

manager.ShowStatistics();

