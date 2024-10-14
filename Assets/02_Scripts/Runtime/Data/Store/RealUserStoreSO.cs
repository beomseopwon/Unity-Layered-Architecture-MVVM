using UnityEngine;

namespace Company.ProjectA.Data
{
    [CreateAssetMenu]
    public class RealUserStoreSO : ScriptableObject, IUserStore
    {
        public UserResponseDTO Data;
        public virtual UserResponseDTO GetUser(int id)
        {
            return Data;
        }
    }
}
