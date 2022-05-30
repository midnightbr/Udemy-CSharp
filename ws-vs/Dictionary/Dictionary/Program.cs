Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "Henrique";
cookies["email"] = "henrique@gmail.com";
cookies["phone"] = "99771122";

Console.WriteLine(cookies["phone"]);

cookies.Remove("phone");

Console.WriteLine("Email: " + cookies["email"]);

if (cookies.ContainsKey("phone"))
{
    Console.WriteLine("Phone: " + cookies["phone"]);
}
else
{
    Console.WriteLine("There is not 'phone' key!");
}

Console.WriteLine("Size: " + cookies.Count);

Console.WriteLine("All Cookies:");
// KeyValuePair<string, string> pode ser substituido por apenas var.
foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine(item.Key + "=" + item.Value);
}