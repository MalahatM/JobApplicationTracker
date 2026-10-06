
// This class represents a job application with relevant details such as company name, position title, application status, application date, and salary expectation.
class JobApplication
{
    public string CompanyName { get; set; } = "";
    public string PositionTitle { get; set; } = "";
    public ApplicationStatus Status { get; set; }
    public DateTime ApplicationDate { get; set; }

    // We don't know the response date yet, so we make it nullable.
    public DateTime? ResponseDate { get; set; }

    public int SalaryExpectation { get; set; }

// Calculates how many days have passed since the job application was submitted.
    public int GetDaysSinceApplied()
    {
        TimeSpan timeSinceApplied = DateTime.Today - ApplicationDate;
        return timeSinceApplied.Days;
    }
	
	// Returns a short summary of the job application.
public string GetSummary()
{
    return $"{CompanyName} - {PositionTitle} - {Status}";
}
}
// This enum represents the different statuses that a job application can have, including Applied, Interview, Offer, and Rejected.
enum ApplicationStatus
{
    Applied,
    Interview,
    Offer,
    Rejected
}


