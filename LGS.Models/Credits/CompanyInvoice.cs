﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGS.Models.Companies;

namespace LGS.Models.Credits
{
    // Will contains Transaction information against Company entity only.

    public class CompanyInvoice
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public string ItemSkuCode { get; set; }

        public decimal Credits { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }

        public int ClientId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime UpdatedDate { get; set; }
    }
}
