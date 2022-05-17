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