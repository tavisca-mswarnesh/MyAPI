
pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                sh 'dotnet build MyAPI.sln -p:configuration=release -v:n'
                echo "Building......."
            }
        }
	stage('Test') {
            steps {
                sh 'dotnet test'
                echo "Testing.........."
            }
        }
	stage('Publish') {
            steps {
                sh 'dotnet publish'
                echo "Testing.........."
            }
        }
	
    }
    post {
        success{
	   archiveArtifacts artifacts: '**', fingerprint: true
	   sh 'dotnet MyAPI/bin/Debug/netcoreapp2.2/MyAPI.dll'
		
            
        }
    }
	
}