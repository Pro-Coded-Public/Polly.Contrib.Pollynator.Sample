namespace Polly.Contrib.Pollynator.Sample
{
    using System.Threading.Tasks;

    interface ITestInterface
    {
        Task<T> TestMethod1Async<T>(string someParamater);

        Task<T> TestMethod2Async<T>(string someParamater, int anotherParameter) where T : TestConstraintClass;

        void TestMethod3<T>() where T : TestConstraintClass;
    }

    public class TestConstraintClass
    {
    }
}
