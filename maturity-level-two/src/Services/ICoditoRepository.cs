﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Codit.LevelTwo.Entities;

namespace Codit.LevelTwo.Services
{
    public interface ICoditoRepository
    {
        Task<bool> CarExistsAsync(int id);

        Task<IEnumerable<Car>> GetCarsAsync(CarBodyType? bodyType);

        Task<Car> GetCarAsync(int id, bool includeCustomization);

        Task<IEnumerable<Customization>> GetAllCustomizationsAsync();

        Task<Customization> GetCustomizationAsync(int id);

        Task CreateCustomizationAsync(Customization customization);
        //Task ApplyPatchAsync<TEntity, TDto>(TEntity entityToUpdate, TDto dto) where TEntity : class;
        Task ApplyPatchAsync<TEntity>(TEntity entityUpdated) where TEntity : class;

        Task ApplyCustomizationSaleAsync(Customization customization);

        Task DeleteCustomizationAsync(int id);


    }
}
