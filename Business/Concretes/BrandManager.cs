using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

// IBrandService Interface i Ile Add Ve GetAll Fonksiyonlarini Implement Ediyoruz

public class BrandManager : IBrandService
{
    // Brand Ekleme Ve Listeleme Islemlerinin Oldugu Interface i
    // Dependency Injection Olarak Aliyoruz
    IBrandDal _brandDal;

    // Dependency Injection Yontemi Ile Gelen Bilgileri Parametreli Constructor Ile
    // BrandManager Class i Icine Dahil Ediyoruz
    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    // Mapping Isleminin Yapilacagi Alan
    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        /*
        
        Bu Alanda Ilk Olarak Database Islemlerini Yapiyoruz

        */
        
        // Database Ile Iletisim Kurmak Icin Brand Objesi Olusturuyoruz
        Brand brand = new();

        // Brand Objesi Uzerinden
        // Business Katmani Altinda
        // Dtos Katmani Altinda
        // Requests Katmani Altindaki
        // CreateBrandRequest Class i Uzerinden
        // Database Icindeki Name Alanina Ulasiyoruz
        brand.Name = createBrandRequest.Name;

        // Ulasilan Name Bilgisine brand Degiskeni Uzerinden 
        // Data Gonderiyoruz
        _brandDal.Add(brand);

        // Database e Eklenen Data nin Bilgilerini Son Kullaniciya Gostermek Icin
        // CreatedBrandResponse Objesi Olusturuyoruz
        // Olusturulan Obje Uzerinden Eklenen Data nin Id, Name, Created Date Bilgilerini Gosteriyoruz
        CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
        createdBrandResponse.Id = 4;
        createdBrandResponse.Name = brand.Name;
        createdBrandResponse.CreatedDate = brand.CreatedDate;

        return createdBrandResponse;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands = _brandDal.GetAll();

        // Database Icindeki Brand lerin Id, Name Ve Created Time
        // Bilgilerini GetAllBrandResponse Object Olusturarak Aliyoruz
        List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();

        // Database Icinden List Object Olarak Alinan Brand lerin Id, Name Ve Created Time
        // Bilgilerini brands Degiskeni Uzerinden Aliyoruz
        // brand Degiskeni Uzerinden Yeni Listedeki Yerlerine map leme Yapiyoruz
        foreach (var brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
            getAllBrandResponse.Id = brand.Id;
            getAllBrandResponse.Name = brand.Name;
            getAllBrandResponse.CreatedTime = brand.CreatedDate;

            // map leme Isleminden Sonra getAllBrandResponse Degiskeni Uzerinden
            // Add Fonksiyonu Ile Yeni Listeye Ekleme Yapiyoruz
            getAllBrandResponses.Add(getAllBrandResponse);
        }

        return getAllBrandResponses;
    }
}