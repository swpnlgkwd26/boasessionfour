﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Infrastructure
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly IModelMetadataProvider modelMetadataProvider;

        public CustomExceptionFilter(IModelMetadataProvider modelMetadataProvider)
        {
            this.modelMetadataProvider = modelMetadataProvider;
        }
        public void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomError" };
            result.ViewData = new Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary(modelMetadataProvider, context.ModelState);
            result.ViewData.Add("Exception", context.Exception);
            context.ExceptionHandled = true;
            context.Result = result;
        }
    }
}
