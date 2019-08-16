
pipeline {
	agent any 
	
	
	parameters{
		string(name: 'BUILD_PATH',defaultValue: 'MyAPI.sol',description:'testing')
		string(name: 'IMAGE_NAME',defaultValue: 'myapiimage',description:'testing')
	}

	
    stages {
        stage('Build') {
            steps {
		    powershell(script: 'dotnet build ${env:BUILD_PATH}.sln')
            powershell(script: "echo Building........")
            }
        }
	stage('Test') {
            steps {
                powershell(script: 'dotnet test')
                powershell(script: "echo Testing.......")
            }
        }
	stage('Publish') {
            steps {
                powershell(script: 'dotnet publish')
                powershell(script: "echo Testing..........")
            }
        }
        stage('zip'){
            steps{
                powershell(script: "archiveArtifacts artifacts: '${env:BUILD_PATH}/bin/Debug/netcoreapp2.2/publish/*.*', fingerprint: true")
            }
        }
        stage('Build Docker')
        {
            steps{
                powershell(script: 'docker build -t ${env:IMAGE_NAME} ./MyAPI')
            }
        }
	
    }
    
}
