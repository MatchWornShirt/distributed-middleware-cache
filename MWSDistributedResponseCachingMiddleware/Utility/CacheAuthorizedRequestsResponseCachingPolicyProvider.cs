﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.ResponseCaching;

namespace ExternalNetcoreExtensions.Utility
{
	internal class CacheAuthorizedRequestsResponseCachingPolicyProvider : ResponseCachingPolicyProvider
	{
		/// <remarks>
		/// This method is copied from ResponseCachingPolicyProvider.AttemptResponseCaching, modified to
		/// cache requests which use authorization.
		/// </remarks>
		public override bool AttemptResponseCaching(ResponseCachingContext context)
		{
			var request = context.HttpContext.Request;

			// Verify the method
			if (!HttpMethods.IsGet(request.Method) && !HttpMethods.IsHead(request.Method))
			{
				context.Logger.RequestMethodNotCacheable(request.Method);
				return false;
			}

			return true;
		}
	}
}
