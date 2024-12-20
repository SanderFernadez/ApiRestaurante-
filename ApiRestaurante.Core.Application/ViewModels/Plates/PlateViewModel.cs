﻿

using ApiRestaurante.Core.Domain.Entities;
using ApiRestaurante.Core.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ApiRestaurante.Core.Application.ViewModels.Plates
{
    public class PlateViewModel
    {
        public int Id { get; set; }

        
        [MaxLength(100)]
        public string Name { get; set; } 

       
        public decimal Price { get; set; } 

       
        public int Servings { get; set; }

       
        public PlateCategory Category { get; set; }
        
    }
}
