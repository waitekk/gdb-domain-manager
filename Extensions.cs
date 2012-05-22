using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

﻿// <copyright file="Extensions.cs" company="Umbriel Project">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>Jay Cummins</author>
// <email>cumminsjp@gmail.com</email>
// <date>2010-11-10</date>
// <summary>Extensions class file</summary>

namespace gdb_domain_manager
{
    using ESRI.ArcGIS.DataSourcesGDB;
    using ESRI.ArcGIS.Geodatabase;
    using DomainList = System.Collections.Generic.List<ESRI.ArcGIS.Geodatabase.IDomain>;

    public static class Extensions
    {
        /// <summary>
        /// Converts string to Workspace
        /// </summary>
        /// <param name="s">The connection string  for geodatabase</param>
        /// <returns>geodatabase IWorkspace </returns>
        public static IWorkspace ToWorkspace(this string s)
        {
            IWorkspace workspace = null;

            try
            {
                if (s.EndsWith("sde", StringComparison.CurrentCultureIgnoreCase))
                {
                    IWorkspaceFactory factory = new SdeWorkspaceFactoryClass();
                    workspace = factory.OpenFromFile(s, 0);
                }
                else if (s.EndsWith("gdb", StringComparison.CurrentCultureIgnoreCase))
                {
                    IWorkspaceFactory factory = new FileGDBWorkspaceFactoryClass();
                    workspace = factory.OpenFromFile(s, 0);
                }
                else if (s.EndsWith("mdb", StringComparison.CurrentCultureIgnoreCase))
                {
                    IWorkspaceFactory factory = new AccessWorkspaceFactoryClass();
                    workspace = factory.OpenFromFile(s, 0);
                }
            }
            catch (Exception e)
            {
                //Trace.WriteLine(e.StackTrace);
                //Console.WriteLine(e.Message);
            }

            return workspace;
        }

        /// <summary>
        /// Converts IEnumDomain to domain list.
        /// </summary>
        /// <param name="domains">The IEnumDomain</param>
        /// <returns>list of IDomain</returns>
        public static DomainList ToDomainList(this IEnumDomain domains)
        {
            DomainList list = new DomainList();

            IDomain domain = null;

            while ((domain = domains.Next()) != null)
            {
                list.Add(domain);
            }

            return list;
        }

    }
}
