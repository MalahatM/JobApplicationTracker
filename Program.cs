Console.WriteLine("Job Application Tracker");

JobManager manager = new JobManager();

JobApplication volvoJob = new JobApplication();
volvoJob.CompanyName = "Volvo";

JobApplication ikeaJob = new JobApplication();
ikeaJob.CompanyName = "IKEA";

manager.AddJob(volvoJob);
manager.AddJob(ikeaJob);

// Display applications before deletion
manager.ShowAll();

// Delete IKEA
manager.DeleteJob("IKEA");

// Display applications after deletion
manager.ShowAll();
// Test deleting a company that does not exist
manager.DeleteJob("Google");

