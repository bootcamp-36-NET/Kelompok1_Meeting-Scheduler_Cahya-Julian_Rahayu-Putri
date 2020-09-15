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

        public async Task<string> Create(TEntity entity)
        {
            entity.CreateDate = DateTimeOffset.Now;
            entity.isDelete = false;
            await _context.Set<TEntity>().AddAsync(entity); //input data o db
            var CreateItem = await _context.SaveChangesAsync(); //save changes in db
            return CreateItem.ToString();
        }

        public async Task<string> Delete(string Id)
        {
            var item = await GetById(Id);
            if (item == null)
            {
                return null;
            }
            item.isDelete = true;
            item.DeleteDate = DateTimeOffset.Now;
            _context.Entry(item).State = EntityState.Modified;
            var delete = await _context.SaveChangesAsync();
            return delete.ToString();
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

        public async Task<TEntity> GetById(string Id)
        {
            var item = await _context.Set<TEntity>().FindAsync(Id);
            if (item == null)
            {
                return null;
            }
            return item;
        }

        public async Task<string> Update(TEntity entity)
        {
            entity.UpdateDate = DateTimeOffset.Now;
            _context.Entry(entity).State = EntityState.Modified;
            var edit = await _context.SaveChangesAsync();
            return edit.ToString();
        }
    }
}
