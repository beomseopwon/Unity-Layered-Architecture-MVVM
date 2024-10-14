using UnityEngine;

namespace Company.ProjectA.Data
{
    [CreateAssetMenu]
    public sealed class MockUserStoreSO : RealUserStoreSO, IUserStore
    {
        public override UserResponseDTO GetUser(int id)
        {
            return Data;
        }
    }
}
