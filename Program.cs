namespace vote;

class Program
{

    static string username = "";
    static string password = "";
    private static bool loggedIn = false;
    private static bool isVoted = false;

    static void CatEkle()
    {
        new Cats("GS");
        new Cats("FB");
        new Cats("BJK");


    }

    public static void Main()
    {
        if (!loggedIn)
            Giris();

        if (loggedIn)
        {
            while (!isVoted)
            {
                System.Console.WriteLine("Oy vermek istediğiniz kategoriyi seçiniz:");
                if (Cats.catList.Count < 1)
                    CatEkle();

                foreach (var item in Cats.catList)
                {
                    Console.WriteLine(item.CatId + " " + item.CatAdi);

                }

                Cats GetCatty = GetCat(Int32.Parse(Console.ReadLine()));
                GetCatty.addVote();
                isVoted = User.userList.Find(x => x.username == username).voted;
                isVoted = true;
                foreach (var item in Cats.catList)
                {
                    Console.WriteLine(item.CatId + " " + item.CatAdi + " - toplam oy: " + item.CatVote);
                }
            }
            if (isVoted)
            {
                System.Console.WriteLine("Oyunuz başarıyla kaydedildi.");
            }
            Giris();

        }
        else
        {
            System.Console.WriteLine("Önce Giriş Yapınız");
        }

    }
    private void KategorileriEkranaYaz()
    {
        foreach (var item in Cats.catList)
        {
            Console.WriteLine(item.CatAdi);
        }
    }
    public static Cats GetCat(int catId)
    {
        return Cats.catList.Find(x => x.CatId == catId);

    }


    public static bool isUserExists(string userName)
    {
        foreach (User item in User.userList)
        {
            if (item.username == userName)
            {
                return true;
            }
        }
        return false;
    }

    public static void AddUser()
    {
        System.Console.WriteLine("Kullanıcı adınızı giriniz:");
        string userName = Console.ReadLine();
        System.Console.WriteLine("Parolanızı giriniz:");
        string password = Console.ReadLine();
        bool voted = false;
        isVoted = voted;
        User.userList.Add(new User(userName, password, voted));
        loggedIn = true;
    }

    public static void Giris()
    {
        Console.WriteLine("Kullanıcı adınızı giriniz: ");
        username = Console.ReadLine();
        Console.WriteLine("şifrenizi password: ");
        password = Console.ReadLine();
        if (User.userList.Exists(x => x.username == username && x.password == password))
        {
            Console.WriteLine("Welcome " + username + "!");
            loggedIn = true;


        }
        else
        {
            Console.WriteLine("Invalid username or password!");
            AddUser();
            Main();

        }

    }



}


