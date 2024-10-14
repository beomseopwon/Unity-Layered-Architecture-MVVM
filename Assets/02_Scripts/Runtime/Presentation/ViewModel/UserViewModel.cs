using Company.ProjectA.Domain;
using R3;
using VContainer;

namespace Company.ProjectA.Presentation
{
    public sealed class UserViewModel
    {
        private UserUseCase _useCase;
        public ReactiveProperty<int> Id { get; private set; } = new ReactiveProperty<int>();
        public ReactiveProperty<string> Name { get; private set; } = new ReactiveProperty<string>();
        public ReactiveProperty<string> Email { get; private set; } = new ReactiveProperty<string>();
        [Inject]
        public UserViewModel(UserUseCase useCase)
        {
            _useCase = useCase;
        }

        public void GetUser(int id)
        {
            var userData = _useCase.GetUser(id);
            Id.Value = userData.Id;
            Name.Value = userData.Name;
            Email.Value = userData.Email;
        }
    }
}
