## Pseudocódigo de los requisitos de sistema más importantes (Requisitos funcionales mandatorios)


RF-04 – CRUD de Sesiones


    funcion_moduloSesiones()
        MOSTRAR "1. Crear sesión"
        MOSTRAR "2. Ver sesiones"
        MOSTRAR "3. Editar sesión"
        MOSTRAR "4. Eliminar sesión"

        LEER opcion
        SEGÚN opcion HACER
        CASO 1: crearSesion()
        CASO 2: listarSesiones()
        CASO 3: editarSesion()
            CASO 4: eliminarSesion()
            OTRO: MOSTRAR "Opción no válida"
        FINSEGÚN
    fin

RF-06 – Registrar Asistencia por Sesión


    funcion_registrarAsistencia()
        MOSTRAR "Ingrese ID de sesión:"
        LEER idSesion
        listaEstudiantes = obtenerEstudiantesPorSesion(idSesion)
    
        PARA cada estudiante EN listaEstudiantes
            MOSTRAR "Asistencia de ", estudiante.nombre, " (P/A):"
            LEER estado
            guardarAsistencia(idSesion, estudiante.id, estado)
        FIN PARA

        MOSTRAR "Asistencia registrada correctamente."
    fin

RF-10 – Calcular Nivel C/B/A


    funcion_calcularNivel(estudiante)

        totalChecks = contarChecks(estudiante)
        checksCorrectos = contarChecksPositivos(estudiante)
        porcentaje = (checksCorrectos / totalChecks) * 100
    
        SI porcentaje >= 90 entonces nivel = "A"
        SINO SI porcentaje >= 70 entonces nivel = "B"
           SINO nivel = "C"

        guardarNivel(estudiante, nivel)
    finfuncion
    SINO nivel = "C"
    fin

    guardarNivel(estudiante, nivel)
fin
