using VContainer;

namespace Company.ProjectA.Domain
{
    public sealed class UserUseCase : IUserUseCase
    {
        private IUserRepository _repository;

        [Inject]
        public UserUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public User GetUser(int id)
        {
            //유저 정보 이외의 데이터를 조합 할 수도 있습니다.
            return _repository.GetUser(id);
        }
    }
}
