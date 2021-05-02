using BankingAPI.Models;

namespace BankingAPI.Services
{
    public interface IP2PInternalService
    {
        public P2PInternal Get(long partnerId);
    }
}