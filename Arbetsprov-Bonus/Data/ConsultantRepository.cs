using Arbetsprov_Bonus.Entities;

namespace Arbetsprov_Bonus.Data;

public class ConsultantRepository : IConsultantRepository
{
    private readonly GisysDbContext _gisysDbContext;

    public ConsultantRepository(
        GisysDbContext gisysDbContext
    )
    {
        _gisysDbContext = gisysDbContext;
    }

    /// <inheritdoc/>
    public void Add(Consultant consultant)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IEnumerable<Consultant> Get()
    {
        return _gisysDbContext.Consultants.ToList();
    }

    /// <inheritdoc/>
    public Consultant GetById(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public void Update(Consultant consultant)
    {
        throw new NotImplementedException();
    }
}
