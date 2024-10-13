using Company.ProjectA.Data;
using UnityEngine;
using VContainer;

namespace Company.ProjectA.Application
{
    public sealed class SubGameLifeTimeScope : MonoBehaviour
    {
        public RealStoreSO SampleStoreSO;

        public void Configure(IContainerBuilder builder)
        {
            RegistData(builder);
        }
        
        private void RegistData(IContainerBuilder builder)
        {
            builder.RegisterInstance(SampleStoreSO).AsImplementedInterfaces();
        }
    }
}
