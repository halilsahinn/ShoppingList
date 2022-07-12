using AutoMapper;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;

namespace Teleperformance.Final.Project.Application.Feautures.Base
{
    public abstract class BaseHandler
    {
        public readonly IUnitOfWork _unitOfWork;

        public readonly IMapper _mapper;

        protected BaseHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
