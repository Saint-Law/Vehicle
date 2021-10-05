using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Data.Interface;
using Vehicle.Data.Models;

namespace Vehicle.Data.Repository
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly VehicleMgrContext _context;
        public PurchaseRepository(VehicleMgrContext context)
        {
            _context = context;
        }
        public async Task<bool> Create(Purchase entity)
        {
            await _context.Purchases.AnyAsync();
            return await Save();
        }

        public async Task<bool> Delete(Purchase entity)
        {
            _context.Purchases.Remove(entity);
            return await Save();
        }

        public async Task<ICollection<Purchase>> FindAll()
        {
            var record = await _context.Purchases.ToListAsync();
            return record;
        }

        public async Task<Purchase> FindById(int id)
        {
            var record = await _context.Purchases.FindAsync(id);
            return record;
        }

        public async Task<Purchase> GetFirstOrDefault(Expression<Func<Purchase, bool>> predicate)
        {
            return await _context.Purchases.FirstOrDefaultAsync(predicate);
        }

        public async Task<Purchase> GetLastOrDefault(Expression<Func<Purchase, bool>> predicate)
        {
            return await _context.Purchases.LastOrDefaultAsync(predicate);
        }

        public async Task<Purchase> GetSingleOrDefault(Expression<Func<Purchase, bool>> predicate)
        {
            return await _context.Purchases.SingleOrDefaultAsync(predicate);
        }

        public async Task<bool> isExist(int id)
        {
            var exist = await _context.Purchases.AnyAsync(x => x.Id == id);
            return exist;
        }

        public async Task<bool> Save()
        {
            var changes = await _context.SaveChangesAsync();
            return changes > 0;
        }

        public async Task<bool> Update(Purchase entity)
        {
            _context.Purchases.Update(entity);
            return await Save();
        }
    }
}
