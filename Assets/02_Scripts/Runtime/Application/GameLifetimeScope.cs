using Company.ProjectA.Data;
using Company.ProjectA.Domain;
using Company.ProjectA.Presentation;
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
            RegistPresentation(builder);
            RegistDomain(builder);
            RegistData(builder);

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
            _lifeTimeScope.Configure(builder);
        }

        private void RegistPresentation(IContainerBuilder builder)
        {
            builder.Register<SampleViewModel>(Lifetime.Singleton);
        }

        private void RegistDomain(IContainerBuilder builder)
        {
            builder.Register<SampleUseCase>(Lifetime.Singleton);
        }

        private void RegistData(IContainerBuilder builder)
        {
            builder.Register<SampleRepository>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}
