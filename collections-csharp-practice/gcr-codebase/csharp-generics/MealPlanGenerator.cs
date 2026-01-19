using System;

// Interface
interface IMealPlan
{
    void MealDetails();
}

// Implementations
class VegetarianMeal : IMealPlan
{
    public void MealDetails()
    {
        Console.WriteLine("Vegetarian Meal Selected");
    }
}

class VeganMeal : IMealPlan
{
    public void MealDetails()
    {
        Console.WriteLine("Vegan Meal Selected");
    }
}

// Generic class with interface constraint
class Meal<T> where T : IMealPlan
{
    public void GenerateMeal(T meal)
    {
        meal.MealDetails();
    }
}

class MealPlanGenerator
{
    static void Main()
    {
        Meal<VegetarianMeal> meal = new Meal<VegetarianMeal>();
        meal.GenerateMeal(new VegetarianMeal());
    }
}
