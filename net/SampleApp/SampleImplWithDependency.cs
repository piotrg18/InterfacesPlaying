namespace SampleApp
{
    public class SampleImplWithDependency
    {
        private  IDependency DependencyInterface { get; }
        public DependencyWithoutInterface DependencyWithoutInterface { get; }

        public SampleImplWithDependency(IDependency dependency)
        {
            DependencyInterface = dependency;
        }

        public SampleImplWithDependency(DependencyWithoutInterface dependency)
        {
            DependencyWithoutInterface = dependency;
        }


        public string TestIterfaceDependency()
        {
            return DependencyInterface.Info("Interface Dependency");
        }

        public string TestDependencyWithoutInterface()
        {
            return DependencyWithoutInterface.Info("No Interface Dependency");
        }

    }
}
