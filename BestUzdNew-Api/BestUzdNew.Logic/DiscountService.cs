using BestUzdNew.DataAccess;
using BestUzdNew.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestUzdNew.Logic
{
    class DiscountService : IDiscountService
    {

        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public DiscountService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task CreateDiscountServiceAsync(ServiceDiscount discountService)
        {
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                uow.GetRepository<ServiceDiscount>().Create(discountService);
                await uow.SaveChangesAsync();
            }
        }

        public async Task<ICollection<ServiceDiscount>> GetDiscountServiceAsync()
        {
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                return await uow.GetRepository<ServiceDiscount>()
                             .Query
                             .ToListAsync();
            }
        }
    }
}
