using System.Collections.Generic;

// commentaire

/*commentaire
 * sur 
 * plusieurs lignes */


//Variables
int intergerValue = 42; // attention valeur max 2 147 483 647 selon version 
long valueLong = 1000000000000;
float valueFloat = 3.1415926f;
double vValueDouble = 3.14159265359; // plus de précision
decimal valueDecimal = 3.14152365215541255m; // encore plus

int pointsDeVie; //CamelCase => plus courant pour les variables
int points_de_vie; //SnakeCase
int PointDeVie; //PascalCase ou UpperCamelCase => plutot pour les fonctions
// int point-de-vie => kebab Case (python)
int POINT_DE_VIE; //screaming snake case => constantes parfois

//conseil : utiliser l'anglais

string valueString = "Bonjour";
string valueString2 = "Vincent dit : \"Bonjour\" ";
string valueString3 = "Bonjour \n"; // retour a la ligne

char valueChar = 'a';
char lettre = (char)65; // code ascii
int correspondance = valueChar; // conversion implicite

Console.WriteLine(lettre);
Console.WriteLine(correspondance);

bool valueBool = true; // ou false

DateTime valueDate = DateTime.Now;
Console.WriteLine(valueDate);


//input/output
Console.WriteLine(lettre); //afficher
Console.Write(lettre); // sans retour a la ligne

Console.WriteLine("Quel est votre prénom ?");
string prenom = Console.ReadLine();

Console.WriteLine("Bonjour " + prenom);

//Conversions

int myInt = 42;
long myLong = myInt; // conversion implicite

double myDouble = 3.94;
int myInt2 = (int)myDouble; // cast explicite //attention : troncature
int myInt3 = Convert.ToInt32(myDouble); // méthode de conversion

myInt2.ToString(); //renvoie un chiffre sous forme de chaine de carac

string numStr = "42";
int myInt4 = int.Parse(numStr);
double myDouble2 = double.Parse(numStr);

//exemple classique de demande de chiffre :
Console.Write("donne moi ton age");
string input = Console.ReadLine();
int age = int.Parse(input);
Console.WriteLine(age * 2);

//version sécurisée
Console.Write("donne moi ton age (version sécurisée)");
string input2 = Console.ReadLine();
int age2;
if(int.TryParse(input2, out age2))
{
    Console.WriteLine("Vous avez bien entré un nombre : " + age2);
}
else
{
    Console.WriteLine("Erreur la saisie n'est pas valide");
}

bool truc;


//opérations
int a = 1;
int b = 2;
int c = 0;
c = a + b;
c = a - b;
c = a * b;
c = a / b; // attention stocker plutot les divisions dans un float
c = a % b; // reste de la division euclidienne

c += 3; // alternative à c = c + 3
c++; // alternative a c = c + 1

MathF.Pow(c, 2); // pensez a fouiller mathF. ... pour les fonctions de math


//Structures conditionelles

using System;

int e = 10;
int f = 20;

if(e==f)
{
    Console.WriteLine("e et f sont égaux");
}
else if(e>f)
{
    Console.WriteLine("e superieur a f");
}
else
{
    Console.WriteLine("e inférieur a f");
}

//listes des comparateurs :
// == != < > <= >=
//  && and   || or   ! NON  ^XOR

int day = 3;
switch(day)
{
    case 1:
        Console.WriteLine("Lundi");
        break;
    case 2:
        Console.WriteLine("Mardi");
        break;
    case 3:
        Console.WriteLine("Mercredi");
        break;
    case 4:
        Console.WriteLine("Jeudi");
        break;
    case 5:
        Console.WriteLine("Vendredi");
        break;
    case 6:
        Console.WriteLine("Samedi");
        break;
    case 7:
        Console.WriteLine("Dimanche");
        break;
    default:
        Console.WriteLine("erreur");
        break;
}


//Structures itératives

//boucle for
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("itération" + i);
}

int j = 0;
while(j<5)
{
    Console.WriteLine("itération" + j);
    j++;
}

//exemple
Console.WriteLine("quel est ton age ?");
string input = Console.ReadLine();
int input_int;
while(int.TryParse(input, out input_int) == false)
{
    Console.WriteLine("Erreur de saisie, quel est ton age ?");
    input = Console.ReadLine();
}

// mot clé break : coupe la boucle en cours
// mot clé continue : stoppe l'itération de la boucle en cours pour passer a l'itération suivante




int[] intArray = { 1, 2, 3, 4, 5 };
string[] stringArray = new string[8];

//acceder aux éléments :
int element = intArray[2]; //via l'indice qui commence à zero
intArray[2] = 50; // changer la valeur

//afficher la liste complète
Console.WriteLine(string.Join(", ", intArray));

//taille
int l = intArray.Length;

//parcourir un tableau
for(int i = 0; i < l; i++)
{
    Console.WriteLine(intArray[i]);
}
//ou
foreach (int item in intArray)
{
    Console.WriteLine(item);
}

//recherche
int index = Array.IndexOf(intArray, element);

//trier
Array.Sort(intArray);

//copie
int[] intArray2 = new int[5];
Array.Copy(intArray, intArray2, 5);

//attention les Array (tableaux) sont de taille fixe, impossible d'ajouter ou supprimer un élément

//remarque : les strings se comportent presque comme des array de char
string texte = "Bonjour";
char lettre = texte[2];


//LISTES
//using System.Collections.Generic; a rajouter pour les listes et dictionnaires

//déclaration
List<int> myList = new List<int>();

//ajouter un élément
myList.Add(10);
myList.Add(20);
myList.Add(30);

//acceder aux elements :
int element2 = myList[2];

//taille
int taille = myList.Count;

//recherche
int index_ = myList.IndexOf(7);
int foundElement = myList.Find(x => x > 15); // recherche le premier element supérieur a 15

//tri
myList.Sort();

//copie
List<int> anotherList = new List<int>();
anotherList.AddRange(myList);

//parcourir liste : comme les tableaux


//remarque : on peut des tableau de tableaux, des liste de listes, etc
//exemple matrice 3x3
int[,] matrix = new int[3, 3];
//accéder aux element :
matrix[1, 2] = 5; //=> ligne 1 colonne 2
