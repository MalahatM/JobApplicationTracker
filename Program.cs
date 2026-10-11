Console.WriteLine("Job Application Tracker");
// Create an instance of JobManager to manage job applications by date
JobManager manager = new JobManager();

JobApplication volvoJob = new JobApplication();
volvoJob.CompanyName = "Volvo";
volvoJob.PositionTitle = "Frontend Developer";
volvoJob.ApplicationDate = new DateTime(2026, 10, 5);

JobApplication ikeaJob = new JobApplication();
ikeaJob.CompanyName = "IKEA";
ikeaJob.PositionTitle = "Backend Developer";
ikeaJob.ApplicationDate = new DateTime(2026, 10, 10);

JobApplication spotifyJob = new JobApplication();
spotifyJob.CompanyName = "Spotify";
spotifyJob.PositionTitle = "React Developer";
spotifyJob.ApplicationDate = new DateTime(2026, 10, 2);

manager.AddJob(volvoJob);
manager.AddJob(ikeaJob);
manager.AddJob(spotifyJob);

manager.SortByDate();


