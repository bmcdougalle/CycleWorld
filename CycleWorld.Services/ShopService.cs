﻿using CycleShops.Data;
using CycleShops.Models;
using CycleWorld.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleShops.Services
{
    public class ShopService
    {
        private readonly Guid _userId;

        public ShopService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateShop(ShopCreate model)
        {
            var entity =
                new Shop()
                {
                    OwnerId = _userId,
                    Title = model.Title,
                    Content = model.Content,
                    CreatedUtc = DateTimeOffset.Now,
                    PartId = model.PartId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Shops.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ShopListItem> GetShop()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Shops
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new ShopListItem
                                {
                                    ShopId = e.ShopId,
                                    Title = e.Title,
                                    CreatedUtc = e.CreatedUtc
                                }
                        );

                return query.ToArray();
            }
        }
        public ShopDetail GetShopById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Shops
                        .Single(e => e.ShopId == id && e.OwnerId == _userId);
                return
                    new ShopDetail
                    {
                        ShopId = entity.ShopId,
                        Title = entity.Title,
                        Content = entity.Content,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateShop(ShopEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Shop entity =
                    ctx
                        .Shops
                        .Single(e => e.ShopId == model.ShopId && e.OwnerId == _userId);

                entity.Title = model.Title;
                entity.Content = model.Content;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteShop(int shopId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Shops
                        .Single(e => e.ShopId == shopId && e.OwnerId == _userId);

                ctx.Shops.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
