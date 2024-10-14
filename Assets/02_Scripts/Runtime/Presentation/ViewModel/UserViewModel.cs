using Company.ProjectA.Domain;
using R3;
using VContainer;

namespace Company.ProjectA.Presentation
{
    public sealed class UserViewModel
    {
        private IUserUseCase _useCase;
        public ReactiveProperty<User> UserData { get; private set; }

        [Inject]
        public UserViewModel(IUserUseCase useCase)
        {
            UserData = new ReactiveProperty<User>();
            _useCase = useCase;
        }

        public void GetUser(int id)
        {
            UserData.Value = _useCase.GetUser(id);
        }
    }
}
