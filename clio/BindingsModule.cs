﻿using Autofac;
using Clio.Command;
using Clio.Common;
using System.Reflection;

namespace Clio
{
	public class BindingsModule
	{
		public IContainer Register(EnvironmentSettings settings = null) {
			var containerBuilder = new ContainerBuilder();
			containerBuilder
				.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
				.AsImplementedInterfaces();
			if (settings != null) {
				containerBuilder.RegisterInstance(new CreatioClientAdapter(settings.Uri, settings.Login, 
					settings.Password, settings.IsNetCore)).As<IApplicationClient>();
				containerBuilder.RegisterInstance(settings);
			}
			containerBuilder.RegisterType<PushPackageCommand>();
			containerBuilder.RegisterType<PingAppCommand>();
			containerBuilder.RegisterType<CompressPackageCommand>();
			containerBuilder.RegisterType<PushNuGetPackagesCommand>();
			containerBuilder.RegisterType<PackNuGetPackageCommand>();
			containerBuilder.RegisterType<RestoreNugetPackageCommand>();
			containerBuilder.RegisterType<InstallNugetPackageCommand>();
			return containerBuilder.Build();
		}
	}
}
