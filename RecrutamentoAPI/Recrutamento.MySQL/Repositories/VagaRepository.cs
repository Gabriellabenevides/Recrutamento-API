using Recrutamento.Domain.Entities;
using Recrutamento.Domain.Interface;
using Recrutamento.MySQL.MySQL;

namespace Recrutamento.MySQL.Repositories;

public class VagaRepository : Repository<Vaga>, IVagaRepository
{
    public VagaRepository(MySQLContext context) : base(context)
    {
    }
}
