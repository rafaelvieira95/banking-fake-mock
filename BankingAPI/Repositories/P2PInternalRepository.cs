using System;
using System.Collections.Generic;
using System.Linq;
using BankingAPI.Models;

namespace BankingAPI.Repositories
{
    public class P2PInternalRepository: IP2PInternalRepository
    {
        public  P2PInternal Get(long partnerId)
        {
            IList<P2PInternal> p2PInternals = new List<P2PInternal>();
            
            p2PInternals.Add(new P2PInternal(){PartnerId = 12345, 
                BusinessUnitId = 1234567890,
                FromTaxNumber = "11111111111",
                FromBank = "2",
                FromBankBranch = "865",
                FromBankAccount = "22222",
                FromBankAccountDigit = "1",
                ToTaxNumber = "22222222222",
                ToBank = "2",
                ToBankBranch = "865",
                ToBankAccount = "11111",
                ToBankAccountDigit = "1",
                Value = 2000,
                RateValue = 10,
                TransferDate = new DateTime(2021,04,30),
                Identifier = "5AE8",
                Description = "Transfer for BRL 2.000,00",
                Tags = new []{""}
                
            });
            
            p2PInternals.Add(new P2PInternal()
            {
                PartnerId = 54321, 
                BusinessUnitId = 1234567890,
                FromTaxNumber = "22222222222",
                FromBank = "2",
                FromBankBranch = "865",
                FromBankAccount = "22222",
                FromBankAccountDigit = "1",
                ToBank = "2",
                ToTaxNumber = "11111111111",
                ToBankBranch = "865",
                ToBankAccount = "11111",
                ToBankAccountDigit = "1",
                Value = 9000,
                RateValue = 10,
                TransferDate = new DateTime(2021,05,01),
                Identifier = "5AEH",
                Description = "Transfer for BRL 900,00",
                Tags = new []{""}
            });

            return p2PInternals.FirstOrDefault(p => p.PartnerId == partnerId);

        }
        
    }
}