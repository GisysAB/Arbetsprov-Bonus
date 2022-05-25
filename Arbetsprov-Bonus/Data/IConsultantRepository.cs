using Arbetsprov_Bonus.Entities;

namespace Arbetsprov_Bonus.Data;

public interface IConsultantRepository
{
    /// <summary>
    /// Gets all the Consultants from the InMemory database
    /// </summary>
    IEnumerable<Consultant> Get();

    /// <summary>
    /// 
    /// </summary>
    Consultant GetById(int id);

    /// <summary>
    /// 
    /// </summary>
    void Remove(int id);

    /// <summary>
    /// 
    /// </summary>
    void Add(Consultant consultant);

    /// <summary>
    /// 
    /// </summary>
    void Update(Consultant consultant);
}
