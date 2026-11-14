using System;
using System.Text;

class WebSite
{
    private string name;
    private string url;
    private string description;
    private string ip;

    public void Input()
    {
        Console.Write("Назва сайту: ");
        name = Console.ReadLine();
        Console.Write("Шлях до сайту: ");
        url = Console.ReadLine();
        Console.Write("Опис сайту: ");
        description = Console.ReadLine();
        Console.Write("IP-адреса: ");
        ip = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"Сайт: {name}");
        Console.WriteLine($"Шлях: {url}");
        Console.WriteLine($"Опис: {description}");
        Console.WriteLine($"IP-адреса: {ip}");
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetUrl()
    {
        return url;
    }

    public void SetUrl(string url)
    {
        this.url = url;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetIp()
    {
        return ip;
    }

    public void SetIp(string ip)
    {
        this.ip = ip;
    }
}

class Magazine
{
    private string name;
    private int year;
    private string description;
    private string phone;
    private string email;

    public void Input()
    {
        Console.Write("Назва журналу: ");
        name = Console.ReadLine();
        Console.Write("Рік заснування: ");
        year = int.Parse(Console.ReadLine());
        Console.Write("Опис журналу: ");
        description = Console.ReadLine();
        Console.Write("Контактний телефон: ");
        phone = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"Журнал: {name}");
        Console.WriteLine($"Рік заснування: {year}");
        Console.WriteLine($"Опис: {description}");
        Console.WriteLine($"Телефон: {phone}");
        Console.WriteLine($"Email: {email}");
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetYear()
    {
        return year;
    }

    public void SetYear(int year)
    {
        this.year = year;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetPhone()
    {
        return phone;
    }

    public void SetPhone(string phone)
    {
        this.phone = phone;
    }

    public string GetEmail()
    {
        return email;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }
}

class Shop
{
    private string name;
    private string address;
    private string profile;
    private string phone;
    private string email;

    public void Input()
    {
        Console.Write("Назва магазину: ");
        name = Console.ReadLine();
        Console.Write("Адреса: ");
        address = Console.ReadLine();
        Console.Write("Опис профілю: ");
        profile = Console.ReadLine();
        Console.Write("Контактний телефон: ");
        phone = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"Магазин: {name}");
        Console.WriteLine($"Адреса: {address}");
        Console.WriteLine($"Профіль: {profile}");
        Console.WriteLine($"Телефон: {phone}");
        Console.WriteLine($"Email: {email}");
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public string GetProfile()
    {
        return profile;
    }

    public void SetProfile(string profile)
    {
        this.profile = profile;
    }

    public string GetPhone()
    {
        return phone;
    }

    public void SetPhone(string phone)
    {
        this.phone = phone;
    }

    public string GetEmail()
    {
        return email;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Завдання 4");
        WebSite site = new WebSite();
        site.Input();
        Console.WriteLine();
        site.Show();
        site.SetIp("192.168.0.10");
        Console.WriteLine($"Нова IP-адреса сайту {site.GetName()}: {site.GetIp()}");

        Console.WriteLine("\nЗавдання 5");
        Magazine magazine = new Magazine();
        magazine.Input();
        Console.WriteLine();
        magazine.Show();
        magazine.SetEmail("editor@mail.com");
        Console.WriteLine($"Журнал {magazine.GetName()} заснований у {magazine.GetYear()} році, новий email: {magazine.GetEmail()}");

        Console.WriteLine("\nЗавдання 6");
        Shop shop = new Shop();
        shop.Input();
        Console.WriteLine();
        shop.Show();
        shop.SetAddress("вул. Шевченка, 10");
        Console.WriteLine($"Магазин {shop.GetName()} переїхав за адресою: {shop.GetAddress()}");
    }
}
