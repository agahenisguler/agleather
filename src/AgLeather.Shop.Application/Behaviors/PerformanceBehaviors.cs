using ArxOne.MrAdvice.Advice;
using Serilog;
using System.Diagnostics;

namespace AgLeather.Shop.Application.Behaviors
{
    public class PerformanceBehaviors : Attribute, IMethodAdvice
    {
        public void Advise(MethodAdviceContext context)
        {
            Stopwatch watch = new Stopwatch();

            //Kronametreyi başlat.
            watch.Start();

            context.Proceed();

            //Kronometreyi durdur.
            watch.Stop();

            var totalDuration = watch.Elapsed.TotalSeconds;

            Log.Information($"{context.TargetName} metodu {totalDuration} saniyede tamamlandı");
        }
    }
}
