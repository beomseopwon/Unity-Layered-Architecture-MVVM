using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Company.ProjectA.Domain
{
    public sealed class SampleEntryPoint : IInitializable
    {
        [Inject]
        public SampleEntryPoint(SampleUseCase sampleUseCase)
        {
            Debug.Log(sampleUseCase.GetData());
        }

        public void Initialize()
        {
        }
    }
}
