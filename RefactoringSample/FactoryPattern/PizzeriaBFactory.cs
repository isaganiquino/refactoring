using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PizzeriaBFactory : PizzeriaFactory
    {
        private Ingredients _ingredients;
        private Pizza _pizza;

        public PizzeriaBFactory()
        {
            _ingredients = new Ingredients()
            {
                Cheese = "Parmesan",
                Clam = "Fresh Clam",
                Dough = "Deep Dish",
                Sauce = "Plum Tomato",
                Veggies = "Cucumber, Onions, Peppers"
            };
        }

        public override void Order(string variety)
        {
            _pizza = new Pizza()
            {
                Variety = variety,
                Dough = _ingredients.Dough,
                Sauce = _ingredients.Sauce,
                Cheese = (variety == Variety.Cheese || variety == Variety.Clam) ? _ingredients.Cheese : null,
                Clam = (variety == Variety.Clam) ? _ingredients.Clam : null,
                Veggies = (variety == Variety.Cheese || variety == Variety.Veggies) ? _ingredients.Veggies : null
            };
        }

        public override void Prepare()
        {
            Console.WriteLine("\nPreparing Pizzeria B Style {0} Using", _pizza.Variety);
            Console.WriteLine
            (
                String.Format
                (
                    "Dough: {0}, {1}{2}Sauce: {3}, {4}",
                    _pizza.Dough,
                    !string.IsNullOrEmpty(_pizza.Cheese) ? "Cheese: " + _pizza.Cheese + ", " : string.Empty,
                    !string.IsNullOrEmpty(_pizza.Clam) ? "Clam: " + _pizza.Clam + ", " : string.Empty,
                    _pizza.Sauce,
                    !string.IsNullOrEmpty(_pizza.Veggies) ? "Veggies: " + _pizza.Veggies : string.Empty
                )
            );
        }

        public override void Bake()
        {
            Console.WriteLine("\nBaking at 135 degree Celsius for 25 minutes");
        }

        public override void Cut()
        {
            Console.WriteLine("\nCutting into diagonal pieces");
        }

        public override void Box()
        {
            Console.WriteLine("\nPutting pizza in Green coloured box");
        }
    }
}
