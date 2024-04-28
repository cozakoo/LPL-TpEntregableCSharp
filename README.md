
# Sistema de Registro de Vacunación Covid en C#

Ante la continuidad de la pandemia del Covid-19 y la necesidad de registrar el proceso de vacunación, hemos desarrollado un sistema en C# que permite gestionar la información relacionada con la vacunación contra el virus.

## Objetivo
El objetivo principal del sistema es mantener un registro completo y organizado de las personas vacunadas, así como también de las vacunas administradas, los centros de atención, los enfermeros y los turnos de vacunación disponibles.

## Funcionalidades
- Registro y actualización de información de personas vacunadas.
- Verificación de si una persona ya ha sido vacunada.
- Gestión de turnos de vacunación para personas.
- Validación de la información ingresada para garantizar la integridad de los datos.
- Generación de listados y estadísticas del proceso de vacunación.

## Restricciones y Reglas de Negocio
- Cada centro de atención solo permitirá un máximo de 72 personas vacunadas por día, de lunes a sábado.
- El horario de atención es de 8:00 a.m. a 4:00 p.m., con un espacio de 20 minutos entre cada paciente.
- Se dispone de 3 enfermeros por centro de atención.
- Los turnos de vacunación están disponibles cada 20 minutos y son distribuidos entre los tres enfermeros.

## Horario de Turnos
|Enfermero |Lunes	|Martes	|Miércoles	|Jueves	|Viernes	|Sábado
|----------|--------|-------|-----------|-------|-----------|------|
|Enfermero1|8:00, 8:20	|
|Enfermero2|        |8:00, 8:20				
Enfermero3 |		|           | 8:00, 8:20			

## Requisitos de Validación
- Los datos ingresados deben ser completos y válidos.
- Se deben validar datos numéricos y de fecha.
- No se pueden asignar turnos de vacunación si no hay disponibilidad de espacio.
- No se puede asignar más de un turno a la misma persona a menos que la vacuna admita múltiples dosis.

## Listados y Estadísticas
Una vez registrado un gran número de personas vacunadas, turnos, vacunas, enfermeros y centros de atención, el sistema proporcionará una serie de listados y estadísticas para evaluar el proceso de vacunación.

¡Estamos comprometidos con la seguridad y el bienestar de la población y esperamos que este sistema contribuya al eficiente desarrollo del proceso de vacunación contra el Covid-19!