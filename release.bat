@echo off
dotnet build src/Skybrud.Social.Facebook --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget