﻿using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>();

        Task<T> GetAsync<T>(int id);

        Task<T> CreateAsync<T>(CreateVillaDTO createDTO);

        Task<T> UpdateAsync<T>(UpdateVillaDTO updateDTO);

        Task<T> DeleteAsync<T>(int id);
    }
}