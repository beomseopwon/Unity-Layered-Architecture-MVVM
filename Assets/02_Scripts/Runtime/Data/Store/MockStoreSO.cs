using UnityEngine;

namespace Company.ProjectA.Data
{
    [CreateAssetMenu]
    public sealed class MockStoreSO : RealStoreSO, ISampleStore
    {
        public override string GetData()
        {
            return Data;
        }
    }
}
