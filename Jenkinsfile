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
        bat 'dotnet test DDD.Sandbox\\DDD.Application.Tests\\DDD.Application.Tests.csproj DDD.Application.Tests.xml'
        bat 'dotnet test DDD.Sandbox\\DDD.Domain.Tests\\DDD.Domain.Tests.csproj DDD.Domain.Tests.xml'
        bat 'dotnet test DDD.Sandbox\\DDD.WebApp.Tests\\DDD.WebApp.Tests.csproj DDD.WebApp.Tests.xml'
        bat 'dotnet test DDD.Sandbox\\DDD.NunitTests\\DDD.NunitTests.csproj DDD.NunitTests.xml'
      }
    }
  }
  post {
    always {
      junit 'build/reports/**/*.xml'
      
    }
    
  }
}