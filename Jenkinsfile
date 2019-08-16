
pipeline {
	agent any 
	
	
	parameters{[string(name: 'BUILD_PATH',default: 'MyAPI.sol',description:'testing' )]}

	
    stages {
        stage('Build') {
            steps {
		    bat 'dotnet build ${params.BUILD_PATH} -p:configuration=release -v:n'
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
	   bat 'dotnet MyAPI/bin/Debug/netcoreapp2.2/MyAPI.dll'
	}
    }
}
