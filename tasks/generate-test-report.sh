echo "Generating code coverage..."
dotnet test ../src/Maduro.Catalog.sln /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=../../TestResults/ /p:Exclude="[xunit.*]*"

echo "Generating report.."
reportgenerator -reports:../TestResults/coverage.cobertura.xml -targetdir:../TestResults/Reports -reporttypes:HtmlInline_AzurePipelines -assemblyFilters:-xunit*.*