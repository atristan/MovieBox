#region Includes

// .NET Libraries
using  System;
using System.ComponentModel;

// StructureMap Libraries
using StructureMap;

// MovieBox Libraries
using Entities;
using MovieBox.Web.DependencyResolution;

#endregion

#region WebActivatorEx

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MovieBox.Web.App_Start.StructureMap), "Start")]

#endregion

namespace MovieBox.Web.App_Start
{
    public static class StructureMap
    {
        public static void Start()
        {
            IContainer container = IoC.Initialize();
        }
    }
}