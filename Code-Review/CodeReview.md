Code Review:
    -Codigo duplicado: Los 3 codigos proporcionados contienen funciones duplicadas.
        -Consejo: eliminar el codigo duplicado o reutilizar la logica en un metodo /helper 
    
    -Seguridad: En todas las consultas se agrega directamente una variable a la query, esto genera una vulnerabilidad que permite inyectar codigo sql que vulnera
    la integridad de la base de datos.
        -Consejo: Usar parametros SQL para prevenir la inyeccion de codigo malicioso
    -Segurdad

    -Manejo de errores: No existe un tratamiento adecuado a las excepciones que se pudieran presentar.
        -Consejo: considerar crear un log para guardar los registros de los errores, ademas de retornar una respuesta de error en dado caso.
            ademas podemos agregar declaraciones try/catch para el manejo de los mismos

    -Respuesta del servicio: En la respuesta del servicio se esta retornando todo en un solo string, eso dificulta el manejo de la informacion, ademas 
        que no es eficiente manejar de esa manera la informacion.
        -Consejo: manejar la respuesta como una lsita que permite un mejor manejo de los resultados obtenidos.

    -Manejo de recursos: No se utiliza la declaracion using, esto se usa para cerrar el bloque de Codigo
    y liberar el recurso de una forma segura incluso si ocurren excepciones.
        -Consejo: encerrar el codigo en la declaracion using de la siguiente manera:
            public string GetUserData(int userId)
                {
                    using ( SqlConnection conn = new SqlConnection("Server=myServer;Database=myDB;User Id=myUser;Password=myPass;")) {
                        conn.Open();
                        ...codigo
                        return result;
                    }
                    return string.Empty;                    
                } 
    -Credenciales hardcodeadas: Esto provoca que se puedan filtrar las credenciales a la base de datos y de ponga en peligro la integridad o al 
        momento de dar mantenimiento al codigo es ineficiente ya que puede generar bastantes problemas al actualizar la base de datos
        -Consejo:  utilizar una configuracion externa que no exponga directamente las credenciales como puede ser appsettings.json
    -Posibles mejoras: Implementar un ORM para mejorar la comunicacion con las base de datos y creasr peticiones mas sencillas   