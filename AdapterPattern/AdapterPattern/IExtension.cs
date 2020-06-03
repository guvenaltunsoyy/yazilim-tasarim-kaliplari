namespace AdapterPattern
{
    public interface IExtension
    {
        UserModel ToUserModel(User user, School school, Address address);
    }
}