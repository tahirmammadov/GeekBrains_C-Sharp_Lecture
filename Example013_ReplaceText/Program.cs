Console.Clear();

string ReplaceText(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result = result + newValue;
        else result = result + text[i];
    }
    return result;
}

string text = "Привет, как дела Лукас! Ты наш предок и мы готовы ксерить сейчас!";

Console.WriteLine(ReplaceText(text, 'к', 'К'));