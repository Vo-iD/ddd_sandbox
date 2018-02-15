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
        bat 'dotnet test DDD.Sandbox\\DDD.Application.Tests\\DDD.Application.Tests.csproj /xml=DDD.Application.Tests.xml'
        bat 'dotnet test DDD.Sandbox\\DDD.Domain.Tests\\DDD.Domain.Tests.csproj /xml=DDD.Domain.Tests.xml'
        bat 'dotnet test DDD.Sandbox\\DDD.WebApp.Tests\\DDD.WebApp.Tests.csproj /xml=DDD.WebApp.Tests.xml'
        bat 'dotnet test DDD.Sandbox\\DDD.NunitTests\\DDD.NunitTests.csproj /xml=DDD.NunitTests.xml'
      }
    }
  }
  post {
    always {
      junit 'build/reports/**/*.xml'
      
    }
    
  }
}