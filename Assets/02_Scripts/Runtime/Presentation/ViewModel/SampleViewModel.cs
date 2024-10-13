using Company.ProjectA.Domain;
using VContainer;

namespace Company.ProjectA.Presentation
{
    public sealed class SampleViewModel
    {
        private SampleUseCase _sampleUseCase;
        [Inject]
        public SampleViewModel(SampleUseCase sampleUseCase)
        {
            _sampleUseCase = sampleUseCase;
        }
    }
}
