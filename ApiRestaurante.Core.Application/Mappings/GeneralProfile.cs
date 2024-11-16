using ApiRestaurante.Core.Application.Dtos.Account;
using ApiRestaurante.Core.Application.ViewModels.Ingredients;
using ApiRestaurante.Core.Application.ViewModels.Orders;
using ApiRestaurante.Core.Application.ViewModels.Plates;
using ApiRestaurante.Core.Domain.Entities;
using AutoMapper;
using RestauranteApi.Core.Application.ViewModels.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {





            #region Ingredients
            CreateMap<Ingredient, SaveIngredientViewModel>()
                .ReverseMap();
            
            
            CreateMap<Ingredient, IngredientViewModel>()
                .ReverseMap();


            CreateMap<SaveIngredientViewModel, IngredientViewModel>()
              .ReverseMap();
            #endregion





            #region Order
            CreateMap<Order, SaveOrderViewModel>()
                .ReverseMap()
                .ForMember(x => x.Mesa, opt => opt.Ignore());
                


            CreateMap<Order, OrderViewModel>()
                .ReverseMap()
                .ForMember(x => x.Mesa, opt => opt.Ignore()); 


            CreateMap<OrderViewModel, SaveOrderViewModel>()
              .ReverseMap();
            #endregion




            #region Plates
            CreateMap<Plate, SavePlateViewModel>()
                .ReverseMap();



            CreateMap<Plate, PlateViewModel>()
                .ReverseMap(); 
            
            CreateMap<SavePlateViewModel, PlateViewModel>()
                .ReverseMap();

            #endregion




            #region Tables
            CreateMap<Table, SaveTableViewModel>()
                .ReverseMap();



            CreateMap<Table, TableViewModel>()
                .ReverseMap();

            CreateMap<TableViewModel, SaveTableViewModel>()
                .ReverseMap();

            #endregion






        }
    }
}
