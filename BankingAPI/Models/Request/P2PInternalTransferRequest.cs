using System;

namespace BankingAPI.Models.Request
{
    public class P2PInternalTransferRequest
    { 
            public long PartnerId { get; set; } 
            public long BusinessUnitId { get; set; }
            public string FromTaxNumber { get; set; }
#nullable enable
            public string? FromBank { get; set; }
            public string? FromBankBranch { get; set; }
            public string? FromBankAccount { get; set; }
            public string? FromBankAccountDigit { get; set; }
#nullable disable
            public string ToTaxNumber { get; set; }
#nullable enable
            public string? ToBank { get; set; }
            public string? ToBankBranch { get; set; }
            public string? ToBankAccount { get; set; }
            public string? ToBankAccountDigit { get; set; }
#nullable  disable
        
            public decimal Value { get; set; }
            public decimal RateValue { get; set; }
            public DateTime TransferDate { get; set; }
            public string Identifier { get; set; }
        
#nullable enable  
            public string[]? Tags { get; set; }
#nullable disable
            public string Description { get; set; }
    }
}