create database proyectofinal;
use proyectofinal;

CREATE TABLE carta (
idCarta int (4) PRIMARY KEY,
nombreCarta varchar (50),
descripcionCarta varchar (70),
numeroMana int (2),
tipo int (2),
daño int (2),
curacion int (2),
cartaTemporal boolean,
precio int (6)
);

CREATE TABLE mazos (
idMazo int(2),
idCarta int(4),
cantidadCarta int(2),
foreign key (idCarta) references carta(idCarta),
primary key (idMazo, idCarta)
);

CREATE TABLE enemigo (
idEnemigo int(2) PRIMARY KEY,
nombre varchar (40),
vida int (2),
numeroMana int (2),
idMazo int (2),
foreign key (idMazo) references mazos(idMazo)
);

CREATE TABLE datosEnciclopedia (
id int (4) PRIMARY KEY,
nombre varchar (40),
etimologia varchar (250),
comportamiento varchar (400)
);

/* Cartas de tipo: 1.Daño, 2.Curacion, 3.Robar, 4.RoboVida, 5.Criatura */
insert into carta values (1, 'Quemar', 'Hace 5 puntos de daño', 5, 1, 5, 0, false, 0);
insert into carta values (2, 'Golpe', 'Hace 3 puntos de daño', 2, 1, 3, 0, false, 0);
insert into carta values (3, 'Curar', 'Cura 3 de vida', 2, 2, 0, 3, false, 0);
insert into carta values (4, 'Maldición', 'Roba 2 cartas aleatorias al enemigo', 2, 3, 0, 2, false, 0);
insert into carta values (5, 'Disparo certero', 'Hace 4 puntos de daño', 4, 1, 4, 0, false, 0);
insert into carta values (6, 'Cura superior', 'Cura 5 de vida', 4, 2, 0, 5, true, 0);
insert into carta values (7, 'Ayuda', 'Roba 2 cartas de tu mazo', 2, 3, 2, 0, false, 0);
insert into carta values (8, 'Ventisca', 'Hace 7 puntos de daño', 6, 1, 7, 0, false, 0);
insert into carta values (9, 'Mordisco', 'Hace 6 puntos de daño', 6, 1, 6, 0, false, 0);
insert into carta values (10, 'Succión', 'Roba 3 de vida al enemigo', 3, 4, 3, 3, false, 0);
insert into carta values (11, 'Pillaje', 'Roba 1 carta aleatoria al enemigo', 1, 3, 0, 1, false, 0);
insert into carta values (12, 'Chupasangre', 'Roba 5 de vida al enemigo', 6, 4, 5, 5, true, 0);
insert into carta values (13, 'Estallido', 'Hace 8 puntos de daño', 7, 1, 8, 0, true, 80);
insert into carta values (14, 'Cura máxima', 'Cura 7 de vida', 6, 2, 0, 7, true, 80);
insert into carta values (15, 'Asalto', 'Roba 3 cartas aleatorias al enemigo', 5, 3, 0, 3, true, 60);
insert into carta values (16,'Infeccion', 'Roba 7 de vida al enemigo', 7, 4, 7, 7, true, 80);
insert into carta values (17,'Picadura', 'Roba 2 de vida al enemigo', 3, 4, 2, 2, false, 0);
insert into carta values (18,'Fuerza sobrenatural', 'Hace 9 puntos de daño', 8, 1, 9, 0, true, 0);
insert into carta values (19, 'Ayuda extra', 'Roba 3 cartas de tu mazo', 4, 3, 3, 0, true, 0);
insert into carta values (20, 'Ataque basico', 'Hace 2 puntos de daño', 1, 1, 2, 0, false, 0);
insert into carta values (21, 'Golpe fantasmal', 'Hace 1 punto de daño', 0, 1, 1, 0, false, 0);
insert into carta values (22, 'Aris, el zorro-dragon', 'Roba 1 carta del mazo enemigo y cura 3 puntos de daño', 5, 5, 1, 3, false, 0);
insert into carta values (23, 'Aris, el principe', 'Roba 2 cartas del mazo enemigo y cura 5 puntos de daño', 7, 5, 2, 5, false, 0);
insert into carta values (24, 'Aris, el resurgido', 'Roba 3 cartas del mazo enemigo y cura 7 puntos de daño', 9, 5, 3, 7, false, 0);
insert into carta values (25, 'Phyri, la emplumada ', 'Roba 1 carta de tu mazo y aplica 3 puntos de robo de vida al enemigo', 5, 5, 3, 3, false, 0);
insert into carta values (26, 'Phyri, la hechicera', 'Roba 2 cartas de tu mazo y aplica 5 puntos de robo de vida', 7, 5, 5, 5, false, 0);
insert into carta values (27, 'Phyri, la vigilante de los cristales', 'Roba 3 cartas de tu mazo y aplica 7 puntos de robo de vida', 9, 5, 7, 7, false, 0);
insert into carta values (28, 'Jackal, el astuto', 'Roba 1 carta de daño del mazo y hace 3 puntos de daño', 5, 5, 3, 0, false, 0);
insert into carta values (29, 'Jackal, el guerrero', 'Roba 2 cartas de daño del mazo y hace 5 puntos de daño',7 , 5, 5, 0, false, 0);
insert into carta values (30, 'Jackal, el protector de las dunas', 'Roba 3 cartas de daño del mazo y hace 7 puntos de daño', 9, 5, 7, 0, false, 0);

/* Mazo 1 */
insert into mazos values (1,1,1);
insert into mazos values (1,3,3);
insert into mazos values (1,5,1);
insert into mazos values (1,6,1);
insert into mazos values (1,7,2);
insert into mazos values (1,11,1);
insert into mazos values (1,17,2);
insert into mazos values (1,20,4);
insert into mazos values (1,21,3);

/* Mazo 2 */
insert into mazos values (2,2,2);
insert into mazos values (2,3,3);
insert into mazos values (2,4,2);
insert into mazos values (2,5,2);
insert into mazos values (2,6,2);
insert into mazos values (2,7,3);
insert into mazos values (2,8,2);
insert into mazos values (2,9,2);
insert into mazos values (2,13,1);
insert into mazos values (2,14,1);
insert into mazos values (2,15,1);
insert into mazos values (2,20,1);

/* Mazo 3 */
insert into mazos values (3,1,2);
insert into mazos values (3,2,2);
insert into mazos values (3,5,2);
insert into mazos values (3,7,2);
insert into mazos values (3,17,1);
insert into mazos values (3,18,1);
insert into mazos values (3,20,4);
insert into mazos values (3,21,4);

/* Mazo 4 */
insert into mazos values (4,1,2);
insert into mazos values (4,2,3);
insert into mazos values (4,3,1);
insert into mazos values (4,4,2);
insert into mazos values (4,5,2);
insert into mazos values (4,6,1);
insert into mazos values (4,7,2);
insert into mazos values (4,13,2);
insert into mazos values (4,15,2);
insert into mazos values (4,17,3);
insert into mazos values (4,18,1);
insert into mazos values (4,20,3);
insert into mazos values (4,21,2);

/* Mazo 5 */
insert into mazos values (5,2,2);
insert into mazos values (5,3,2);
insert into mazos values (5,4,2);
insert into mazos values (5,7,3);
insert into mazos values (5,10,2);
insert into mazos values (5,11,2);
insert into mazos values (5,18,1);
insert into mazos values (5,20,3);
insert into mazos values (5,21,1);

/* Mazo 6 */
insert into mazos values (6,2,2);
insert into mazos values (6,3,1);
insert into mazos values (6,4,1);
insert into mazos values (6,5,2);
insert into mazos values (6,7,1);
insert into mazos values (6,8,1);
insert into mazos values (6,9,2);
insert into mazos values (6,10,2);
insert into mazos values (6,11,2);
insert into mazos values (6,17,1);
insert into mazos values (6,19,2);
insert into mazos values (6,20,2);
insert into mazos values (6,21,3);

/* Mazo 7 */
insert into mazos values (7,3,2);
insert into mazos values (7,4,3);
insert into mazos values (7,7,2);
insert into mazos values (7,11,2);
insert into mazos values (7,15,3);
insert into mazos values (7,17,2);
insert into mazos values (7,20,2);
insert into mazos values (7,21,2);

/* Mazo 8 */
insert into mazos values (8,1,1);
insert into mazos values (8,2,3);
insert into mazos values (8,4,1);
insert into mazos values (8,5,2);
insert into mazos values (8,7,2);
insert into mazos values (8,9,2);
insert into mazos values (8,10,2);
insert into mazos values (8,12,1);
insert into mazos values (8,13,1);
insert into mazos values (8,16,2);
insert into mazos values (8,17,1);
insert into mazos values (8,21,4);

/* Mazo 9 */
insert into mazos values (9,1,2);
insert into mazos values (9,2,1);
insert into mazos values (9,3,1);
insert into mazos values (9,5,1);
insert into mazos values (9,7,2);
insert into mazos values (9,9,2);
insert into mazos values (9,10,2);
insert into mazos values (9,11,3);
insert into mazos values (9,18,1);
insert into mazos values (9,20,3);

/* Mazo 10 */
insert into mazos values (10,2,2);
insert into mazos values (10,6,1);
insert into mazos values (10,8,1);
insert into mazos values (10,11,3);
insert into mazos values (10,13,2);
insert into mazos values (10,15,2);
insert into mazos values (10,18,3);
insert into mazos values (10,19,2);
insert into mazos values (10,20,3);
insert into mazos values (10,21,3);

insert into enemigo values (1, 'Verfor (forma contenida)', '30', '0', '1');
insert into enemigo values (2, 'Verfor, el slime envenenado', '35', '0', '2');
insert into enemigo values (3, 'Ironmorge (forma contenida)', '30', '0', '3');
insert into enemigo values (4, 'Ironmorge, la máquina viviente', '35', '0', '4');
insert into enemigo values (5, 'Blackwö (forma contenida)', '30', '0', '5');
insert into enemigo values (6, 'Blackwö, el vigilante del faro', '35', '0', '6');
insert into enemigo values (7, 'Bittersoul (forma contenida)', '30', '0', '7');
insert into enemigo values (8, 'Bittersoul, el alma errante', '35', '0', '8');
insert into enemigo values (9, 'Whiteburn (forma contenida)', '30', '0', '9');
insert into enemigo values (10, 'Whiteburn, el señor de la muerte', '35', '0', '10');

insert into datosEnciclopedia values (1, 'Aris, el resurgido.', 'Su nombre es una deformación de la palabra "air" en inglés. Su aspecto está basado en un zorro del desierto y en un dragón chino.', 'Cuando es pequeño nace con un gran 
cuerno, que, a medida que va creciendo, se le va rebajando. Esto hace que adquiera la capacidad de volar en su adultez, debido a que ya no tiene este peso. Es muy místico, 
sereno y noble.');
insert into datosEnciclopedia values (2, 'Phyri, la vigilante de los cristales.', 'Su nombre es una deformación de la palabra "pirita". Su aspecto está basado en un búho, con toques también 
de lechuza y en un pavo real.', 'Este animal tiene una extraña conexión con los minerales, en especial, con los cristales. Puede manipularlos y conseguir todo su poder. Es una criatura muy sabia.');
insert into datosEnciclopedia values (3, 'Jackal, el protector de las dunas.', 'Su nombre hace alusión a la criatura mitologica en la que se basa: El jackalope, un animal mítico del folclore norteamericano. Su aspecto
también está basado en esta criatura.', 'Esta criatura no es para nada tímida e inofensiva. Es muy orgulloso y no duda de usar su fuerza para 
defenderse a si mismo y a los más débiles. Su cornamenta va creciendo indefinidamente con los años y cada vez se vuelve más y más poderosa.');
insert into datosEnciclopedia values (4, 'Yellowblu, el guía.', 'Su nombre hace alusión a los colores que predominan en este: el amarillo y el azul. Está basado en la oveja de mar, una
babosa marina que vive en las profundidades.', 'Es una criatura pacifica y dormilona. A pesar de su aspecto es bastante inteligente. Tiene muchos depredadores naturales, pero gracias a los pinchos 
que posee en su espalda puede defenderse, ya que al tocar uno de estos produce una somnoliencia que puede durar varios dias.');
insert into datosEnciclopedia values (5,'Verfor, el slime envenenado.', 'Su nombre proviene de la palabra "Verformt", que en alemán
significa "deformado". Su aspecto se basa en un slime y en un kraken en su forma final.', 'Esta bestia cambió su biología por completo cuando
absorbió elementos quimicos de su hábitat. A pesar de su reducido tamaño es peligroso, ya que contamina todo allá por donde va. Su fisiología también se vió afectada y es capaz
de brillar en las noches más oscuras.');
insert into datosEnciclopedia values (6,'Ironmorge, la máquina viviente.', 'Su nombre significa literalmente en inglés "duelo de hierro". Su aspecto está basado en un elemental
y además, en los edificios de la conocida revolución industrial.', 'Esta criatura de colosal tamaño ama las peleas y no dudará en atacar si te acercas a su territorio. 
Su arma principal son sus puños, pero si se ve en peligro creará una nube de humo para confundir al enemigo.');
insert into datosEnciclopedia values (7,'Blackwö, el vigilante del faro.', 'Su nombre es una deformación de la palabra en inglés "blackwater", que
en español significa "agua negra". Su aspecto se basa en una gárgola.', 'Tiene una personalidad traviesa. Suele vivir cerca de las costas y se dedica a manipular y confundir 
a los marineros que quieren llegar al puerto. Algunas veces juega con la propia vida de estos, hundiendo los barcos sin compasión.');
insert into datosEnciclopedia values (8,'Bittersoul, el alma errante.', 'Su nombre viene de las palabras "bitter", que significa "lleno de odio" o "amargo" y la palabra "soul", que
significa "alma". Su aspecto está basado en dos criaturas mitológicas: El unicornio y el sleipnir en su forma final.', 'Esta criatura sufre una maldición que 
manipula su paladar. Todos los alimentos que consume se vuelven amargos e imposibles de digerir, por lo que sufre de anorexia extrema, aunque se volvieron resistentes a la maldición, con 
lo que nunca llegan a morir por ello. Es muy territorial y agresivo.');
insert into datosEnciclopedia values (9,'Whiteburn, el señor de la muerte.', 'Su nombre hace alusión al fogonazo de luz cuando una persona "ve al final del tunel". Significa 
"quemadura blanca" en inglés. Está basado en una mantícora.', 'Esta bestia es altamente peligrosa. Durante un tiempo se consideró una leyenda, aunque aun sigue existiendo, en lo mas profundo del bosque. Su melena es muy cotizada.');

select c.idCarta, c.nombreCarta, c.descripcionCarta, c.numeroMana, c.tipo, c.daño, c.curacion, c.cartaTemporal, c.precio, m.cantidadCarta from carta as c, mazos as m where m.idMazo = 1 and m.idCarta = c.idCarta;
select * from carta where idCarta = 22 or idCarta = 25 or idCarta = 28;


select * from carta where idCarta = 22 or idCarta = 25 or idCarta = 28;





