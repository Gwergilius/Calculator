using Microsoft.AspNetCore.Components;

namespace Gwergilius.Calculator.Components.Samples
{
    public class SurveyPromptCode : ComponentBase
    {
        // Demonstrates how a parent component can supply parameters
        [Parameter]
        public string Title { get; set; }
    }
}