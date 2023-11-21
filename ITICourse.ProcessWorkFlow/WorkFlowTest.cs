using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITICourse.ProcessWorkFlow
{
    public class WorkFlowTest : CodeActivity
    {
        protected override void Execute(CodeActivityContext executionContext)
        {
            var tracingService = executionContext.GetExtension<ITracingService>();
            var context = executionContext.GetExtension<IWorkflowContext>();
            var serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            var service = serviceFactory.CreateOrganizationService(null);

            Entity target;

            if (context.InputParameters.Contains("Target"))
            {
                target = (Entity)context.InputParameters["Target"];
            }
            else 
            {
                Entity Account = service.Retrieve(context.PrimaryEntityName , context.PrimaryEntityId , new Microsoft.Xrm.Sdk.Query.ColumnSet(true));
            }
        }
    }
} 
