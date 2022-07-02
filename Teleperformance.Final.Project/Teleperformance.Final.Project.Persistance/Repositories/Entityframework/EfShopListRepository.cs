﻿using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Domain.ShopList;
using Teleperformance.Final.Project.Persistance.Contexs;

namespace Teleperformance.Final.Project.Persistance.Repositories.Entityframework
{
    public class EfShopListRepository : GenericRepository<ShopListEntity>, IShopListRepository
    {
        private readonly ShoppingListDbContext _dbContext;
        public EfShopListRepository(ShoppingListDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}