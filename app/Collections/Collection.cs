namespace FundamentalUpskilling;

public class Collection
{
    public static void Main(string[] args)
    {
        /*
            Collection mirimp dengan array
            Keunggulan:
                -> Menambah data terus menerus
                -> flexible
                -> bisa CRUD
            
            Macam - macam Collection:
                -> List
                -> Queue
                -> Stack
                -> Dictionary
                -> HashSet
                -> SortedList
                -> SortedSet
                -> SortedDictionary
                -> SortedList
        */

        
        // List();
        // UpdateCity(cities);

        /*
            HashSet hanya bisa diakses menggunakan foreach
            HashSet hanya bisa menyimpan data unik
            Apabila ingin update HashSet, harus remove dulu baru Add
        */

        // HashSet()

        /*
            List        : Mirip dengan array, bedanya dia lebih flexible dan mudah untuk mengoperasikan CRUD
            HashSet     : Dia hanya bisa menyimpan data unik
            HashTable   : Datanya berupa key dan value (Ini semua tipe data bisa masuk)
            Dictionary  : Datanya berupa key dan value, dan mirip dengan HashTable tetapi berseifat generic (kita perlu tentukan tipe data)
        */

        var cities = new Dictionary<string, string>();
        cities.Add("Indonesia", "Jakarta");
        cities.Add("Malaysia", "Kuala Lumpur");
        cities.Add("Singapura", "Singapura");
        cities.Add("Brunei", "Bandar Seri Begawan");
        cities.Add("Filipina", "Manila");

        foreach (var city in cities)
        {
            Console.WriteLine($"{city.Key} : {city.Value}");
        }

        Collection hashSet = new Collection();

        hashSet.HashSet();
        
    }

    private void HashSet()
    {
        var names = new HashSet<string>();

        names.Add("Adrian");
        names.Add("Adrian");
        names.Add("Hadinata");
        names.Add("Hadi");
        names.Add("Darsono");
        names.Add("Adrian");

        Console.WriteLine("Isi dari HashSet: ");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Masukan Nama yang ingin di update: ");

        string namee = Console.ReadLine();
        
        if(!names.Contains(namee))
        {
            throw new NotFoundException("Name not found");
        }

        Console.Write("Masukan Nama yang terupdate: ");

        string updatedName = Console.ReadLine();

        names.RemoveWhere(s => s.Equals(namee));
        names.Add(updatedName);

        Console.WriteLine("Isi dari HashSet: ");
        foreach (var nameee in names)
        {
            Console.WriteLine(nameee);
        }
    }

    private void List()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        Console.WriteLine("Isi dari list angka: ");

        foreach (var number in numbers)
        {
            Console.WriteLine($"Angka {number}");
        }

        // cara mengisi list secara langsung
        var cities = new List<string>
        {
            "Jakarta",
            "Bandung",
            "Surabaya"
        };
    }

    private static void UpdateCity(List<string> cities)
    {
        Console.WriteLine("Isi dari list cities: ");

        int i = 0;
        foreach (var city in cities)
        {
            i++;
            Console.WriteLine($"{i}. Kota {city}");
        }

        Console.Write("Inputkan nomor kota yang ingin diubah: ");
        
        int idCity = int.Parse(Console.ReadLine());

        Console.Write("Inputkan nama kota baru: ");

        string newCity = Console.ReadLine();

        cities[idCity - 1] = newCity;

        Console.WriteLine("Isi dari list cities: ");

        foreach (var city in cities)
        {
            Console.WriteLine($"Kota {city}");
        }
    }
}