﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoAprendiz.Models
{
    public class OficinaView
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DataCriacao { get; set; }
    }
}