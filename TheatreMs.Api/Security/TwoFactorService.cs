namespace TheatreMs.Api.Security;

public interface ITwoFactorService
{
    string GenerateOtp();
    bool VerifyOtp(string userOtp, string storedOtp);
}

public class TwoFactorService : ITwoFactorService
{
    public string GenerateOtp()
    {
        return new Random().Next(100000, 999999).ToString();
    }

    public bool VerifyOtp(string userOtp, string storedOtp)
    {
        return userOtp == storedOtp;
    }
}
