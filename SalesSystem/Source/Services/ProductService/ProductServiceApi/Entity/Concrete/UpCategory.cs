﻿using ProductServiceApi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Entity.Concrete
{
    public class UpCategory : IEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string UpCategoryName { get; set; }

    }
}
