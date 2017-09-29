namespace SampleApp
{
    public class DependencyWithInterface : IDependency
    {
        public string Info(string sample) => $"Output: {sample}";
    }
}
