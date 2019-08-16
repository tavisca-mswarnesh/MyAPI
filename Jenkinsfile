
pipeline {
	agent any 
	
	
	parameters{
		string(name: 'BUILD_PATH',defaultValue: 'MyAPI.sol',description:'testing')
		string(name: 'IMAGE_NAME',defaultValue: 'myapiimage',description:'testing')
	}

	
    stages {
        stage('Build') {
            steps {
		    poweshell(script: 'dotnet build ')
            poweshell(echo "Building........")
            }
        }
	stage('Test') {
            steps {
                poweshell(script: 'dotnet test')
                poweshell(echo "Testing.......")
            }
        }
	stage('Publish') {
            steps {
                poweshell(script: 'dotnet publish')
                poweshell(echo "Testing..........")
            }
        }
	
    }
    post {
        success{
	   archiveArtifacts artifacts: '**', fingerprint: true
	   poweshell(script: 'docker run -p 7100:80 %IMAGE_NAME% .')
	}
    }
}
