using Microsoft.AspNetCore.Components;

namespace Gwergilius.Calculator.Components.Samples
{
    public class CounterCode : ComponentBase
    {
        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}