﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
  [Table("Tags")]
  public class Tag
  {
    [Key]
    [MaxLength(50)]
    public string ID { set; get; }

    [MaxLength(50)]
    [Required]
    public string Name { get; set; }

    [MaxLength(50)]
    [Required]
    public string Type { get; set; }
  }
}