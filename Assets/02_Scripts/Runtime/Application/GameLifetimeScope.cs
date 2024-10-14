using Company.ProjectA.Data;
using Company.ProjectA.Domain;
using Company.ProjectA.Presentation;
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


        public bool UseMockData = true;

        protected override void Configure(IContainerBuilder builder)
        {
            RegistPresentation(builder);
            RegistDomain(builder);
            RegistData(builder);

            if (UseMockData)
            {
#if UNITY_EDITOR
                _lifeTimeScope = MockLifeTimeScope;
#endif
            }
            else
            {
                _lifeTimeScope = RealLifeTimeScope;
            }
            _lifeTimeScope.Configure(builder);
        }

        private void RegistPresentation(IContainerBuilder builder)
        {
            builder.Register<UserViewModel>(Lifetime.Singleton);
        }

        private void RegistDomain(IContainerBuilder builder)
        {
            builder.Register<UserUseCase>(Lifetime.Singleton).AsImplementedInterfaces();
        }

        private void RegistData(IContainerBuilder builder)
        {
            builder.Register<UserRepository>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}
