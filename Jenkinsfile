/**
 * Pipeline declarativo para ProyectoPOE (Basado en .NET)
 */
pipeline {
    // Se ejecuta en cualquier agente disponible (asegúrate de que tenga dotnet instalado)
    agent any 

    // Definición de variables de entorno
    environment {
        // Define la carpeta que contiene el archivo .csproj, que es el subdirectorio 'ProyectoPoe'
        PROJECT_FOLDER = 'ProyectoPOE' 
    }

    stages {
        stage('Declarative: Checkout SCM') {
            steps {
                echo 'Clonando el repositorio...'
                // El checkout se realiza automáticamente
                checkout scm
            }
        }

        stage('Workspace Cleanup') {
            steps {
                echo 'Limpiando el workspace antes de continuar...'
                cleanWs()
            }
        }

        stage('Build') {
            steps {
                echo 'Compilando el proyecto...'
                
                // 🛠️ CORRECCIÓN CLAVE: 
                // Cambia el directorio de trabajo a la carpeta del proyecto.
                // Esto asegura que 'dotnet build' se ejecute DENTRO de ProyectoPoe/.
                dir("${env.PROJECT_FOLDER}") {
                    // Ahora, el archivo de proyecto se busca en el directorio actual (ProyectoPoe/)
                    // El comando final ejecutado es: dotnet build ProyectoPoe.csproj
                    bat 'dotnet build ProyectoPOE.csproj' 
                }
            }
        }

        stage('Test') {
            steps {
                echo 'Ejecutando pruebas...'
                // Aquí deberías colocar el comando para correr pruebas unitarias, si tienes un proyecto de pruebas.
                // Ejemplo: dir("${env.PROJECT_FOLDER}") { bat 'dotnet test ProyectoPoe.csproj' }
                echo 'Paso de Test pendiente de configuración.'
            }
        }

        stage('Deploy') {
            steps {
                echo 'Preparando la publicación...'
                // Genera los archivos listos para desplegar
                dir("${env.PROJECT_FOLDER}") {
                    bat 'dotnet publish ProyectoPOE.csproj -c Release -o ..\\publish'
                }
                echo 'Paso de Deploy pendiente de implementación.'
            }
        }
    }

    // Acciones a realizar al finalizar, sin importar el resultado
    post {
        always {
            echo 'Pipeline finalizado.'
        }
        success {
            echo '✅ La compilación y los pasos fueron exitosos.'
        }
        failure {
            echo '❌ Algo falló en el pipeline. Revisa los logs.'
        }
    }
}