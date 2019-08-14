
pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                bat 'dotnet build MyAPI.sln -p:configuration=release -v:n'
                echo "Building......."
            }
        }
	stage('Test') {
            steps {
                bat 'dotnet test'
                echo "Testing.........."
            }
        }
	stage('Publish') {
            steps {
                bat 'dotnet publish'
                echo "Testing.........."
            }
        }
	
    }
    post {
        success{
	   archiveArtifacts artifacts: '**', fingerprint: true
	   bat 'dotnet MyAPI/bin/Debug/netcoreapp2.2/MyAPI.dll'
	}
    }
}
