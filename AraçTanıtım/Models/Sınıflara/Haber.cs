﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AracTanitim.Models.Sınıflara
{
    public class Haber
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string HaberImage { get; set; }
        public ICollection <Yorumlar> Yorumlars { get; set; }
    }
}