namespace Arbetsprov_Bonus.Entities;

public class Consultant
{
    public Consultant(string firstName, string lastName, DateTime startDate)
    {
        FirstName = firstName;
        LastName = lastName;
        StartDate = startDate;
    }

    public Consultant(string firstName, string lastName, DateTime startDate, uint id)
    {
        FirstName = firstName;
        LastName = lastName;
        StartDate = startDate;
        Id = id;
    }

    public uint Id { get; set; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
}
