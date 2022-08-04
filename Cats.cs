namespace vote;

internal class Cats{
    private int catId;
    private static int sayac = 0;
    private int catVote;
    private string catAdi;
    public static List <Cats> catList = new List<Cats>();

    public int CatId { get => catId; set => catId = value; }
    public int CatVote { get => catVote; set => catVote = value; }
    public string CatAdi { get => catAdi; set => catAdi = value; }

    public Cats(string catAdi){
        this.CatAdi = catAdi;
        sayac++;
        catId = sayac;
        catList.Add(this);
    }

    public void addVote()
    {
        catVote++;
        this.catVote = catVote;
    }

    
}