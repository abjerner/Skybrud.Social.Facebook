@echo off
dotnet build src/Skybrud.Social.Facebook --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:/nuget