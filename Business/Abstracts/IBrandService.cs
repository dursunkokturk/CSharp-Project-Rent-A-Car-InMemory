﻿using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
    // Business Katmani Altindaki
    // Dtos Katmani Altinda Bulunan
    // Responses Katmani Altindaki
    // CreatedBrandResponse Class ile Data Id Data Name ve Data Created Date Bilgilerine Ulasiyoruz
    // CreateBrandRequest Parametresi Uzerinden Data Name Bilgisini Ekliyoruz
    CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);

    // Business Katmani Altinda
    // Dtos Katmani Altinda
    // Responses Katmani Altinda Bulunan
    // GetAllBrandResponse Class i Uzerinden
    // Eklenen Data nin Id, Name, Created Date Bilgilerini Listeliyoruz
    List<GetAllBrandResponse> GetAll();
}