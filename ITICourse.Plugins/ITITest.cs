using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITICourse.Plugins
{
    public class ITITest : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var tracingService = (ITracingService)serviceProvider.GetService(typeof(ITITest)); // for debuging

            var context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext)); // geva me info about entity and user who take action with entity 

            var serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));

            var service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);

            var itiCoursesProfEntity = new Entity("iti Courses Proffessor")
            {
                ["name"] = "Ahmed Abd Elsalam",
                ["gendreCode"] = new OptionSetValue()
            };

            throw new InvalidPluginExecutionException("test exp");
           
        }
    }
}
