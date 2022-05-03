using Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private readonly ILogger<T> _logger;
        private DbSet<T> _dataset;
        
        public BaseRepository(ILogger<T> logger)
        {
            _logger = logger;
        }

        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();

        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                _logger.LogInformation("Iniciando a tentativa de deletar o usuário da base de dados.");

                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

                if(result == null)
                {
                    _logger.LogWarning($"Id não encontrado na base. Id = {id}");
                    return false;
                }

                _dataset.Remove(result);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Usuário deletado com sucesso.");

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERRO: {ex}");
                throw ex;
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                _logger.LogInformation("Iniciando o Insert no banco de dados.");

                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }

                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();

                _logger.LogInformation($"Dados salvos com sucesso para o Guid: {item.Id}");

            }
            catch (Exception ex)
            {
                _logger.LogError($"ERRO: {ex}");
                throw ex;
            }

            return item;
        }

        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                _logger.LogInformation($"Buscando o Id do usuário no banco de dados.");
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

                if(result == null)
                {
                    _logger.LogWarning($"Id não localizado. Id = {id}");
                }

                return result;
            }
            catch (Exception ex)
            {

                _logger.LogError($"ERRO: {ex}");
                throw ex;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                _logger.LogInformation("Iniciando a tentativa de atualização no banco de dados.");

                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));

                if(result == null)
                {
                    _logger.LogWarning($"Id não encontrado na base. Id = {item.Id}");
                    return null;
                }

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt; //garantindo que se mantenha a data de criação

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Dados atualizados com sucesso para o Id: {item.Id}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERRO: {ex}");
                throw ex;
            }

            return item;
        }
    }
}
