using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Shouldly;

namespace CocktailsDeCondition.Test
{
    [TestFixture]
    public class MakingCocktailShould
    {
        private MakingCocktail makingCocktail;

        [SetUp]
        public void TestMethod1()
        {
            makingCocktail = new MakingCocktail();
        }

        [Test, TestCaseSource(nameof(CocktailLinkedName))]
        public void ShouldNameCocktail(CocktailName cocktailLinkedName)
        {
            var result = makingCocktail.GetNameCocktail(cocktailLinkedName.Ingredients);
            result.ShouldBe(cocktailLinkedName.NameCocktail);
        }

        private static IEnumerable<CocktailName> CocktailLinkedName()
        {
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Beer
                },
                NameCocktail = Cocktails.Beer
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Beer, Ingredient.Vodka
                },
                NameCocktail = Cocktails.Skoll
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Beer, Ingredient.Vodka, Ingredient.Fruit
                },
                NameCocktail = Cocktails.SkollFruitz
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Beer, Ingredient.Tequila
                },
                NameCocktail = Cocktails.Desperados
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Beer, Ingredient.Fruit, Ingredient.SodaWater
                },
                NameCocktail = Cocktails.Monaco
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Beer, Ingredient.SodaWater
                },
                NameCocktail = Cocktails.Panache
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Vodka, Ingredient.Tequila
                },
                NameCocktail = Cocktails.BlueShark
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Tequila, Ingredient.Vodka, Ingredient.Gin
                },
                NameCocktail = Cocktails.TGV
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Gin, Ingredient.Vodka
                },
                NameCocktail = Cocktails.VodkaCoffins
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Fruit, Ingredient.Vodka, Ingredient.SodaWater
                },
                NameCocktail = Cocktails.MarinesVodka
            };
            yield return new CocktailName
            {
                Ingredients = new List<string>
                {
                    Ingredient.Fruit, Ingredient.Vodka, Ingredient.Tequila, Ingredient.Gin
                },
                NameCocktail = Cocktails.LongIsland
            };
        }

        public class CocktailName
        {
            public List<string> Ingredients;
            public string NameCocktail;
        }
    }
}
