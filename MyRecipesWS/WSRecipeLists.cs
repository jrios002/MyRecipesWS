using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MyRecipesWS
{
    public class WSRecipeLists
    {
        public List<WSRecipe> recipeList;
        public Image recipeImage;

        // Default Constructor
        public WSRecipeLists()
        {
        }

        // Constructor with only a list of recipes given
        public WSRecipeLists(List<WSRecipe> recipeList)
        {
            this.recipeList = recipeList;
            sortRecipeList(recipeList);

            foreach (WSRecipe r in recipeList)
            {
                recipeImage = assignImage(r.RecipeName);
            }
        }

        // Getters and Setters

        public List<WSRecipe> RecipeListValues
        {
            get { return recipeList; }
            set { this.recipeList = value; }
        }

        public Image ListImage
        {
            get { return recipeImage; }
            set { this.recipeImage = value; }
        }

        // Retrieve the name of a recipe at a certain location
        public String getRecipeNames(int location)
        {
            return recipeList[location].RecipeName;
        }

        // Get the total count of recipes in the recipe list
        public int getRecipeListCount()
        {
            return recipeList.Count;
        }

        // Sort the list of recipes names in alphabetical order
        public List<WSRecipe> sortRecipeList(List<WSRecipe> recipeList)
        {
            recipeList.Sort((x, y) => x.RecipeName.CompareTo(y.RecipeName));
            return recipeList;
        }

        // Method to assign image to recipe object
        public Image assignImage(string recipeName)
        {
            String nameLowerCase = "";

            // Change all string characters to lower case for switch
            nameLowerCase = recipeName.ToLower();

            switch (nameLowerCase)
            {
                default:
                    break;
            }

            return recipeImage;
        }

        public List<WSRecipe> loadPreloadedRecipes()
        {
            ImageConverter imgConverter = new ImageConverter();
            byte[] bytes = (byte[])imgConverter.ConvertTo(Properties.Resources.blt, typeof(byte[]));
            int size = bytes.Length;

            List<WSRecipe> list = new List<WSRecipe>();
            list.Add(new WSRecipe("BLT", "4 slices bacon\n\n2 leaves lettuce\n\n" +
                    "2 slices tomato\n\n2 slices bread, toasted\n\n1tablespoon mayonnaise", "1. Cook " +
                    "the bacon in a large, deep skillet over medium-high heat until evenly browned," +
                    "about 10 minutes.Drain the bacon slices on a paper towel - lined plate.\n\n" +
                    "2.Arrange the cooked bacon, lettuce, and tomato slices on one slice of bread. " +
                    "Spread one side of remaining bread slice with the mayonnaise.Bring the two " +
                    "pieces together to make a sandwich.", size, bytes));

            bytes = (byte[])imgConverter.ConvertTo(Properties.Resources.chickenpotpie, typeof(byte[]));
            size = bytes.Length;

            list.Add(new WSRecipe("Chicken Pot Pie", "1/3 cup butter\n\n1/3 cup chopped " +
                "onion\n\n1/3 cup all-purpose flour\n\n1/2 teaspoon salt\n\n1 / 4 teaspoon ground " +
                "black pepper\n\n1 3 / 4 cups chicken broth\n\n2 / 3 cup milk\n\n2 cups chopped " +
                "cooked chicken\n\n1(14.5 ounce) can peas and carrots\n\n1/2(15 ounce) can whole " +
                "new potatoes, drained\n\n1(15 ounce) package prepared double - crust pie pastry",
                "1. Preheat oven to 425 degrees F (220 degrees C).\n\n2. Melt butter in a large " +
                "skillet over medium heat.Cook and stir onion, flour, salt, and pepper in melted " +
                "butter until the onion is translucent, about 5 minutes.\n\n3.Remove skillet from " +
                "heat and pour chicken broth and milk into the skillet; bring the mixture to a " +
                "boil and cook to thicken slightly, about 1 minute.\n\n4.Remove skillet from heat " +
                "and stir chicken, peas and carrots, and potatoes into the broth mixture" +
                ".\n\n5.Press one pie pastry into the bottom of a deep-dish pie pan. Pour the " +
                "broth mixture into the pie pastry. Top with remaining pastry and press edges " +
                "together to form a seal. Cut several slits into the top pastry. Place pie plate " +
                "on a baking sheet.\n\n6.Bake in preheated oven until the crust is golden brown, " +
                "about 30 minutes.Let pie cool and filling thicken at room temperature for 15 to " +
                "20 minutes before cutting.", size, bytes));

            bytes = (byte[])imgConverter.ConvertTo(Properties.Resources.lasagnaalfredo, typeof(byte[]));
            size = bytes.Length;

            list.Add(new WSRecipe("Lasagna Alfredo", "1 (16 ounce) package lasagna " +
                "noodles\n\n1 (10 ounce) package frozen chopped spinach\n\n3 cooked, boneless " +
                "chicken breast halves, diced\n\n2(16 ounce) jars Alfredo - style pasta " +
                "sauce\n\n4 cups shredded mozzarella cheese\n\n2 pints ricotta cheese\n\nsalt and " +
                "ground black pepper to taste", "1. Preheat oven to 350 degrees F (175 degrees C)" +
                ".\n\n2. Bring a large pot of lightly salted water to a boil.Add pasta and cook " +
                "for 8 to 10 minutes or until al dente; drain. Cook spinach according to package " +
                "directions; drain.\n\n3.In a medium bowl, combine chicken and one jar of Alfredo " +
                "sauce, stir together. In a separate bowl, combine ricotta and drained, cooked " +
                "spinach, and stir.\n\n4.In a 9 x 13 baking dish, place one layer of lasagna " +
                "noodles, edges overlapping. Pour chicken and Alfredo sauce mixture over noodle " +
                "layer and spread evenly. Sprinkle 1 cup of shredded mozzarella over chicken " +
                "mixture. Top with another layer of noodles. Spread spinach mixture evenly over " +
                "noodles. Pour 1 / 2 of remaining jar of Alfredo sauce over spinach mixture, " +
                "spread evenly. Sprinkle another cup of mozzarella over sauce, lay on the final " +
                "noodle layer and top with remaining 1 / 2 jar of Alfredo sauce, 2 cups of " +
                "mozzarella, and salt and pepper to taste.\n\n5.Bake 50 to 60 minutes, until top " +
                "is brown and bubbly.", size, bytes));

            bytes = (byte[])imgConverter.ConvertTo(Properties.Resources.caesarsalad, typeof(byte[]));
            size = bytes.Length;

            list.Add(new WSRecipe("Caesar Salad", "1 head romaine lettuce\n\n3/4 cup " +
                "extra virgin olive oil\n\n3 tablespoons red wine vinegar\n\n1 teaspoon " +
                "Worcestershire sauce\n\n1 / 2 teaspoon salt\n\n1 / 4 tablespoon ground " +
                "mustard\n\n1 clove crushed garlic\n\n1 egg\n\n1 lemon, juiced\n\nfreshly " +
                "ground black pepper\n\n1 / 4 cup grated Parmesan cheese\n\n1 1 / 2 cups garlic " +
                "croutons\n\n1(2 ounce) can anchovy filets", "1. Clean lettuce thoroughly and " +
                "wrap in paper towels to absorb moisture. Refrigerate until crisp, at least 1 " +
                "hour or more.\n\n2.In a bowl or jar combine oil, vinegar, Worcestershire " +
                "sauce, salt, mustard, garlic and lemon juice.Whisk until well blended.\n\n" +
                "3.Coddle egg by heating 3 cups of water to boiling.Drop in egg(still in shell)" +
                " and let stand for 1 minute.Remove egg from water and let cool.Once cooled " +
                "crack open and whisk egg into dressing.Whisk until thoroughly blended.\n\n" +
                "4.Mash desired amount of anchovies and whisk them into the dressing.If desired " +
                "set aside a few for garnish.\n\n5.To assemble, place torn lettuce leaves in " +
                "a large bowl.Pour dressing over the top and toss lightly.Add the grated cheese, " +
                "garlic croutons and freshly ground pepper, toss. Serve immediately!", size, bytes));

            bytes = (byte[])imgConverter.ConvertTo(Properties.Resources.cheeseburger, typeof(byte[]));
            size = bytes.Length;

            list.Add(new WSRecipe("CheeseBurger", "2 pounds ground beef sirloin\n\n1/2 " +
                "onion, grated\n\n1 tablespoon grill seasoning\n\n1 tablespoon liquid smoke " +
                "flavoring\n\n2 tablespoons Worcestershire sauce\n\n2 tablespoons minced " +
                "garlic\n\n1 tablespoon adobo sauce from canned chipotle peppers\n\n1 chipotle " +
                "chile in adobo sauce, chopped\n\nsalt and pepper to taste\n\n6 (1 ounce)slices " +
                "sharp Cheddar cheese(optional)\n\n6 hamburger buns", "1. Preheat an outdoor grill" +
                "for medium-high heat.\n\n2. Combine ground sirloin, onion, grill seasoning, " +
                "liquid smoke, Worcestershire sauce, garlic, adobo sauce, and chipotle pepper in " +
                "a large bowl.Form the mixture into 6 patties.Season with salt and pepper.\n\n" +
                "3.Place burgers on preheated grill and cook until no longer pink in the center" +
                ".\n\n4.Place a slice of Cheddar cheese on top of each burger one minute before " +
                "they are ready.\n\n5.Place burgers on buns to serve.", size, bytes));

            bytes = (byte[])imgConverter.ConvertTo(Properties.Resources.chickenparm, typeof(byte[]));
            size = bytes.Length;

            list.Add(new WSRecipe("Chicken Parm", "1 egg, beaten\n\n2 ounces dry bread " +
                "crumbs\n\n2 skinless, boneless chicken breast halves\n\n3 / 4(16 ounce) jar " +
                "spaghetti sauce\n\n2 ounces shredded mozzarella cheese\n\n1 / 4 cup grated " +
                "Parmesan cheese", "1. Preheat oven to 350 degrees F (175 degrees C). Lightly " +
                "grease a medium baking sheet.\n\n2.Pour egg into a small shallow bowl.Place " +
                "bread crumbs in a separate shallow bowl.Dip chicken into egg, then into the " +
                "bread crumbs.Place coated chicken on the prepared baking sheet and bake in the " +
                "preheated oven for 40 minutes, or until no longer pink and juices run clear.\n\n" +
                "3.Pour 1 / 2 of the spaghetti sauce into a 7x11 inch baking dish.Place chicken " +
                "over sauce, and cover with remaining sauce.Sprinkle mozzarella and Parmesan " +
                "cheeses on top and return to the preheated oven for 20 minutes.", size, bytes));

            bytes = (byte[])imgConverter.ConvertTo(Properties.Resources.Enchiladas, typeof(byte[]));
            size = bytes.Length;

            list.Add(new WSRecipe("Enchiladas", "Sauce:\n\n2 tablespoons canola oil\n" +
                "2 tablespoons all-purpose flour\nOne 28-ounce can enchilada or Mexican red " +
                "sauce\n2 cups chicken broth\n1/2 teaspoon salt\n1/2 teaspoon black pepper\n" +
                "Meat:\n\n1 pound ground beef\n1 medium onion, finely chopped\n1/2 teaspoon " +
                "salt\nThe Rest:\n\nCanola oil, for frying\n10 to 14 corn tortillas\nTwo 4-ounce " +
                "cans diced green chilies\n1 cup chopped green onions\n1/2 cup chopped black " +
                "olives\n3 cups grated sharp Cheddar cheese\nCilantro, for garnish", "For the " +
                "sauce:\n\nIn a saucepan over medium-low heat, combine the canola oil and flour. " +
                "Whisk together and allow to bubble for 1 minute. Pour in the red sauce, chicken " +
                "broth, salt and pepper. Bring to a boil. Reduce the heat and simmer while you " +
                "prepare the other ingredients.\n\nFor the meat:\n\nWhile the sauce is simmering, " +
                "brown the ground beef with the onions in a large skillet over medium-high heat. " +
                "Drain the fat, add the salt and stir to combine. Turn off the heat and set aside." +
                "\n\nFor the rest:\n\nIn a small skillet over medium heat, heat some canola " +
                "oil. Lightly fry the tortillas just until soft. Do not crisp. Drain on a paper " +
                "towel-lined plate. Repeat until all the tortillas have been fried.\nPreheat the " +
                "oven to 350 degrees F.\nSpread 1/2 cup of the sauce in the bottom of a 9- by " +
                "13-inch baking dish. Next, one at a time, dip each tortilla into the sauce. " +
                "Set the sauce-soaked tortilla on a plate. Place on some of the meat mixture, " +
                "chilies, green onions and black olives. Top with a generous portion of grated " +
                "Cheddar. Roll up the tortilla to contain the filling inside.\nPlace the tortilla " +
                "seam side down in the baking dish. Repeat with the rest of the tortillas and pour " +
                "the remaining sauce over the top. End with a generous sprinkling of cheese and " +
                "any other bits of chiles, green onions or olives you have left over from the " +
                "filling.\nBake the enchiladas for 20 minutes, or until bubbly. Sprinkle chopped " +
                "cilantro over the top and serve.\n", size, bytes));

            return list;
        }
    }
}