﻿namespace Nancy.Routing
{
    /// <summary>
    /// Defines the functionality for invoking a <see cref="Route"/> and returning a <see cref="Response"/>
    /// </summary>
    public interface IRouteInvoker
    {
        /// <summary>
        /// Invokes the specified <paramref name="route"/> with the provided <paramref name="parameters"/>.
        /// </summary>
        /// <param name="route">The route that should be invoked.</param>
        /// <param name="parameters">The parameters that the route should be invoked with.</param>
        /// <returns>A <see cref="Response"/> intance that represents the result of the invoked route.</returns>
        Response Invoke(Route route, DynamicDictionary parameters);
    }
}