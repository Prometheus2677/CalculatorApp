dotnet add CalculatorApp.Tests package coverlet.collector

dotnet tool install --global dotnet-reportgenerator-globaltool


rm -rf CalculatorApp.Tests/TestResults
dotnet test --collect:"XPlat Code Coverage"
reportgenerator -reports:"CalculatorApp.Tests/TestResults/**/coverage.cobertura.xml" -targetdir:coveragereport -reporttypes:Html
