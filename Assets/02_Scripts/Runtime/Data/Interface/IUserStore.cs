namespace Company.ProjectA.Data
{
    public interface IUserStore
    {
        UserResponseDTO GetUser(int id);
    }
}
