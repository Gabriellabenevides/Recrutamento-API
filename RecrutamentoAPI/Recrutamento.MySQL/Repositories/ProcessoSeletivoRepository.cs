using Recrutamento.Domain.Entities;
using Recrutamento.Domain.Interface;
using Recrutamento.MySQL.MySQL;

namespace Recrutamento.MySQL.Repositories;

public class ProcessoSeletivoRepository : Repository<ProcessoSeletivo>, IProcessoSeletivoRepository
{
    public ProcessoSeletivoRepository(MySQLContext context) : base(context)
    {
    }
}
