﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cash_Machine.Models
{
    public class OperationType
    {
        public OperationType()
        {
            //CardOperation = new HashSet<CardOperation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<CardOperation> CardOperation { get; set; }
    }
}