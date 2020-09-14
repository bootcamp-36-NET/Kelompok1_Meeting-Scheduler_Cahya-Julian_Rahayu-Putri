using API.Bases;
using API.Context;
using API.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class GeneralRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, BaseModel
        where TContext : MyContext
    {
        private MyContext _context;

        public GeneralRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<int> Create(TEntity entity)
        {
            entity.CreateDate = DateTimeOffset.Now;
            entity.isDelete = false;
            await _context.Set<TEntity>().AddAsync(entity); //input data o db
            var CreateItem = await _context.SaveChangesAsync(); //save changes in db
            return CreateItem;
        }

        public async Task<int> Delete(int Id)
        {
            var item = await GetById(Id);
            if (item == null)
            {
                return 0;
            }
            item.isDelete = true;
            item.DeleteDate = DateTimeOffset.Now;
            _context.Entry(item).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            var GetAll = await _context.Set<TEntity>().Where(s => s.isDelete == false).ToListAsync();
            if (!GetAll.Count().Equals(0))
            {
                return GetAll;
            }
            return null;
        }

        public async Task<TEntity> GetById(int Id)
        {
            var item = await _context.Set<TEntity>().FindAsync(Id);
            if (item == null)
            {
                return null;
            }
            return item;
        }

        public async Task<int> Update(TEntity entity)
        {
            entity.UpdateDate = DateTimeOffset.Now;
            _context.Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
