// Абстрактный класс Transport
abstract class Transport
{
    // Абстрактный метод для расчета времени поездки
    public abstract double CalculateTravelTime(double distance);
    
    // Абстрактный метод для получения информации о транспортном средстве
    public abstract string GetTransportInfo();
}

// Класс Car, наследует от Transport
class Car : Transport
{
    // Реализация метода CalculateTravelTime для автомобиля
    public override double CalculateTravelTime(double distance)
    {
        // Средняя скорость автомобиля — 80 км/ч
        double speed = 80;
        // Время поездки = расстояние / скорость
        return distance / speed;
    }
    
    // Реализация метода GetTransportInfo для автомобиля
    public override string GetTransportInfo()
    {
        // Возвращаем информацию о типе транспортного средства
        return "Car (Average speed: 80 km/h)";
    }
}

// Класс Plane, наследует от Transport
class Plane : Transport
{
    // Реализация метода CalculateTravelTime для самолета
    public override double CalculateTravelTime(double distance)
    {
        // Средняя скорость самолета — 600 км/ч
        double speed = 600;
        // Время поездки = расстояние / скорость
        return distance / speed;
    }
    
    // Реализация метода GetTransportInfo для самолета
    public override string GetTransportInfo()
    {
        // Возвращаем информацию о типе транспортного средства
        return "Plane (Average speed: 600 km/h)";
    }
}

// Класс Program для выполнения программы
class Program
{
    static void Main(string[] args)
    {
        // Задаем расстояние, например, 400 км
        double distance = 400;

        // Создаем объект автомобиля
        Transport car = new Car();
        // Выводим информацию о транспортном средстве и расчеты времени поездки
        Console.WriteLine(car.GetTransportInfo());
        Console.WriteLine($"Travel time for {distance} km: {car.CalculateTravelTime(distance)} hours\n");

        // Создаем объект самолета
        Transport plane = new Plane();
        // Выводим информацию о транспортном средстве и расчеты времени поездки
        Console.WriteLine(plane.GetTransportInfo());
        Console.WriteLine($"Travel time for {distance} km: {plane.CalculateTravelTime(distance)} hours");
    }
}