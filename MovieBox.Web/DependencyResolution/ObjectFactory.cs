#region Includes

// .NET Libraries
using System;
using System.Threading;

// StructureMap
using StructureMap;

#endregion

namespace MovieBox.Web.DependencyResolution
{
    public static class ObjectFactory
    {
        #region Fields

        private static readonly Lazy<Container> _containerBuilder = new Lazy<Container>(GetDefaultContainer, LazyThreadSafetyMode.ExecutionAndPublication);

        #endregion

        #region Properties

        public static IContainer Container => _containerBuilder.Value;

        #endregion

        #region Methods

        private static Container GetDefaultContainer() => new Container(x =>
                
            );

        #endregion
    }
}