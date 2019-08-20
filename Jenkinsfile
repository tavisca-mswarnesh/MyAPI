
pipeline {
	agent any 
	
	
	parameters{
		string(name: 'BUILD_PATH',defaultValue: 'MyAPI.sol',description:'enter solution name')
		string(name: 'IMAGE_NAME',defaultValue: 'myapiimage',description:'enter image name')
        	string(name: 'USER_NAME',defaultValue: 'Enter dockerhub user name',description:'Enter dockerhub user name')
        	password(name: 'PASSWORD',defaultValue: 'enter dockerhub Password',description:'enter dockerhub Password')
        	string(name: 'TAG_NAME',defaultValue: 'Enter tag  name',description:'Enter tag  name')
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
   /* stage('SonarQube analysis') {
        steps{
                powershell(script: 'dotnet C:/Users/vmattapalli/Downloads/sonar-scanner-msbuild-4.6.2.2108-netcoreapp2.0/SonarScanner.MSBuild.dll begin /k:"Testing"')
                powershell(script: 'dotnet build ${env:BUILD_PATH}.sln')
                powershell(script: 'dotnet C:/Users/vmattapalli/Downloads/sonar-scanner-msbuild-4.6.2.2108-netcoreapp2.0/SonarScanner.MSBuild.dll end')
        }
    }*/
	stage('Publish') {
            steps {
                powershell(script: 'dotnet publish -c Release -o ../publish')
                powershell(script: "echo Testing..........")
            }
        }
        stage('zip'){
            steps{
                archiveArtifacts artifacts: 'publish/*.*', fingerprint: true
            }
        }
        stage('Build Docker')
        {
            steps{
                powershell(script: 'docker build -t ${env:IMAGE_NAME} ./MyAPI')
            }
        }
        stage('Login'){
            steps{
                powershell(script: 'docker login -u ${env:USER_NAME} -p ${env:PASSWORD}');
            }
        }
        stage('Tagging image'){
            steps{
                powershell(script: 'docker tag ${env:IMAGE_NAME}:latest mattapalliswarnesh/my_api:${env:TAG_NAME}')
            }
        }
        stage('Pushing Image'){
            steps{
                powershell(script: 'docker push mattapalliswarnesh/my_api:${env:TAG_NAME}')
            }
        }
	
    }
    
}
