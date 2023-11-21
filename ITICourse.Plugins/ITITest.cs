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
            try
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

                // Target entity 

                //Entity targetEntity = (Entity)context.InputParameters["Target"];

                //Entity entity = service.Retrieve(targetEntity.LogicalName , targetEntity.Id, new Microsoft.Xrm.Sdk.Query.ColumnSet("name")); // return name of entity 
                //Entity entity = service.Retrieve(targetEntity.LogicalName , targetEntity.Id, new Microsoft.Xrm.Sdk.Query.ColumnSet(true)); // return all fields of entity 


            }
            catch (Exception e) 
            {
                throw new InvalidPluginExecutionException($"Error msg: {e.ToString()}");
            }

        }
    }
}
