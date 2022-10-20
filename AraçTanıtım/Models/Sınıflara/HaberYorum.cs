using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AracTanitim.Models.Sınıflara
{
    public class HaberYorum
    {
        public IEnumerable <Haber> Deger1 { get; set; }
        public IEnumerable <Yorumlar> Deger2 { get; set; }
        public IEnumerable<Haber> Deger3 { get; set; }
    }
}