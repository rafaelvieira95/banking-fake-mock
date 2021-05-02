using BankingAPI.Models;
using BankingAPI.Repositories;

namespace BankingAPI.Services
{
    public class P2PInternalService: IP2PInternalService
    {
        private readonly IP2PInternalRepository _internalRepository;

        public P2PInternalService(IP2PInternalRepository internalRepository)
        {
            _internalRepository = internalRepository;
        }
        public P2PInternal Get(long partnerId)
        {
            return _internalRepository.Get(partnerId);
        }
    }
}