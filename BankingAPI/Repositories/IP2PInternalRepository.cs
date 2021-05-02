using BankingAPI.Models;

namespace BankingAPI.Repositories
{
    public interface IP2PInternalRepository
    {
        public P2PInternal Get(long partnerId);
    }
}