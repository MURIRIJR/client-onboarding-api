using AutoMapper;
using ClientOnboardingApi.DTOs.Address;
using ClientOnboardingApi.DTOs.Onboarding;
using ClientOnboardingApi.DTOs.Personal;
using ClientOnboardingApi.Models;

namespace ClientOnboardingApi.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreatePersonalDto, Personal>();
        CreateMap<UpdatePersonalDto, Personal>();
        CreateMap<Personal, PersonalResponseDto>();

        CreateMap<CreateAddressDto, Address>();
        CreateMap<Address, AddressResponseDto>();

        CreateMap<CreateOnboardingDto, Onboarding>();
        CreateMap<Onboarding, OnboardingResponseDto>();
    }
}