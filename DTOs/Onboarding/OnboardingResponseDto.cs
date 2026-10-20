namespace ClientOnboardingApi.DTOs.Onboarding;

public class OnboardingResponseDto
{
    public int Id { get; set; }

    public int PersonalId { get; set; }

    public string Status { get; set; } = string.Empty;

    public int CurrentStep { get; set; }

    public DateTime? SubmittedAt { get; set; }
}