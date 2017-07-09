using System;
using System.Collections.Generic;
using System.Text;

namespace Polly.Contrib.Refactoring.Sample
{
    interface ITestInterface
    {
        void TestMethod<T>() where T : TestConstraintClass;
    }

    public class TestConstraintClass
    {
    }
}
