pipeline {
agent any
stages {
stage('Checkout') {
steps {
git branch: 'main', url: 'https://github.com/alaabenhmida/tp3-ci-tests.git'
}
}
stage('Run .NET tests') {
steps {
dir('dotnet-app') {
bat 'dotnet test'
}
}
}
stage('Run Python tests') {
steps {
dir('python-app') {
bat 'python -m unittest'
}
}
}
}
post {
always {
echo 'Pipeline finished !!!'
}
}
}
