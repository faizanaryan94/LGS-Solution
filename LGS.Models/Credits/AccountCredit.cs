﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LGS.Models.Users;

namespace LGS.Models.Credits
{
    // Will contains Transaction information against Specific Account
    // which will include company transaction info but it will be brief
    // since one client can have multiple companies but it will show whole
    // transaction irrelevant of companies.
    public class AccountCredit
    {
        public int Id { get; set; }
        public decimal TotalCredits { get; set; }
        public decimal AvailableCredits { get; set; }
        public string TransactionId { get; set; }
        public string InvoiceNo { get; set; }


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