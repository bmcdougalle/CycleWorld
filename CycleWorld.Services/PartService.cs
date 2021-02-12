using CycleParts.Data;
using CycleWorld.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleParts.Models
{
    public class PartService
    {
        private readonly Guid _userId;

        public PartService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreatePart(PartCreate model)
        {
            var entity =
                new Part()
                {
                    Title = model.Title,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Parts.Add(entity);
                return ctx.SaveChanges() > 0;
            }
        }
        public IEnumerable<PartListItem> GetParts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Parts
                        //.Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new PartListItem
                                {
                                    PartId = e.PartId,
                                    Title = e.Title,
                                }
                        );

                return query.ToArray();
            }
        }
        public PartDetail GetPartById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Parts
                        .Single(e => e.PartId == id && e.OwnerId == _userId);
                return
                    new PartDetail
                    {
                        PartId = entity.PartId,
                        Title = entity.Title,
                    };
            }
        }
        public bool UpdatePart(PartEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Part entity =
                    ctx
                        .Parts
                        .Single(e => e.PartId == model.PartId && e.OwnerId == _userId);

                entity.Title = model.Title;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePart(int partId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Parts
                        .Single(e => e.PartId == partId && e.OwnerId == _userId);

                ctx.Parts.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
