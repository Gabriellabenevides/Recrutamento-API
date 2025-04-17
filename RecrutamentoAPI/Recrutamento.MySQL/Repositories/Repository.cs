using Microsoft.EntityFrameworkCore;
using Recrutamento.Domain.Interface;
using Recrutamento.MySQL.MySQL;

namespace Recrutamento.MySQL;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly MySQLContext _context;
    private readonly DbSet<TEntity> _dbSet;
    public Repository(MySQLContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }
    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }
    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
    public async Task AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}