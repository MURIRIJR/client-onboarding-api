using System.Text.Json.Serialization;

namespace ClientOnboardingApi.Models;

public class Onboarding
{
    public int Id { get; set; }

    public int PersonalId { get; set; }

    public string Status { get; set; } = "DRAFT";

    public int CurrentStep { get; set; } = 1;

    public DateTime? SubmittedAt { get; set; }

    [JsonIgnore]
    public Personal? Personal { get; set; }
}