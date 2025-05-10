class ChatBot
{
    public string Respond(string greeting)
    {
        return "Hello " + greeting;
    }
    public string Respond(string question, bool isFormal)
    {
        if (isFormal)
            return "Formal question, " + question;
        else
            return "Casual question, " + question;
    }
    public string Respond(int number)
    {
        return "You entered a number, " + number + "*2 = " + number * 2;
    }
}


class Program
{
    public static void Main()
    {
        ChatBot bot = new ChatBot();

        string response1 = bot.Respond("How are you?",true);
        Console.WriteLine(response1);

        string response2 = bot.Respond("Hi Tom",false);
        Console.WriteLine(response2);

        string number = bot.Respond(24);
        Console.WriteLine(number);
    }
}