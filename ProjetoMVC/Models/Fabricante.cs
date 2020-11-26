﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMVC.Models
{
    public class Fabricante
    {
        
        public long? FabricanteID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos{ get; set; }
    }
}