///*
//Create class Car 
//properties:
//string Model
//string Make 
//bool IsInStock -- есть ли в наличии
//decimal ListPrice -- базовая цена
//double Discount -- скидка
//decimal SalesPrice -- конечная цена

//перегрузка + (Car car1, Car car2)  :  складываем их ListPrice
//перегузка true (Car car): возвращаем значние IsInStock

//перегрузка + (Car car1, decimal value)  : к ListPrice прибавили value
//перегрузка * (Car car1, double value)  : берем ListPrice умножаем на value и пишем в SalesPrice

//перегрузка & (Car car1, Car car2): если оба в наличии

// */
 
//class Car
//{
//    public bool IsInStock { get; set; }
//    public decimal ListPrice { get; set; }









//    public static bool operator true(Car car)
//    {
//        return car.IsInStock;
//    }

//    public static bool operator false(Car car)
//    {
//        return !car.IsInStock;
//    }

//    public static bool operator &
//}