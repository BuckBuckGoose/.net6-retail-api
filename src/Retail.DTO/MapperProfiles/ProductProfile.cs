using AutoMapper;
using Retail.Domain;
using Retail.DTO.Input;
using Retail.DTO.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.DTO.MapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductDto, Product>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dest => dest.Stock,
                    opt => opt.MapFrom(src => src.Stock ?? 0))
                .ForMember(
                    dest => dest.Price,
                    opt => opt.MapFrom(src => src.Price))
                .ForMember(
                    dest => dest.ForSale,
                    opt => opt.MapFrom(src => src.ForSale))
                ;

            CreateMap<Product, DisplayProductDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dest => dest.Stock,
                    opt => opt.MapFrom(src => src.Stock))
                .ForMember(
                    dest => dest.Price,
                    opt => opt.MapFrom(src => src.Price))
                ;

            CreateMap<UpdateProductDto, Product>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.Condition(src => src.Name != null ))
                .ForMember(
                    dest => dest.Description,
                    opt => opt.Condition(src => src.Description != null))
                .ForMember(
                    dest => dest.Price,
                    opt => opt.Condition(src => src.Price != null))
                .ForMember(
                    dest => dest.ForSale,
                    opt => opt.Condition(src => src.ForSale != null));



        }
    }
}
