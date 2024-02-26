using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

// Bu Class Core Katmaninda Olusturulmasina Ragmen
// Projenin Cekirdeginde Yer Alan Katmandir

// TId Class in Data Tipidir
public class BaseEntity<TId>
{
    // Id Field inin Data Tipini TId Olarak Belirtiyoruz
    public TId Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }

    // DateTime Data Tipinin Yanina ? Koyarsak
    // Bu Data Tipi Icin Deger Girmek Zorunlu Olmaz
    public DateTime? UpdatedDate { get; set; }

    // DateTime Data Tipinin Yanina ? Koyarsak
    // Bu Data Tipi Icin Deger Girmek Zorunlu Olmaz
    public DateTime? DeletedDate { get; set; }
}