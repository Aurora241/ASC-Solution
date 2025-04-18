﻿using ASC.Model.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC.Model.Models
{
    public class MasterDataValue : BaseEntity, IAudetTracker
    {
        public MasterDataValue() { }

        public MasterDataValue(string masterDataPartitionKey, string value)
        {
            this.PatititonKey = masterDataPartitionKey;
            this.RowKey = Guid.NewGuid().ToString();
        }

        public bool IsActive { get; set; }
        public string Name { get; set; }
    }
}
