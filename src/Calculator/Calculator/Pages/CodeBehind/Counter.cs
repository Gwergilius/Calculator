using Microsoft.AspNetCore.Components;

namespace Calculator.Pages.CodeBehind
{
    public class Counter : ComponentBase
    {
        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}