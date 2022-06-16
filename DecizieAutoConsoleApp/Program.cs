using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecizieAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> m0Intretinere = new List<int> { 400 , 430, 500 };
            List<int> m0Confort = new List<int> { 15, 18, 20 };
            Masina m0 = new Masina("M1",13.5, m0Intretinere, 140, m0Confort);

            List<int> m1Intretinere = new List<int> { 440, 500, 530 };
            List<int> m1Confort = new List<int> { 16, 17, 18 };
            Masina m1 = new Masina("M2",12, m1Intretinere, 120, m1Confort);

            List<int> m2Intretinere = new List<int> { 380, 400, 480 };
            List<int> m2Confort = new List<int> { 16, 19, 20 };
            Masina m2 = new Masina("M3", 11, m2Intretinere, 150, m2Confort);

            List<int> m3Intretinere = new List<int> { 410, 450, 520 };
            List<int> m3Confort = new List<int> { 17, 18, 19 };
            Masina m3 = new Masina("M4", 10.5, m3Intretinere, 125, m3Confort);

            List<int> m4Intretinere = new List<int> { 490, 530, 550 };
            List<int> m4Confort = new List<int> { 16, 18, 20 };
            Masina m4 = new Masina("M5", 13.6, m4Intretinere, 180, m4Confort);

            List<Masina> listaMasini = new List<Masina>() { m0, m1, m2, m3, m4 };
            Console.WriteLine($"Masina 1: pret={m0.pret},intretinere=({m0.cheltuieli[0]},{m0.cheltuieli[1]},{m0.cheltuieli[2]}), cai putere={m0.cai_putere}, confort=({m0.confort[0]},{m0.confort[1]},{m0.confort[2]})");
            Console.WriteLine($"Masina 2: pret={m1.pret},intretinere=({m1.cheltuieli[0]},{m1.cheltuieli[1]},{m1.cheltuieli[2]}), cai putere={m1.cai_putere}, confort=({m1.confort[0]},{m1.confort[1]},{m1.confort[2]})");
            Console.WriteLine($"Masina 3: pret={m2.pret},intretinere=({m2.cheltuieli[0]},{m2.cheltuieli[1]},{m2.cheltuieli[2]}), cai putere={m2.cai_putere}, confort=({m2.confort[0]},{m2.confort[1]},{m2.confort[2]})");
            Console.WriteLine($"Masina 4: pret={m3.pret},intretinere=({m3.cheltuieli[0]},{m3.cheltuieli[1]},{m3.cheltuieli[2]}), cai putere={m3.cai_putere}, confort=({m3.confort[0]},{m3.confort[1]},{m3.confort[2]})");
            Console.WriteLine($"Masina 5: pret={m4.pret},intretinere=({m4.cheltuieli[0]},{m4.cheltuieli[1]},{m4.cheltuieli[2]}), cai putere={m4.cai_putere}, confort=({m4.confort[0]},{m4.confort[1]},{m4.confort[2]})");

            Console.WriteLine("Pretul dorit al masinii (mii u.m.):");
            double pretDorit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Abatere posibila (nr real):");
            double abaterePosibilaPret = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cheltuieli de intretinere dorite:");
            double costIntretinereDorit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Abatere maxima de la costul de intretinere (nr real):");
            double abatereCostIntretinere = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Numarul dorit de cai putere:");
            double caiPutereAspiratie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Abatere admisa la cai putere (nr intreg):");
            double abatereAdmisaCP = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gradul de confort maxim este 20.");
            double confortMax = 20;
            Console.WriteLine("Abatere posibila de la gradul de confort (nr intreg):");
            double abatereConfort = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nivel de aspiratie:");
            Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|", pretDorit, costIntretinereDorit, confortMax, caiPutereAspiratie));
            Console.WriteLine("Abatere admisa:");
            Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|", Math.Round(abaterePosibilaPret,3), abatereCostIntretinere, abatereConfort, abatereAdmisaCP));

            List<double> listaNrTriunghiulareCosturi = new List<double>();
            List<double> listaNrTriunghiulareConfort = new List<double>();
            foreach (var masina in listaMasini)
            {
                double adunareExtreme = masina.cheltuieli[0] + masina.cheltuieli[2];
                double inmultireMedie = 2 * masina.cheltuieli[1];
                double suma = inmultireMedie + adunareExtreme;
                double nrTriunghiularValueCost = (0.25 * suma);

                masina.nrTriunghiularCost = nrTriunghiularValueCost;
            }
            foreach (var masina in listaMasini)
            {
                double adunareExtreme = masina.confort[0] + masina.confort[2];
                double inmultireMedie = 2 * masina.confort[1];
                double suma = inmultireMedie + adunareExtreme;
                double nrTriunghiularValueConf = (0.25 * suma);

                masina.nrTriunghiularConfort = nrTriunghiularValueConf;
            }
            Console.WriteLine("\nMatricea consecintelor:");
            foreach (var m in listaMasini)
            {
                Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|", m.pret,m.nrTriunghiularCost,m.cai_putere,m.nrTriunghiularConfort));

            }
            // List<Object> NrTriunghiulare(List<Masina> list)
            //{
            //    double adunareExtreme = masina.cheltuieli[0] + masina.cheltuieli[2];
            //    double inmultireMedie = 2 * masina.cheltuieli[1];
            //    double suma = inmultireMedie + adunareExtreme;
            //    double nrTriunghiularValue = (0.25 * suma);

            //    masina.nrTriunghiular = nrTriunghiularValue;

            //    return nrTriunghiularValue;
            //}

            List<GradApartenenta> gradApartenentaMasina = new List<GradApartenenta>();

            foreach (var m in listaMasini)
            {
                double gradApartPret = CriteriuMin(m.pret, pretDorit, abaterePosibilaPret);
                double gradApartCosturi = CriteriuMin(m.nrTriunghiularCost, costIntretinereDorit, abatereCostIntretinere);
                double gradApartCaiPutere = CriteriuMin(m.cai_putere, caiPutereAspiratie, abatereAdmisaCP);
                double gradApartConfort = CriteriuMax(m.nrTriunghiularConfort, confortMax, abatereConfort);

                m.gradApartPret = gradApartPret;
                m.gradApartCosturi = gradApartCosturi;
                m.gradApartCaiPutere = gradApartCaiPutere;
                m.gradApartConfort = gradApartConfort;
            }

            Console.WriteLine("Cat de important este fiecare criteriu (intre 0 si 1 a.i. suma gradelor de importanta\n sa fie 1):");
            Console.WriteLine("Grad de importanta pret:");
            double pondereImpPret = double.Parse(Console.ReadLine());
            Console.WriteLine("Grad de importanta costuri:");
            double pondereImpCosturi = double.Parse(Console.ReadLine());
            Console.WriteLine("Grad de importanta cai putere:");
            double pondereImpCP = double.Parse(Console.ReadLine());
            Console.WriteLine("Grad de importanta confort:");
            double pondereImpConfort = double.Parse(Console.ReadLine());



            List<double> minValByRowList = new List<double>();
            List<double> sPonderiMList = new List<double>();
            //List<double> sPonderiMListSorted = new List<double>();
            Console.WriteLine("\nMultimile fuzzy:");
            foreach(var m in listaMasini)
            {
               
                List<double> gradApartM = new List<double> { m.gradApartPret,m.gradApartCosturi,m.gradApartCaiPutere, m.gradApartConfort };
                
                double sumaPonderiM;
                sumaPonderiM = m.gradApartPret * pondereImpPret + m.gradApartCosturi * pondereImpCosturi + m.gradApartCaiPutere * pondereImpCP + m.gradApartConfort * pondereImpConfort;
                m.importanta = sumaPonderiM;
                sPonderiMList.Add(sumaPonderiM);

                double minValueByRow;
                minValueByRow = gradApartM.Min();
                minValByRowList.Add(minValueByRow);
                Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|", Math.Round(m.gradApartPret, 3), Math.Round(m.gradApartCosturi, 3), Math.Round(m.gradApartCaiPutere, 3), Math.Round(m.gradApartConfort, 3)));
            }



            //Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|", Math.Round(pondereImpPret,3), Math.Round(pondereImpCosturi,3), Math.Round(pondereImpCP,3), Math.Round(pondereImpConfort,3)));

            Console.WriteLine("\nDate fiind ponderile anterioare, obtinem:");

            Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|", m0.importanta, m1.importanta, m2.importanta, m3.importanta, m4.importanta));

            Console.WriteLine("Ierarhia masinilor este:");

            var sPonderiMListSorted = listaMasini.OrderByDescending(x => x.importanta).ToList();
            Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|", "1", "2", "3", "4", "5"));
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|", sPonderiMListSorted[0].nume, sPonderiMListSorted[1].nume, sPonderiMListSorted[2].nume, sPonderiMListSorted[3].nume, sPonderiMListSorted[4].nume));


            Console.WriteLine("Apasa enter pentru a opri aplicatia.");
            Console.ReadLine();

            
            int GetMaxFromMinList(List<double> lista)
            {
                double maxVal = lista[0];
                int poz = 1;
                for (int i = 1; i < lista.Count; i++)
                {
                    if (maxVal < lista[i])
                    {
                        maxVal= lista[i];
                        poz++;
                    }
                }
                return poz;
            }


            double CriteriuMin(double aij, double Sj, double sj)
            {
                if (aij <= Sj)
                {
                    return 1;
                }
                else if(Sj<aij && aij < Sj + sj)
                {
                    return 1 - ((aij - Sj) / sj);
                }
                else
                {
                    return 0;
                }
            }

            double CriteriuMax(double aij, double Sj, double sj)
            {
                if (aij >= Sj)
                {
                    return 1;
                }
                else if (Sj-sj<aij && aij<Sj)
                {
                    return 1 - ((Sj - aij) / sj);
                }
                else
                {
                    return 0;
                }
            }

            
        }
    }
}
