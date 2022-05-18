//Scrivere un codice csharp che crea un accumulatore e poi lo utilizza
//Esempio: var accumulatore1 = CreaAccumulatore();
//accumulatore1(10) => 10
//accumulatore1(40) => 50
//accumulatore1(90) => 140
/*
 * In javascript  (closure)
  Maker() {
    let tot = 0;
    return (n) => {
        tot += n;
        return tot;
    }
  }
 * */
//1: per evitare di dichiarare un tipo cosa uso? var!!!
var Maker = () =>
{
    long totale = 0;
    return (int n) =>
    {
        totale += n;
        return totale;
    };
};
var acc1 = Maker();
var acc2 = Maker();
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));
var somma = (int n) => { n++; Console.WriteLine(n); };
somma(9) ;
//Data una lista di interi , metterli tutti al quadrato
List<int> list = new List<int>() {1,2,3,4,5,6,7} ;
List<int> listSquare = numeroPotenza(list,2);
foreach(int n in listSquare)Console.WriteLine(n);
List<int> numeroPotenza(List<int> list, int potenza)
{
    List<int> nuovaLista = new List<int>() ;
    foreach(int n in list)
    {
        nuovaLista.Add((int)Math.Pow(n,potenza));
    }
    return nuovaLista;
}
//Data una lista di interi , metterli tutti al cubo
List<int> listCubic = numeroPotenza(list, 3);
foreach (int n in listCubic) Console.WriteLine(n);
List<int> EseguiIlCalcolo(List<int> li, Func<int, int> fun)
{
    List<int> lout = new List<int>();
    foreach (int n in li)
        lout.Add(fun(n));
    return lout;
}
List<int> lcalcolo = EseguiIlCalcolo(list, (n) => n * (n + 1) / 2);
foreach (int n in lcalcolo)
    Console.WriteLine(n);
//Abbiamo in questo modo costruito una funzione "generale" per trasformare
//tutti gli elementi di una stringa da numero intero a numero intero => nuovo = f(vecchio);
//Purtroppo per come è stata costruita, questa funzione si applica esclusivamente alle lista di numeri interi 
//e torna una lista di numeri interi
//ordinare una lista di interi
list = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
list.Sort();
list.Reverse();  //se la volessi al contrario
foreach (int n in list)
    Console.WriteLine(n);
Console.WriteLine("\n\n\n\n");
list = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
list.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return -1;
    if (v1 == v2)
        return 0;
    else
        return 1;
});
foreach (int n in list)
    Console.WriteLine(n);
//crescente
Console.WriteLine("\n\n\n\n");
list = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
list.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return 1;
    if (v1 == v2)
        return 0;
    else
        return -1;
});
foreach (int n in list)
    Console.WriteLine(n);
//Data la lista di stringhe {"uno", "due", "tre", "quattro", "cinque", "Sei"}
//ordinarla e stamparla in verso decrescente
List<string>listString = new List<string>() { "uno","due","tre","quattro","cinque","sei" };
SortedSet<string> listSortedSet = new SortedSet<string>();
foreach (string s in listString) listSortedSet.Add(s);
foreach (string n in listSortedSet)
    Console.WriteLine(n);
//Esercizio finale
//Data una lista di coppie <string, int>, stamparle ordinate rispetto alla stringa
//una coppia in csharp si dichiara come 
//Tuple<string, int>  quindi  una lista di coppie sarà
List<Tuple<string, int>> lCoppie = new List<Tuple<string, int>>() {
        new Tuple<string, int>("uno", 1),
        new Tuple<string, int>("due", 21),
        new Tuple<string, int>("quattro", 41),
        new Tuple<string, int>("sette", 71),
        new Tuple<string, int>("diciannove", 191) };

lCoppie.Sort((s2, s1) => s2.Item1.CompareTo(s1.Item1));
foreach (Tuple<string, int> s in lCoppie)
    Console.WriteLine($"{ s.Item1} con  { s.Item2}");