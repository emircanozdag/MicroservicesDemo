﻿using AuctionService.Dtos;
using AuctionService.Entites;
using AutoMapper;
using Contracts;

namespace AuctionService;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Auction, AuctionDto>().IncludeMembers(i => i.Item);
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>().ForMember(d => d.Item, o => o.MapFrom(s => s));
        CreateMap<CreateAuctionDto, Item>();
        CreateMap<AuctionDto, AuctionCreated>();
        CreateMap<Auction, AuctionUpdated>().IncludeMembers(i => i.Item);
        CreateMap<Item, AuctionUpdated>();
    }
}
