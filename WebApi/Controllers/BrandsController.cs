using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        // WebApi Katmani Uzerinden
        // Business Katmanina 
        // Business Katmanindan DataAccess Katmanina 
        // DataAccess Katmanindan Entity Katmani Uzerinden Data lara Ulasiyoruz
        IBrandService _brandService;

        // Ulasilan Datalari WebApi Katmaninda Yapilacak Isleme Dahil Etmek Icin
        // Parametreli Constructor Kullaniyoruz
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        // Ekleme Islemleri Icin Kullaniyoruz
        [HttpPost]

        // Dependency Injection Uzerinden Gelen Data yi
        // CreateBrandRequest Parametesi Uzerinden Ekleme Islemini Yapiyoruz
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse = _brandService.Add(createBrandRequest);

            // Database e Erisimin Saglandigini Ve
            // Ekleme Isleminin Yapildigini Belirtmek Icin
            // Status lardan Ok Kullaniyoruz
            return Ok(createBrandRequest);
        }

        // Database Icindeki Data lari Almak Icin Kullaniyoruz
        [HttpGet]
        public IActionResult Get()
        {
            // Dependency Injection Yontemi Ile Ulasilan Data lari Listeliyoruz
            return Ok(_brandService.GetAll());
        }
    }
}