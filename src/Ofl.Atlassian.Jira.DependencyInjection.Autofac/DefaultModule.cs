using System;
using Autofac;
using Ofl.Atlassian.Jira.V2;

namespace Ofl.Atlassian.Jira.DependencyInjection.Autofac
{
    public class DefaultModule : Module
    {
        #region Overrides of Module

        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<JiraClient>().As<IJiraClient>();
            builder.RegisterType<BasicAuthenticationCredentialProvider>().As<ICredentialProvider>();
        }

        #endregion
    }
}
