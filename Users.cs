namespace vote;
internal class User
{
    public string username;
    public string password;
    public bool voted;
    public static List<User> userList = new List<User>();



    public User(string username, string password,bool voted)
    {
        this.username = username;
        this.password = password;
        this.voted = voted;
        userList.Add(this);
    }    



}