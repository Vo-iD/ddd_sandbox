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
        bat 'dotnet test DDD.Sandbox\\DDD.Application.Tests\\DDD.Application.Tests.csproj --logger trx;LogFileName=results\unit_tests.xml'
        bat 'dotnet test DDD.Sandbox\\DDD.Domain.Tests\\DDD.Domain.Tests.csproj --logger trx;LogFileName=results\unit_tests.xml'
        bat 'dotnet test DDD.Sandbox\\DDD.WebApp.Tests\\DDD.WebApp.Tests.csproj --logger trx;LogFileName=results\unit_tests.xml'
        bat 'dotnet test DDD.Sandbox\\DDD.NunitTests\\DDD.NunitTests.csproj --logger trx;LogFileName=results\unit_tests.xml'
      }
    }
  }
}