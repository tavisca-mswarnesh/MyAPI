
pipeline {
	agent any 
	
	
	parameters{
		string(name: 'SOL_NAME',defaultValue: 'MyAPI',description:'MyAPI')
		string(name: 'IMAGE_NAME',defaultValue: 'myapiimage',description:'enter image name')
        	string(name: 'USER_NAME',defaultValue: 'mattapalliswarnesh',description:'Enter dockerhub user name')
        	password(name: 'PASSWORD',defaultValue: 'Swadhan@9702',description:'enter dockerhub Password')
        	string(name: 'TAG_NAME',defaultValue: 'Tag4',description:'Enter tag  name')
        	string(name: 'REPOSITORY_NAME',defaultValue: 'my_api',description:'Enter dockerhub repository name')
		string(name: 'PORT',defaultValue: '1234',description:'Enter port  number')
	}

	
    stages {
        stage('Build') {
            steps {
		    powershell(script: 'dotnet build ${env:SOL_NAME}.sln')
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
                powershell(script: 'dotnet build ${env:SOL_NAME}.sln')
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
                powershell(script: 'docker tag ${env:IMAGE_NAME}:latest ${env:USER_NAME}/${env:REPOSITORY_NAME}:${env:TAG_NAME}')
            }
        }
        stage('Pushing Image'){
            steps{
                powershell(script: 'docker push ${env:USER_NAME}/${env:REPOSITORY_NAME}:${env:TAG_NAME}')
            }
        }
	stage('Pull') {
            steps {
		    powershell(script: 'docker pull ${env:USER_NAME}/${env:REPOSITORY_NAME}:${env:TAG_NAME}')
            	     powershell(script: "echo pulling........")
            }
        }
	stage('Run') {
            steps {
                powershell(script: 'docker run -p ${env:PORT}:80 ${env:USER_NAME}/${env:REPOSITORY_NAME}:${env:TAG_NAME}')
                powershell(script: "echo Running.......")
            }
        }    
	
    }
    
}
