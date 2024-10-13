using Company.ProjectA.Domain;
using R3;
using VContainer;

namespace Company.ProjectA.Presentation
{
    public sealed class SampleViewModel
    {
        private SampleUseCase _sampleUseCase;
        public ReactiveProperty<string> Data { get; private set; } = new ReactiveProperty<string>("Hello World");

        [Inject]
        public SampleViewModel(SampleUseCase sampleUseCase)
        {
            _sampleUseCase = sampleUseCase;
        }

        public void GetData()
        {
            Data.Value = $"{_sampleUseCase.GetData()}->Presentation Layer";
        }
    }
}
