using ASP.NETCoreWebAPI.DTOs;
using ASP.NETCoreWebAPI.Models;
using ASP.NETCoreWebAPI.RepositoryPattern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    { 
    private readonly IDataRepository<Location, LocationDTO> _dataRepository;
    public LocationController(IDataRepository<Location, LocationDTO> dataRepository)
    {
        _dataRepository = dataRepository;
    }

    // GET: api/Location
    [HttpGet]
    public IActionResult Get()
    {
        var authors = _dataRepository.GetAll();
        return Ok(authors);
    }
}
}