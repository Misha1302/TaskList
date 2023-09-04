namespace WebApplication1;

using System.Text;
using Microsoft.IdentityModel.Tokens;

public static class AuthOptions
{
    public const string Issuer = "MyAuthServer"; // издатель токена
    public const string Audience = "MyAuthClient"; // потребитель токена
    private const string Key = "mysupersecret_secretkey!12345678"; // ключ для шифрации

    public static SymmetricSecurityKey GetSymmetricSecurityKey() => new(Encoding.UTF8.GetBytes(Key));
}