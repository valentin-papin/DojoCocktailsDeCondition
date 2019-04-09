using System.Collections.Generic;

namespace CocktailsDeCondition
{
    public class MakingCocktail
    {
        private enum IngredientType
        {
            Beer,
            Vodka,
            Tequila,
            Fruit,
            SodaWater,
            Gin
        }

        public string GetNameCocktail(List<string> ingredients)
        {
            var recipe = DetectIngredients(ingredients);
            if (recipe[IngredientType.Beer])
            {
                return GetNameCocktailWithBeer(recipe);
            }

            return recipe[IngredientType.Vodka] ? GetNameCocktailWithVodka(recipe) : Cocktails.Beer;
        }

        private string GetNameCocktailWithVodka(Dictionary<IngredientType, bool> recipe)
        {
            if (recipe[IngredientType.Tequila])
            {
                return GetNameCocktailWithVodkaAndTequila(recipe);
            }

            if (recipe[IngredientType.Fruit] && recipe[IngredientType.SodaWater])
            {
                return Cocktails.MarinesVodka;
            }

            return recipe[IngredientType.Gin] ? Cocktails.VodkaCoffins : Cocktails.Vodka;
        }

        private string GetNameCocktailWithVodkaAndTequila(Dictionary<IngredientType, bool> recipe)
        {
            if (recipe[IngredientType.Gin])
            {
                return recipe[IngredientType.Fruit] ? Cocktails.LongIsland : Cocktails.TGV;
            }

            return Cocktails.BlueShark;
        }

        private string GetNameCocktailWithBeer(Dictionary<IngredientType, bool> recipe)
        {
            if (recipe[IngredientType.SodaWater])
            {
                return recipe[IngredientType.Fruit] ? Cocktails.Monaco : Cocktails.Panache;
            }

            if (recipe[IngredientType.Vodka])
            {
                return recipe[IngredientType.Fruit] ? Cocktails.SkollFruitz : Cocktails.Skoll;
            }

            return recipe[IngredientType.Tequila] ? Cocktails.Desperados : Cocktails.Beer;
        }

        private static Dictionary<IngredientType, bool> DetectIngredients(List<string> ingredients)
        {
            var recipe = new Dictionary<IngredientType, bool>
            {
                {IngredientType.Beer, false},
                {IngredientType.Vodka, false},
                {IngredientType.Tequila, false},
                {IngredientType.Fruit, false},
                {IngredientType.SodaWater, false},
                {IngredientType.Gin, false}
            };

            foreach (var ingredient in ingredients)
            {
                if (ingredient == Ingredient.Beer)
                {
                    recipe[IngredientType.Beer] = true;
                    continue;
                }
                if (ingredient == Ingredient.Vodka)
                {
                    recipe[IngredientType.Vodka] = true;
                    continue;
                }
                if (ingredient == Ingredient.Tequila)
                {
                    recipe[IngredientType.Tequila] = true;
                    continue;
                }
                if (ingredient == Ingredient.Fruit)
                {
                    recipe[IngredientType.Fruit] = true;
                    continue;
                }
                if (ingredient == Ingredient.SodaWater)
                {
                    recipe[IngredientType.SodaWater] = true;
                    continue;
                }
                if (ingredient == Ingredient.Gin)
                {
                    recipe[IngredientType.Gin] = true;
                }
            }
            return recipe;
        }
    }
}