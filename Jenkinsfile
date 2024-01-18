pipeline { 
    agent any
    stages { 
        stage('Checkout') {
          steps {
            script {
                checkout([$class: 'GitSCM', branches: [[name: '*/main']], userRemoteConfigs: [[url: 'https://github.com/yingbinshan/HelloWorldNet2.git']]])
            }
          }
        }
        stage('Build') { 
            steps { 
                echo 'Building..' 
            } 
        }
        stage('Test') { 
            steps { 
                echo 'Testing..' 
            } 
        } 
        stage('Deploy') { 
            steps { 
                echo 'Deploying....' 
                echo 'aaa....' 
            } 
        } 
    }
}