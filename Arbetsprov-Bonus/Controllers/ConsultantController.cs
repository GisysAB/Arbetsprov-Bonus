using Arbetsprov_Bonus.Data;
using Arbetsprov_Bonus.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Arbetsprov_Bonus.Controllers;

[Route("[controller]")]
[ApiController]
public class ConsultantController : ControllerBase
{
    private readonly IConsultantRepository _consultantRepository;

    public ConsultantController(
        IConsultantRepository consultantRepository    
    )
    {
        _consultantRepository = consultantRepository;
    }

    [HttpGet]
    public IEnumerable<Consultant> Get()
    {
        return _consultantRepository.Get();
    }

    //public Consultant GetById(long id)
    //{
    //    throw new NotImplementedException();
    //}

    //public Consultant Add(string consultant)
    //{
    //    throw new NotImplementedException();
    //}

    //public Consultant Remove()
    //{
    //    throw new NotImplementedException();
    //}

    //public Consultant Update(bool yes)
    //{
    //    throw new NotImplementedException();
    //}
}
