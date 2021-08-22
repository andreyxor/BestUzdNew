using BestUzdNew.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BestUzdNew.Logic
{
    public interface IDiscountService
    {
        Task CreateDiscountServiceAsync(ServiceDiscount discountService);
        Task<ICollection<ServiceDiscount>> GetDiscountServiceAsync();
    }
}
