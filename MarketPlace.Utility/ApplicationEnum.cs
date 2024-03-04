namespace MarketPlace.Utility
{
    public enum LoginStatus
    {
        UserDoesNotExist = 1,
        InactiveAccount = 2,
        AccountLockedOut = 3,
        Success = 4,
        LoginFailedAttempt = 5,
        LoginServerError = 6
    }
}