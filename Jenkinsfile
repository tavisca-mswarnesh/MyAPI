
pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                bat 'dotnet build MyAPI.sln'
                echo "Building......."
            }
        }
    }
    
	
}
