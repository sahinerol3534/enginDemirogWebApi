using Businerss.Abstracts;
using Businerss.Dtos.Requests;
using Businerss.Dtos.Responses;
using DataAccess.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    IBrandService _brandService;
    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }
    [HttpPost]
    public  IActionResult Add(CreatedBrandRequest createBrandRequest)
    {
        CreatedBrandResponse createdBrandResponse = _brandService.Add(createBrandRequest);
        return Ok(createdBrandResponse);

    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_brandService.GetAll());
    }
}
