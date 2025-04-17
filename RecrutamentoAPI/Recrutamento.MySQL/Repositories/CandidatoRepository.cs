using Recrutamento.Domain.Entities;
using Recrutamento.Domain.Interface;
using Recrutamento.MySQL.MySQL;

namespace Recrutamento.MySQL.Repositories;

public class CandidatoRepository : Repository<Candidato>, ICandidatoRepository
{
    public CandidatoRepository(MySQLContext context) : base(context)
    {
    }
}
