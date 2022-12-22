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
    internal class IngredientService
    {
        public Ingredient GetById(int Id)
        {
            Ingredient ingredient;
            using (AppDbContext appDbContext = new AppDbContext())
            {
                ingredient = appDbContext.Ingredients.Include(i=>i.Pizza).FirstOrDefault(i => i.Id == Id);
                if(ingredient == null)
                {
                    Console.WriteLine("Bele Id yoxdu");
                }
            }
            return ingredient;
        }
        public void CreateIngredient(string name, double price, int pizzaId)
        {
            Ingredient ingredient = new Ingredient()
            {
                Name = name,
                PizzaId = pizzaId
            };
            using (AppDbContext dbcontext = new AppDbContext())
            {
                dbcontext.Ingredients.Add(ingredient);
                dbcontext.SaveChanges();
                Console.WriteLine("Ingredient Added");
            }
        }
        public void Delete(int id)
        {
            Ingredient ingredient;
            using (AppDbContext appDbContext = new AppDbContext())
            {
                ingredient = appDbContext.Ingredients.FirstOrDefault(s => s.Id == id);
                if (!(ingredient == null))
                {
                    appDbContext.Ingredients.Remove(ingredient);
                    appDbContext.SaveChanges();
                    Console.WriteLine(ingredient.Name + " adli ingridient ugurla silindi");
                }
                else
                {
                    Console.WriteLine("Bele idli ingridient yoxdu.");
                }
            }
        }
        public List<Ingredient> GetAll()
        {
            List<Ingredient> ingredients;
            using (AppDbContext dbcontext = new AppDbContext())
            {
                ingredients = dbcontext.Ingredients.Include(i=>i.Pizza).ToList();
            }
            return ingredients;
        }
        public void Update(Ingredient ingredient)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (ingredient != null)
                {
                    context.Ingredients.Update(ingredient);
                    context.SaveChanges();
                    Console.WriteLine("Ugurla deyishildi");
                }
                else
                {
                    context.Ingredients.Add(ingredient);
                }
            }
        }
    }
}
