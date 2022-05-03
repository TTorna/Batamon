# Batamon

### Descripción del problema

Agustín todavía recuerda con muchocariño el primer problema que le tocó enfrentar al participar en su primer cer- tamen de la OIA hace muchísimos años. El problema era (de acuerdo a lo que recuerda Agustín) el siguiente: En un videojuego que va a salir a la venta pronto, llamado Batamon (Nombre obtenido al mezclar las palabras “batalla” y “monstruos”), la protagonista comanda un ejército de N monstruos, que deberán luchar contra los N monstruos del rival. Estas batallas se reducen a una serie de N enfrentamientos de tipo “uno contra uno”, en los que uno de los monstruos de la protagonista lucha contra uno de los monstruos del rival. Hay así N enfrentamientos, y cada monstruo participa en exactamente uno de estos enfrentamientos. Además, todos los monstruos tienen un cierto nivel de poder, que en el juego se indica con un entero positivo.

La protagonista es una hechicera guerrera de máximo nivel y probada experiencia, por lo que tiene la ventaja de poder elegir cómo se conformarán los N enfrentamientos para tratar de torcer el resultado de la batalla a su favor. En cada enfrentamiento, gana el monstruo con mayor nivel de poder. En caso de empate, gana el monstruo comandado por la hechicera, ya que mediante la ayuda de su magia termina de definir el enfrentamiento en tal caso.

Se te pide que escribas una función que, dados los niveles de poder de los monstruos comandados por la hechicera y por su rival, calcule cuál es la máxima cantidad de enfrentamientos que ella puede ganar, si los conforma de la mejor manera posible. Además, la función debe calcular estos enfrentamientos.



### Detalles de implementación

Debes implementar la función batamon(hechicera,rival,enfrentamientos), que dados los arreglos hechicera y rival con los niveles de poder de los monstruos comandados por la hechicera y por su rival, respectivamente; retorne la cantidad máxima de enfrentamientos que la hechicera puede ganar. Además, la función debe almacenar en el arreglo enfrentamientos un listado con los mons- truos que se deben utilizar para enfrentar a cada monstruo rival. El monstruo de la hechicera en la posición indicada por el primer elemento de enfrentamientos luchará con el primer monstruo del rival, el segundo con el segundo, y así siguiendo. En caso de haber más de una asignación que resulte en la máxima cantidad posible de enfrentas ganadas, cualquiera de ellas es válida.

### Evaluador local

El evaluador local lee de la entrada estándar (H y R se indican en la sección “Cotas” y en la sección “Subtareas”):

Una primera línea con un entero N: la cantidad de monstruos en cada bando. Una segunda línea con N enteros positivos, todos menores o iguales que H, que indican los niveles de po- der de los monstruos de la hechicera. Una tercera línea con N enteros positivos, todos menores o iguales que R, que indican los niveles de poder de los monstruos del rival.

Devuelve por la salida estándar el resul- tado de llamar a la función batamon, y un listado de los enfrenamientos calculados en el parámetro enfrentamientos

### Cotas

- 1 ≤ N ≤ 200.000
- H, R ≤ 1.000.000
