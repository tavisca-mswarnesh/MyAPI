
pipeline {
	agent any 
	
	
	parameters{
		string(name: 'BUILD_PATH',defaultValue: 'MyAPI.sol',description:'testing')
		string(name: 'IMAGE_NAME',defaultValue: 'myapiimage',description:'testing')
	}

	
    stages {
        stage('Build') {
            steps {
		    powershell(script: 'dotnet build ')
            powershell(echo "Building........")
            }
        }
	stage('Test') {
            steps {
                powershell(script: 'dotnet test')
                powershell(echo "Testing.......")
            }
        }
	stage('Publish') {
            steps {
                powershell(script: 'dotnet publish')
                powershell(echo "Testing..........")
            }
        }
	
    }
    post {
        success{
	   archiveArtifacts artifacts: '**', fingerprint: true
	   powershell(script: 'docker run -p 7100:80 %IMAGE_NAME% .')
	}
    }
}
