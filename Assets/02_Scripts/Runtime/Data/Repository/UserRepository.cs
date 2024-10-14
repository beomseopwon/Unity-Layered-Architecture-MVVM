using Company.ProjectA.Domain;
using VContainer;

namespace Company.ProjectA.Data
{
    public sealed class UserRepository : IUserRepository
    {
        /// <summary>
        /// store를 두는 이유는 가짜 데이터를 사용하기 위함
        /// 레포지토리에서 매핑하는 로직은 같이 사용하는 구조
        /// 추가로 store 종류와 로직이 변경되어도 repository 는 그대로 유지 함으로써 사용하는 곳 에서는 변경이 최소화
        /// </summary>
        private readonly IUserStore _store;
        [Inject]
        public UserRepository(IUserStore store)
        {
            _store = store;
        }

        public User GetUser(int id)
        {
            var data = _store.GetUser(id);
            return data.ToDomain();
        }
    }
}
