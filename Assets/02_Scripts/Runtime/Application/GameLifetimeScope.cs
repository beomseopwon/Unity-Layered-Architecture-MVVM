using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Company.ProjectA.Application
{
    public sealed class GameLifetimeScope : LifetimeScope
    {
#if UNITY_EDITOR
        public SubGameLifeTimeScope MockLifeTimeScope;
#endif
        public SubGameLifeTimeScope RealLifeTimeScope;

        private SubGameLifeTimeScope _lifeTimeScope;

        [Header("샘플 데이터 값이 Real 인지 Mock 인지 설정")]
        public bool IsReal = true;
        protected override void Configure(IContainerBuilder builder)
        {
            if (IsReal)
            {
                _lifeTimeScope = RealLifeTimeScope;
            }
            else
            {
#if UNITY_EDITOR
                _lifeTimeScope = MockLifeTimeScope;
#endif
            }
            _lifeTimeScope.Build();
        }
    }
}
