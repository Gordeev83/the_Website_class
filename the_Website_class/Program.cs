namespace the_Website_class
{
    class Website
    {
        // Поля класса
        private string name;
        private string path;
        private string description;
        private string ipAddress;

        // Метод для ввода данных
        public void InputData()
        {
            Console.WriteLine("Введите название сайта:");
            name = Console.ReadLine();

            Console.WriteLine("Введите путь к сайту:");
            path = Console.ReadLine();

            Console.WriteLine("Введите описание сайта:");
            description = Console.ReadLine();

            Console.WriteLine("Введите IP-адрес сайта:");
            ipAddress = Console.ReadLine();
        }

        // Метод для вывода данных
        public void OutputData()
        {
            Console.WriteLine("Название сайта: " + name);
            Console.WriteLine("Путь к сайту: " + path);
            Console.WriteLine("Описание сайта: " + description);
            Console.WriteLine("IP-адрес сайта: " + ipAddress);
        }

        // Методы для доступа к отдельным полям через методы класса
        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetPath()
        {
            return path;
        }

        public void SetPath(string newPath)
        {
            path = newPath;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string newDescription)
        {
            description = newDescription;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }

        public void SetIpAddress(string newIpAddress)
        {
            ipAddress = newIpAddress;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Website website = new Website();

            // Ввод данных
            website.InputData();

            // Вывод данных
            website.OutputData();

            // Перезапись значения поля через метод класса
            website.SetName("Новое название сайта");

            // Получение значения поля через метод класса
            string websiteName = website.GetName();
            Console.WriteLine("Название сайта после изменения: " + websiteName);

            Console.ReadLine();
        }
    }
}
