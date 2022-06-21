using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Model;

namespace Webapi
{
    public class CustomCountryDetils : IModelBinder
    {
        Task IModelBinder.BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelname = bindingContext.ModelName;
            var value = bindingContext.ValueProvider.GetValue(modelname);
            var result = value.FirstValue;

            if(!int.TryParse(result,out var id))
            {
                return Task.CompletedTask;
            }

            var model = new County()
            {
                Id = id,
                Name = "Manoj",
                action = "yes"
            };
            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
