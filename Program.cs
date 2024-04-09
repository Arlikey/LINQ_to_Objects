

namespace LINQ_to_Objects
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateArray(20);

            Array.ForEach(array, x => { Console.Write(x + " "); });

            Console.WriteLine();

            Console.WriteLine(array.All(e => e % 2 == 0));
            Console.WriteLine(array.All(e => e > 10 && e < 45));
            Console.WriteLine(array.Any(e => e < 0));
            Console.WriteLine(array.Any(e => e % 2 != 0 && e < 0));
            Console.WriteLine(array.Contains(7));
            Console.WriteLine(array.FirstOrDefault(e => e > 723));
            Console.WriteLine(array.LastOrDefault(e => e < 0));
        }

        public static int[] CreateArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(-100, 101);
            }
            return array;
        }
    }*/

    /*public class AdditionalTask2
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                string[] names = { "Banana", "Orange", "Strawberry", "Pineapple", "Watermelon", "Grapes", "Peach", "Mango", "Kiwi", "Pear" };
                string randomName = names[random.Next(names.Length)];

                decimal randomPrice = (decimal)random.NextDouble() * (10 - 0.01m) + 0.01m;

                int randomCount = random.Next(1, 100);

                products.Add(new Product { Name = randomName, Price = Math.Round(randomPrice, 2), Count = randomCount });
            }
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nОТСОРТИРОВАННЫЙ ПО УБЫВАНИЮ ПЕРВЫЕ 10 ЭЛЕМЕНТОВ\n");

            List<Product> orderedList = products.OrderByDescending(product => product.Price).Take(10).ToList();

            foreach (Product product in orderedList)
            {
                Console.WriteLine(product);
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Count { get; set; }
            public override string ToString()
            {
                return $"Name - {Name}, Price - {Price}, Count - {Count}";
            }
        }
    }*/

    /*public class AdditionalTask3
    {
        static void Main(string[] args)
        {
            Book[] books =
            [
                new Book { Title = "Гамлет", Author = "Уильям Шекспир", Year = 1600, Genre = "Трагедия", CountOfPages = 123 },
                new Book { Title = "Ромео и Джульетта", Author = "Уильям Шекспир", Year = 1597, Genre = "Трагедия", CountOfPages = 522  },
                new Book { Title = "Макбет", Author = "Уильям Шекспир", Year = 1606, Genre = "Ужасы", CountOfPages = 234 },
                new Book { Title = "Дон Жуан", Author = "Лоренс Стерн", Year = 1716, Genre = "Сатира", CountOfPages = 98 },
                new Book { Title = "Гордость и предубеждение", Author = "Джейн Остин", Year = 1813, Genre = "Роман", CountOfPages = 39 },
                new Book { Title = "Одиссея", Author = "Гомер", Year = -800, Genre = "Эпос", CountOfPages = 932 },
                new Book { Title = "Гулливер в стране лилипутов", Author = "Джонатан Свифт", Year = 1726, Genre = "Сатира", CountOfPages = 372 },
                new Book { Title = "1984", Author = "Джордж Оруэлл", Year = 1949, Genre = "Фантастика", CountOfPages = 312 },
                new Book { Title = "Улисс", Author = "Джеймс Джойс", Year = 1922, Genre = "Современная проза", CountOfPages = 481 },
                new Book { Title = "Марк Муса. Лекции по итальянской литературе", Author = "Марк Муса", Year = 1993, Genre = "Исторический", CountOfPages = 937 },
                new Book { Title = "Анализ чувств", Author = "Дэвид Хьюм", Year = 1739, Genre = "Философия", CountOfPages = 1873 },
                new Book { Title = "Макферсон: Свободная воля", Author = "Байрон", Year = 1748, Genre = "Философия", CountOfPages = 375 },
                new Book { Title = "Земля до начала времен", Author = "Джон Ширли", Year = 2002, Genre = "Детская литература", CountOfPages = 539 }
            ];

            Console.WriteLine(books.All(book => book.CountOfPages > 100));
            Console.WriteLine(books.All(book => book.Genre == "Исторический" || book.Genre == "Сатира"));
            Console.WriteLine(books.Any(book => book.Genre == "Ужасы"));
            Console.WriteLine(books.Any(book => book.Author.Contains("Шекспир")));
            Console.WriteLine(books.Contains(new Book { Author = "Байрон"}));
            Console.WriteLine(books.FirstOrDefault(book => book.Year == 1993));
            Console.WriteLine(books.LastOrDefault(book => book.Year == 2002));
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public int CountOfPages { get; set; }
            public int Year { get; set; }

            public override bool Equals(object? obj)
            {
                return obj is Book book &&
                       Author == book.Author;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Author);
            }

            public override string ToString()
            {
                return $"Title - {Title}, Author - {Author}, Genre - {Genre}, Year - {Year}, Count of Pages -{CountOfPages}";
            }
        }
    }*/

    /*public class AdditionalTask4
    {
        static void Main(string[] args)
        {
            Cellphone[] cellphones = [
                new Cellphone { Name = "Nokia", Manufacturer = "Nokia", Price = 99.99m, Year = new DateOnly(2001, 01, 27) },
                new Cellphone { Name = "Samsung Galaxy S20", Manufacturer = "Samsung", Price = 999.99m, Year = new DateOnly(2020, 02, 11) },
                new Cellphone { Name = "iPhone 12", Manufacturer = "Apple", Price = 1099.99m, Year = new DateOnly(2020, 10, 23) },
                new Cellphone { Name = "Google Pixel 5", Manufacturer = "Google", Price = 699.99m, Year = new DateOnly(2020, 10, 15) },
                new Cellphone { Name = "OnePlus 9 Pro", Manufacturer = "OnePlus", Price = 899.99m, Year = new DateOnly(2021, 03, 26) },
                new Cellphone { Name = "Xiaomi Mi 11", Manufacturer = "Xiaomi", Price = 799.99m, Year = new DateOnly(2021, 02, 08) },
                new Cellphone { Name = "iPhone 14", Manufacturer = "Apple", Price = 1299.99m, Year = new DateOnly(2021, 06, 04) },
                new Cellphone { Name = "LG V60 ThinQ", Manufacturer = "LG", Price = 899.99m, Year = new DateOnly(2020, 03, 20) },
                new Cellphone { Name = "Motorola Razr", Manufacturer = "Motorola", Price = 1499.99m, Year = new DateOnly(2019, 12, 26) },
                new Cellphone { Name = "Huawei P40 Pro", Manufacturer = "Huawei", Price = 999.99m, Year = new DateOnly(2020, 04, 07) }
            ];

            Console.WriteLine(cellphones.Count());
            Console.WriteLine(cellphones.Count(cellphone => cellphone.Price > 100));
            Console.WriteLine(cellphones.Count(cellphone => cellphone.Price > 400 && cellphone.Price < 700));
            Console.WriteLine(cellphones.Count(cellphone => cellphone.Manufacturer.Equals("Apple")));
            Console.WriteLine(cellphones.MinBy(cellphone => cellphone.Price));
            Console.WriteLine(cellphones.MaxBy(cellphone => cellphone.Price));
            Console.WriteLine(cellphones.MinBy(cellphone => cellphone.Year));
            Console.WriteLine(cellphones.MaxBy(cellphone => cellphone.Year));
            Console.WriteLine(cellphones.Average(cellphone => cellphone.Price));
            Console.WriteLine("\nСАМЫЕ ДОРОГИЕ\n");
            foreach (var cellphone in cellphones.OrderByDescending(cellphone => cellphone.Price).Take(5))
            {
                Console.WriteLine(cellphone);
            }
            Console.WriteLine("\nСАМЫЕ ДЕШЕВЫЕ\n");
            foreach (var cellphone in cellphones.OrderBy(cellphone => cellphone.Price).Take(5))
            {
                Console.WriteLine(cellphone);
            }
            Console.WriteLine("\nСАМЫЕ СТАРЫЕ\n");
            foreach (var cellphone in cellphones.OrderBy(cellphone => cellphone.Year).Take(3))
            {
                Console.WriteLine(cellphone);
            }
            Console.WriteLine("\nСАМЫЕ НОВЫЕ\n");
            foreach (var cellphone in cellphones.OrderByDescending(cellphone => cellphone.Year).Take(3))
            {
                Console.WriteLine(cellphone);
            }
        }

        public class Cellphone
        {
            public string Name { get; set; }
            public string Manufacturer { get; set; }
            public decimal Price { get; set; }
            public DateOnly Year { get; set; }

            public override string ToString()
            {
                return $"Name - {Name}, Manufacturer - {Manufacturer}, Price - {Price}, Year - {Year}";
            }
        }
    }*/

    /*class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
            new Product{ Id = 1, Name = "Product1", Price = 70},
            new Product{ Id = 2, Name = "Product2", Price = 43},
            new Product{ Id = 3, Name = "Product3", Price = 120},
            new Product{ Id = 4, Name = "Product4", Price = 59},
            new Product{ Id = 5, Name = "Product5", Price = 55},
            new Product{ Id = 6, Name = "Product6", Price = 89},
            new Product{ Id = 7, Name = "Product7", Price = 74}
            };

            List<Category> categories = new List<Category>()
            {
            new Category{ Name = "Category1", Products = new List<Product>()
                    {
                        products[0], products[3], products[6]
                    }
                },
            new Category{ Name = "Category2", Products = new List<Product>()
                    {
                        products[0], products[1], products[6], products[5], products[4]
                    }
                },
            new Category{ Name = "Category3", Products = new List<Product>()
                    {
                        products[4], products[3], products[6], products[1], products[2]
                    }
                }
            };
            List<Product> productsWithPriceAbove50 = categories.SelectMany(c => c.Products).Where(product => product.Price > 50).ToList();
            foreach (Product product in productsWithPriceAbove50)
            {
                Console.WriteLine($"{product.Name} | {product.Price}");
            }
        }
    }


    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }*/
}
