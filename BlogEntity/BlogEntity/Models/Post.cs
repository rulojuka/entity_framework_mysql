﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEntity.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string Categoria { get; set; }
    }
}