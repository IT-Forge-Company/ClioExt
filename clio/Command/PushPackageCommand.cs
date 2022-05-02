﻿using System;
using System.IO;
using System.Text;
using System.Threading;
using Clio.Common;
using Clio.Package;
using Clio.UserEnvironment;
using CommandLine;

namespace Clio.Command
{
	[Verb("push-pkg", Aliases = new string[] { "install" }, HelpText = "Install package on a web application")]
	public class PushPkgOptions : EnvironmentOptions
	{
		[Value(0, MetaName = "Name", Required = false, HelpText = "Package name")]
		public string Name { get; set; }

		[Option('r', "ReportPath", Required = false, HelpText = "Log file path")]
		public string ReportPath { get; set; }

		[Option("InstallSqlScript", Required = false, HelpText = "Install sql script")]
		public bool? InstallSqlScript { get; set; }

		[Option("InstallPackageData", Required = false, HelpText = "Install package data")]
		public bool? InstallPackageData { get; set; }

		[Option("ContinueIfError", Required = false, HelpText = "Continue if error")]
		public bool? ContinueIfError { get; set; }

		[Option("SkipConstraints", Required = false, HelpText = "Skip constraints")]
		public bool? SkipConstraints { get; set; }

		[Option("SkipValidateActions", Required = false, HelpText = "Skip validate actions")]
		public bool? SkipValidateActions { get; set; }

		[Option("ExecuteValidateActions", Required = false, HelpText = "Execute validate actions")]
		public bool? ExecuteValidateActions { get; set; }

		[Option("IsForceUpdateAllColumns", Required = false, HelpText = "Is force update all columns")]
		public bool? IsForceUpdateAllColumns { get; set; }

	}

	public class PushPackageCommand : Command<PushPkgOptions>
	{
		public PushPackageCommand(IPackageInstaller packageInstaller) {
			packageInstaller.CheckArgumentNull(nameof(packageInstaller));
			_packageInstaller = packageInstaller;

		}
		private readonly IPackageInstaller _packageInstaller;
		private readonly PackageInstallOptions _packageInstallOptionsDefault = new PackageInstallOptions();

		private PackageInstallOptions ExtractPackageInstallOptions(PushPkgOptions options) {
				var packageInstallOptions = new PackageInstallOptions {
					InstallSqlScript = options.InstallSqlScript ?? true,
					InstallPackageData = options.InstallPackageData ?? true,
					ContinueIfError = options.ContinueIfError ?? true,
					SkipConstraints = options.SkipConstraints ?? false,
					SkipValidateActions = options.SkipValidateActions ?? false,
					ExecuteValidateActions = options.ExecuteValidateActions ?? false,
					IsForceUpdateAllColumns = options.IsForceUpdateAllColumns ?? false
				};
				return packageInstallOptions == _packageInstallOptionsDefault
					? null
					: packageInstallOptions;
		}

		public override int Execute(PushPkgOptions options) {
			try {
				PackageInstallOptions packageInstallOptions = ExtractPackageInstallOptions(options);
				bool success = _packageInstaller.Install(options.Name, packageInstallOptions, options.ReportPath);
				Console.WriteLine(success ? "Done" : "Error");
				return success ? 0 : 1;
			} catch (Exception e) {
				Console.WriteLine(e.StackTrace);
				return 1;
			}
		}
	}
}
