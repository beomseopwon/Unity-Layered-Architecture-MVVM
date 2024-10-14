using UnityEngine.Assertions;

namespace Company.ProjectA.Domain
{
    public sealed class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public void ChangeEmail(string newEmail)
        {
            Assert.IsNull(Name);
            Email = newEmail;
        }

        public void ChangeName(string newName)
        {
            Assert.IsNull(Name);
            Name = newName;
        }
    }
}
