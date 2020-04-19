using System.Threading.Tasks;
using Foaas.Client.Responses;

namespace Foaas.Client
{
    public interface IFoaasClient
    {
        Task<FoaasResponse> Asshole(string from);
        Task<FoaasResponse> Version();
        Task<FoaasOperationsResponse> Operations();
    }
}