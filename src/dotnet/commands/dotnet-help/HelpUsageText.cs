﻿using Microsoft.DotNet.Tools;
using Microsoft.DotNet.Tools.Help;

internal static class HelpUsageText
{
    public static readonly string UsageText =
$@"{LocalizableStrings.Usage}: dotnet [runtime-options] [path-to-application] [arguments]

{LocalizableStrings.ExecutionUsageDescription}

runtime-options:
  --additionalprobingpath <path>         {LocalizableStrings.AdditionalprobingpathDefinition}
  --additional-deps <path>               {LocalizableStrings.AdditionalDeps}
  --fx-version <version>                 {LocalizableStrings.FxVersionDefinition}
  --roll-forward-on-no-candidate-fx <n>  {LocalizableStrings.RollForwardOnNoCandidateFxDefinition}

path-to-application:
  {LocalizableStrings.PathToApplicationDefinition}

{LocalizableStrings.Usage}: dotnet [sdk-options] [command] [command-options] [arguments]

{LocalizableStrings.SDKCommandUsageDescription}

sdk-options:
  -d|--diagnostics  {LocalizableStrings.SDKDiagnosticsCommandDefinition}
  -h|--help         {LocalizableStrings.HelpDefinition}
  --info            {LocalizableStrings.SDKInfoCommandDefinition}
  --list-runtimes   {LocalizableStrings.SDKListRuntimesCommandDefinition}
  --list-sdks       {LocalizableStrings.SDKListSdksCommandDefinition}
  --version         {LocalizableStrings.SDKVersionCommandDefinition}

{LocalizableStrings.Commands}:
  add               {LocalizableStrings.AddDefinition}
  build             {LocalizableStrings.BuildDefinition}
  build-server      {LocalizableStrings.BuildServerDefinition}
  clean             {LocalizableStrings.CleanDefinition}
  help              {LocalizableStrings.HelpDefinition}
  list              {LocalizableStrings.ListDefinition}
  migrate           {LocalizableStrings.MigrateDefinition}
  msbuild           {LocalizableStrings.MsBuildDefinition}
  new               {LocalizableStrings.NewDefinition}
  nuget             {LocalizableStrings.NugetDefinition}
  pack              {LocalizableStrings.PackDefinition}
  publish           {LocalizableStrings.PublishDefinition}
  remove            {LocalizableStrings.RemoveDefinition}
  restore           {LocalizableStrings.RestoreDefinition}
  run               {LocalizableStrings.RunDefinition}
  sln               {LocalizableStrings.SlnDefinition}
  store             {LocalizableStrings.StoreDefinition}
  test              {LocalizableStrings.TestDefinition}
  tool              {LocalizableStrings.ToolDefinition}
  vstest            {LocalizableStrings.VsTestDefinition}

{LocalizableStrings.AdditionalTools}
  dev-certs         {LocalizableStrings.DevCertsDefinition}
  ef                {LocalizableStrings.EfDefinition}
  sql-cache         {LocalizableStrings.SqlCacheDefinition}
  user-secrets      {LocalizableStrings.UserSecretsDefinition}
  watch             {LocalizableStrings.WatchDefinition}

{LocalizableStrings.RunDotnetCommandHelpForMore}";
}
