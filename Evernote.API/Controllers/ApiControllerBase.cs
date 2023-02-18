namespace Evernote.API.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public abstract class ApiControllerBase<T> : ControllerBase
{
    protected ApiControllerBase(IMapper mapper)
    {
        Mapper = mapper;
    }

    protected ApiControllerBase(IMapper mapper, ILogger<T> logger)
        : this(mapper)
    {
        Logger = logger;
    }

    public IMapper Mapper { get; }

    protected ILogger<T> Logger { get; }
}
