using pizzamizzacrudmain.Models;
using pizzamizzacrudmain.Services;

namespace pizzamizzacrudmain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IngredientService ingredientservice = new IngredientService();
            PizzaService pizzaService = new PizzaService();
            SizeService sizeService = new SizeService();
            //CREATE PIZZA
            //pizzaService.CreatePizza("Margaritta");
            //pizzaService.CreatePizza("Pepperoni");
            //pizzaService.CreatePizza("Chichken");
            //READ PIZZA
            //foreach (var item in pizzaService.GetAll())
            //{
            //    Console.WriteLine(item.Id + ". " + item.Name);
            //}
            //GETBYID PIZZA
            //Pizza pizza = pizzaService.GetById(25);
            //Console.WriteLine(pizza.Id + ". " + pizza.Name);
            //REMOVE PIZZA
            //pizzaService.Delete(1);
            ////UPDATE Pizza
            //Pizza pizza = pizzaService.GetById(4);
            //pizza.Name = "Mexico";
            //pizzaService.Update(pizza);




            //Size size = new Size();
            //sizeService.CreateSize("small", 12.10d, 2);
            //sizeService.CreateSize("medium", 13.20d, 2);
            //sizeService.Delete(2);
            //foreach (var item in sizeService.GetAll())
            //{
            //Console.WriteLine(item.Id + ". " + item.Name + " " + item.Pizza.Name + " " + item.Price);
            //}
            //sizeService.CreateSize("Large", 21, 3);
            //sizeService.CreateSize("Small", 21, 5);
            //sizeService.CreateSize("Small", 15, 3);
            //sizeService.CreateSize("Medium", 21, 4);




            //Ingredient ingredient = new Ingredient();
            //ingredientservice.CreateIngredient("kolbasa", 21, 2);
            //foreach (var item in ingredientservice.GetAll())
            //{
            //    Console.WriteLine(item.Id + ". " + item.Name + " " + item.Pizza.Name);
            //}
            //ingredientservice.Delete(1);
        }
    }
}