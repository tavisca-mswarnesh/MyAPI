
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
                archiveArtifacts artifacts: 'MyAPI/bin/Debug/netcoreapp2.2/publish/*.*', fingerprint: true
            }
        }
	
    }
    post {
        success{
	   
	   
            powershell(script: 'docker build -t image123 .')
	}
    }
}
