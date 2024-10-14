using Company.ProjectA.Data;
using UnityEngine;
using VContainer;

namespace Company.ProjectA.Application
{
    public sealed class SubGameLifeTimeScope : MonoBehaviour
    {
        public RealUserStoreSO UserStoreSO;

        public void Configure(IContainerBuilder builder)
        {
            RegistData(builder);
        }
        
        private void RegistData(IContainerBuilder builder)
        {
            builder.RegisterInstance(UserStoreSO).AsImplementedInterfaces();
        }
    }
}
