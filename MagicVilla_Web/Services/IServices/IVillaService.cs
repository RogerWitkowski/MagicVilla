﻿using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>();

        Task<T> GetAsync<T>(int id);

        Task<T> CreateAsync<T>(CreateVillaNumberDTO createDTO);

        Task<T> UpdateAsync<T>(UpdateVillaNumberDTO updateDTO);

        Task<T> DeleteAsync<T>(int id);
    }
}