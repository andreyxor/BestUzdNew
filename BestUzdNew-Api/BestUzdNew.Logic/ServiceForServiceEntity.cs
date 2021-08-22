using BestUzdNew.DataAccess;
using BestUzdNew.DataAccess.RepositoryExtensions;
using BestUzdNew.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestUzdNew.Logic
{
    public class ServiceForServiceEntity : IServiceForServiceEntity
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public ServiceForServiceEntity(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task CreateServiceAsync(Service service, int serviceGroupId, Translation nameTranslation, Translation descriptionTranslation)
        {
            
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                
                var serviceGroup = await uow.GetRepository<ServiceGroup>().FindByIdAsync(serviceGroupId);
                service.ServiceGroupsToServices.Add(new ServiceGroupToService 
                {
                    ServiceGroup = serviceGroup,
                    Service = service
                });
                service.NameAlias = uow.GetRepository<Translation>().AddOrUpdateTranslation(nameTranslation);
                service.DescriptionAlias = uow.GetRepository<Translation>().AddOrUpdateTranslation(descriptionTranslation);
                uow.GetRepository<Service>().Create(service);

                await uow.SaveChangesAsync();
            }
        }

        public async Task<ICollection<Service>> GetServicesAsync()
        {
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                return await uow.GetRepository<Service>()
                             .Query
                             .Include(x => x.ServiceGroupsToServices)
                             .ToListAsync();
            }
        }
    }
}
