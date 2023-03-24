Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
string favorite = "маша";

if (username.ToLower()==favorite){
    Console.WriteLine("Ура, это же МАША!");
}else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
