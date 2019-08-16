
pipeline {
	agent any 
	
	
	parameters{string(name: 'BUILD_PATH',defaultValue: 'MyAPI.sol',description:'testing')}

	
    stages {
        stage('Build') {
            steps {
		    bat 'dotnet build '
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
	   bat 'docker run -p 5000:80 myapiimage .'
	}
    }
}
