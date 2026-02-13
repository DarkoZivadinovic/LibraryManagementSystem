public class Member
{
    public int Id {get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string FullName { get { return $"{FirstName} {LastName}";}}
    public Member( string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("FirstName cannot be empty");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("LastName cannot be empty");

        FirstName = firstName;
        LastName = lastName;
    }
  
}