using pizzamizzacrudmain.DAL;
using pizzamizzacrudmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzamizzacrudmain.Services
{
    internal class PizzaService
    {
        public Pizza GetById(int Id)
        {
            Pizza pizza;
            using (AppDbContext appDbContext = new AppDbContext())
            {
                pizza = appDbContext.Pizzas.FirstOrDefault(p => p.Id == Id);
                if(pizza == null)
                {
                    Console.WriteLine("Bele idli pizza yoxdu");
                }
            }
            return pizza;
        }
        public void CreatePizza(string name)
        {
            Pizza pizza = new Pizza
            {
                Name = name
            };
            using (AppDbContext dbcontext = new AppDbContext())
            {
                dbcontext.Pizzas.Add(pizza);
                dbcontext.SaveChanges();
                Console.WriteLine("Pizza Added");
            }
        }
        public List<Pizza> GetAll()
        {
            List<Pizza> pizzaList;
            using (AppDbContext dbcontext = new AppDbContext())
            {
                pizzaList = dbcontext.Pizzas.ToList();
            }
            return pizzaList;
        }
        public void Delete(int id)
        {
            Pizza pizza;
            using (AppDbContext appDbContext = new AppDbContext())
            {
                pizza = appDbContext.Pizzas.FirstOrDefault(p => p.Id == id);
                if (!(pizza == null))
                {
                    appDbContext.Pizzas.Remove(pizza);
                    appDbContext.SaveChanges();
                    Console.WriteLine(pizza.Name + " adli pizza ugurla silindi");
                }
                else
                {
                    Console.WriteLine("Bele idli pizza yoxdu.");
                }
            }
        }
        public void Update(Pizza pizza)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (pizza != null)
                {
                    context.Pizzas.Update(pizza);
                    context.SaveChanges();
                    Console.WriteLine("Ugurla deyishildi");
                }
                else
                {
                    context.Pizzas.Add(pizza);
                }
            }
        }
    }
}
