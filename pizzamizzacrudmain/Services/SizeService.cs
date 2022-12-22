using Microsoft.EntityFrameworkCore;
using pizzamizzacrudmain.DAL;
using pizzamizzacrudmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzamizzacrudmain.Services
{
    internal class SizeService
    {
        public Size GetById(int Id)
        {
            Size size;
            using (AppDbContext appDbContext = new AppDbContext())
            {
                size = appDbContext.Sizes.Include(s => s.Pizza).FirstOrDefault(s => s.Id == Id);
                if(size==null)
                {
                    Console.WriteLine("Bele id yoxdu");
                }
            }
            return size;
        }
        public void CreateSize(string name, double price, int pizzaId)
        {
            Size size = new Size
            {
                Name = name,
                Price = price,
                PizzaId = pizzaId
            };
            using (AppDbContext dbcontext = new AppDbContext())
            {
                dbcontext.Sizes.Add(size);
                dbcontext.SaveChanges();
                Console.WriteLine("Size Added");
            }
        }
        public List<Size> GetAll()
        {
            List<Size> sizeList;
            using (AppDbContext dbcontext = new AppDbContext())
            {
                sizeList = dbcontext.Sizes.Include(s=>s.Pizza).ToList();
            }
            return sizeList;
        }
        public void Delete(int id)
        {
            Size size;
            using (AppDbContext appDbContext = new AppDbContext())
            {
                size = appDbContext.Sizes.FirstOrDefault(s => s.Id == id);
                if (!(size == null))
                {
                    appDbContext.Sizes.Remove(size);
                    appDbContext.SaveChanges();
                    Console.WriteLine(size.Name + " adli size ugurla silindi");
                }
                else
                {
                    Console.WriteLine("Bele idli size yoxdu.");
                }
            }
        }
        public void Update(Size size)
        {
            Size sizee;
            using (AppDbContext context = new AppDbContext())
            {
                if (size != null)
                {
                    context.Sizes.Update(size);
                    context.SaveChanges();
                    Console.WriteLine("Ugurla deyishildi");
                }
                else
                {
                    context.Sizes.Add(size);
                }
            }
        }
    }
}
