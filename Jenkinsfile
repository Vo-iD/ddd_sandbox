pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        bat 'dotnet restore DDD.Sandbox'
        bat 'dotnet build DDD.Sandbox'
      }
    }
    stage('Test') {
      steps {
        bat 'dotnet test DDD.Sandbox\\DDD.Application.Tests\\DDD.Application.Tests.csproj -r TestResults'
        bat 'dotnet test DDD.Sandbox\\DDD.Domain.Tests\\DDD.Domain.Tests.csproj -r TestResults'
        bat 'dotnet test DDD.Sandbox\\DDD.WebApp.Tests\\DDD.WebApp.Tests.csproj -r TestResults'
        bat 'dotnet test DDD.Sandbox\\DDD.NunitTests\\DDD.NunitTests.csproj -r TestResults'
      }
    }
  }
}