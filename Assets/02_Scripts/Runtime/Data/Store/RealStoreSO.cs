using UnityEngine;

namespace Company.ProjectA.Data
{
    public class RealStoreSO : ScriptableObject, ISampleStore
    {
        public string Data;
        public virtual string GetData()
        {
            return Data;
        }
    }
}
