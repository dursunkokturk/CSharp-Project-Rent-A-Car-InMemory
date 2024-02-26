using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

// Brand Class ina Core Katmani Altindaki BaseEntity Class indan
// inheritance Yapiyoruz
// Class Icinde Kullanilacak Id Degerinin Veri Tipini Belirtiyoruz
public class Brand:BaseEntity<int>
{
    public string Name { get; set; }
}