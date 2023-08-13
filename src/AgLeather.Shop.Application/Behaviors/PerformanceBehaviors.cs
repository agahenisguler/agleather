using ArxOne.MrAdvice.Advice;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
