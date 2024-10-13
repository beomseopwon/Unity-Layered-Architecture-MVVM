using VContainer;

namespace Company.ProjectA.Domain
{
    public sealed class SampleUseCase : ISampleUseCase
    {
        private ISampleRepository _repository;

        [Inject]
        public SampleUseCase(ISampleRepository repository)
        {
            _repository = repository;
        }

        public string GetData()
        {
            return $"{_repository.GetData()}->Domain Layer";
        }
    }
}
