using System;

namespace BankingAPI.Models
{
    public class P2PInternalMultiple
    {
       
        public long PartnerId { get; set; }
        public long BusinessUnitId { get; set; }
        public string FromTaxNumber { get; set; }

        public string FromBank { get; set; }
        public string FromBankBranch { get; set; }
        public string FromBankAccount { get; set; }
        public string FromBankAccountDigit { get; set; }

        public string ToTaxNumber { get; set; }

        public string ToBank { get; set; }
        public string ToBankBranch { get; set; }
        public string ToBankAccount { get; set; }
        public string ToBankAccountDigit { get; set; }

        
        public decimal Value { get; set; }
        public decimal RateValue { get; set; }
        public DateTime TransferDate { get; set; }
        public string Identifier { get; set; }
        
 
        public string[] Tags { get; set; }

        public string Description { get; set; }
        
        public string ToName { get; set; }
        public string ToPhone { get; set; }
        public string ToEmail { get; set; }
    }
}