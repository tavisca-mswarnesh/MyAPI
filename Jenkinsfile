
pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                sh 'dotnet build MyAPI.sln'
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
    
	
}
