using Company.ProjectA.Domain;
using UnityEngine;

namespace Company.ProjectA.Data
{
    [System.Serializable]
    public sealed class UserResponseDTO
    {
        [field:SerializeField]
        public int Id { get; set; }
        [field: SerializeField]
        public string Name { get; set; }
        [field: SerializeField]
        public string Email { get; set; }

        public User ToDomain()
        {
            return new User(Id, Name, Email);
        }
    }
}
