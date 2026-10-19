namespace ClientOnboardingApi.Models;

public class Address
{
    public int Id { get; set; }

    public string AddressType { get; set; } = string.Empty;

    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;

    public int PersonalId { get; set; }

    public Personal? Personal { get; set; }
}