﻿namespace Microsoft.Web.Http
{
    using System;
    using System.Diagnostics.Contracts;

    static class TupleExtensions
    {
        internal static void Deconstruct<T1, T2>( this Tuple<T1, T2> tuple, out T1 item1, out T2 item2 )
        {
            Contract.Requires( tuple != null );

            item1 = tuple.Item1;
            item2 = tuple.Item2;
        }
    }
}