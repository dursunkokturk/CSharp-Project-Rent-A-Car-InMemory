using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class BrandDal : IBrandDal
{
    List<Brand> _brands;

    public BrandDal()
    {
        // InMemory Calisacak Bir Rent A Car Projesi Yapiyoruz
        _brands = new List<Brand>(); ;
        _brands.Add(new Brand { Id = 1, Name = "BMW", CreatedDate = DateTime.Now });
        _brands.Add(new Brand { Id = 2, Name = "Mercedes", CreatedDate = DateTime.Now });
        _brands.Add(new Brand { Id = 3, Name = "Alfa Romeo", CreatedDate = DateTime.Now });
    }

    // Brand Parametresi Uzerinden Gelen Data yi Ekliyoruz
    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }

    // Brand Object Icindeki Data lari Listeliyoruz
    public List<Brand> GetAll()
    {
        return _brands;
    }
}