using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface ILotePersist
    {
        /// <summary>
        /// Método get que retornará uma lista de lotes por eventoId.
        /// </summary>
        /// <param name="eventoId">Código chave da tabela de Evento</param>
        /// <returns>Lista de Lotes</returns>
        Task<Lote[]> GetLotesByEventoIdAsync(int eventoId);

        /// <summary>
        /// Método get que retornará apenas um Lote
        /// </summary>
        /// <param name="loteId">Código chave da tabela de Evento</param>
        /// <param name="id">Código chave do meu Lote</param>
        /// <returns>Apenas um Lote</returns>
        Task<Lote> GetLoteByIdsAsync(int eventoId, int id);
    }
}