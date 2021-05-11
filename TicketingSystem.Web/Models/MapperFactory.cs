// <copyright file="MapperFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;

    /// <summary>
    /// This class MapperFactory.
    /// </summary>
    public class MapperFactory
    {
        /// <summary>
        /// Imapper method.
        /// </summary>
        /// <returns>Returns IMapper .</returns>
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TicketingSystem.Data.CodeFirstDB.Cashier, TicketingSystem.Web.Models.Cashier>().
                ForMember(dest => dest.Id, map => map.MapFrom(src => src.CashierId)).
                ForMember(dest => dest.Name, map => map.MapFrom(src => src.CashierName)).
                ForMember(dest => dest.Address, map => map.MapFrom(src => src.Address)).
                ForMember(dest => dest.BankAccount, map => map.MapFrom(src => src.BankAccount)).
                ForMember(dest => dest.Salary, map => map.MapFrom(src => src.Salary)).
                ForMember(dest => dest.Insurance, map => map.MapFrom(src => src.Insurance));
            });
            return config.CreateMapper();
        }
    }
}
