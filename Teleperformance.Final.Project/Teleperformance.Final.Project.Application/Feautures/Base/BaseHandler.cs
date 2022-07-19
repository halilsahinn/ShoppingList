using AutoMapper;
using Teleperformance.Final.Project.Application.Contracts.Cache;
using Teleperformance.Final.Project.Application.Contracts.RabbitMq;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;

namespace Teleperformance.Final.Project.Application.Feautures.Base
{
    public abstract class BaseHandler
    {
        public readonly IUnitOfWork _unitOfWork;

        public readonly IMapper _mapper;
         
        public readonly IRabbitMqService _rabbitmqService;

        public readonly IMemoryCacheService _memoryCache;

        protected BaseHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        protected BaseHandler(IUnitOfWork unitOfWork, IMapper mapper, IMemoryCacheService memoryCache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }
        protected BaseHandler(IUnitOfWork unitOfWork, IMapper mapper, IRabbitMqService rabbitmqService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _rabbitmqService = rabbitmqService;
        }
    }
}
