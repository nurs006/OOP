public class Product
{
    // Поля для хранения информации о продукте
    public string Name { get; private set; } // Название продукта
    public decimal Price { get; private set; } // Цена продукта
    public int Stock { get; private set; } // Количество продукта на складе

    // Конструктор, который принимает все параметры
    public Product(string name, decimal price, int stock)
    {
        Name = name; // Устанавливаем название продукта
        Price = price; // Устанавливаем цену продукта
        Stock = stock; // Устанавливаем количество продукта на складе
    }

    // Конструктор, который принимает только название, а цена и количество по умолчанию 0
    public Product(string name)
    {
        Name = name; // Устанавливаем название продукта
        Price = 0; // Цена по умолчанию 0
        Stock = 0; // Количество на складе по умолчанию 0
    }

    // Метод для обновления цены товара
    public void UpdatePrice(decimal newPrice)
    {
        Price = newPrice; // Устанавливаем новую цену
    }

    // Метод для пополнения запаса товара на складе
    public void Restock(int quantity)
    {
        Stock += quantity; // Увеличиваем количество на складе на переданное значение
    }

    // Метод для получения информации о продукте
    public string GetProductInfo()
    {
        return $"Name: {Name}, Price: {Price:C}, Stock: {Stock}"; // Возвращаем информацию о продукте
    }

    // Метод для продажи товара
    public void Sell(int quantity)
    {
        if (quantity <= Stock) // Проверяем, достаточно ли товара на складе
        {
            Stock -= quantity; // Уменьшаем количество на складе
            Console.WriteLine($"{quantity} units of {Name} sold.");
        }
        else
        {
            Console.WriteLine($"Not enough stock of {Name} to sell {quantity} units."); // Сообщение о нехватке товара
        }
    }
}

class Program
{
    static void Main()
    {
        // Создаем продукт с полными параметрами
        Product apple = new Product("Apple", 0.5m, 100);
        // Получаем информацию о продукте
        Console.WriteLine(apple.GetProductInfo());

        // Создаем продукт с только названием
        Product banana = new Product("Banana");
        // Обновляем цену банана
        banana.UpdatePrice(0.3m);
        // Получаем информацию о продукте
        Console.WriteLine(banana.GetProductInfo());

        // Пополняем запасы бананов
        banana.Restock(50);
        // Продаем несколько единиц бананов
        banana.Sell(10);
        // Получаем обновленную информацию
        Console.WriteLine(banana.GetProductInfo());
    }
}