using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_cw5
{
    internal class Graph
       
    {
        List<NodeG> edges;
        List<Element> PrzygotujTabelke(NodeG start)
        {
            List<Element> tabelka = new List<Element>();
            tabelka.Add(new Element(start, int.MaxValue, null));
            return tabelka;
        }
        List<Element> AlgorytmDijkstry(NodeG start)
        {
            var tabelka = this.PrzygotujTabelke(start);
            var zbS = new List<NodeG>();
            var kandydat = tabelka.Where(e => !zbS.Contains(e.wezel)).OrderBy(e => e.dystans).First();
            zbS.Add(kandydat.wezel);
            this.edges.Where(k => k.start == kandydat.wezel && !zbS.Contains(k.end));
            var kandydatSasiedzi = this.edges.Where(k => k.start == kandydat.wezel && !zbS.Contains(k.end)).ToList();
           /* foreach(var e in tabelka)
            {
                if (!zbS.Contains(e.wezel))
                {
                    wynik.Add(e);
                }
            }*/
        }
    }
}
