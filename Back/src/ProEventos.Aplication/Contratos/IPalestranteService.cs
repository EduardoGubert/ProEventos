using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Aplication.Contratos
{
    public interface IPalestranteService
    {
        Task<Palestrante> AddEventos(Palestrante model);
        Task<Palestrante> UpdateEventos(int eventoId, Palestrante model);
        Task<bool> DeleteEventos(int eventoId);
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesByAsync(bool includeEventos);
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos);

    }
}