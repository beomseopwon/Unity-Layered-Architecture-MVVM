using Company.ProjectA.Data;
using Company.ProjectA.Domain;
using VContainer;
using VContainer.Unity;

namespace Company.ProjectA.Application
{
    public sealed class SubGameLifeTimeScope : LifetimeScope
    {
        public RealStoreSO SampleStoreSO;

        protected override void Configure(IContainerBuilder builder)
        {
            RegistPresentation(builder);
            RegistDomain(builder);
            RegistData(builder);
        }

        private void RegistPresentation(IContainerBuilder builder)
        {
        }

        private void RegistDomain(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<SampleEntryPoint>(Lifetime.Singleton);
            builder.Register<SampleUseCase>(Lifetime.Singleton);
        }

        private void RegistData(IContainerBuilder builder)
        {
            builder.RegisterInstance(SampleStoreSO).AsImplementedInterfaces();
            builder.Register<SampleRepository>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}
