using System;

namespace ConsoleApp6
{
    class Program
    {
        class People
        {
            public int Men = 0;
            public int Women = 0;
        }

        class Country
        {
            //
            // Городское население	105313773	48117546	57196227
            public People[] peoples = new People[]
                {
                new People { Men = 596281, Women = 564739 },
                new People { Men = 604640, Women = 573583 }, // 1
                new People { Men = 590136, Women = 562350 }, // 2
                new People { Men = 550849, Women = 522728 }, // 3
                new People { Men = 525390, Women = 499999 }, // 4

                new People { Men = 531738, Women = 510562 }, // 5
                new People { Men = 527401, Women = 502151 }, // 6
                new People { Men = 525496, Women = 499184 }, // 7
                new People { Men = 497490, Women = 473555 }, // 8
                new People { Men = 470259, Women = 448227 }, // 9

                new People { Men = 475221, Women = 450917 }, // 10
                new People { Men = 451107, Women = 428363 }, // 11
                new People { Men = 462493, Women = 442141 }, // 12
                new People { Men = 453864, Women = 433633 }, // 13
                new People { Men = 473550, Women = 452012 }, // 14

                new People { Men = 513262, Women = 494758 }, // 15
                new People { Men = 547221, Women = 522584 }, // 16
                new People { Men = 581873, Women = 570369 }, // 17
                new People { Men = 697296, Women = 694005 }, // 18
                new People { Men = 784329, Women = 772241 }, // 19

                new People { Men = 879762, Women = 873585 }, // 20
                new People { Men = 888382, Women = 878943 }, // 21
                new People { Men = 927873, Women = 924362 }, // 22
                new People { Men = 962679, Women = 954995 }, // 23
                new People { Men = 940538, Women = 945097 }, // 24

                new People { Men = 940182, Women = 956635 }, // 25
                new People { Men = 928727, Women = 936255 }, // 26 
                new People { Men = 948200, Women = 956634 }, // 27
                new People { Men = 877751, Women = 891824 }, // 28
                new People { Men = 858125, Women = 870796 }, // 29

                new People { Men = 909079, Women = 925857 }, // 30 
                new People { Men = 827842, Women = 851542 }, // 31
                new People { Men = 816826, Women = 850677 }, // 32
                new People { Men = 787811, Women = 827188 }, // 33
                new People { Men = 797628, Women = 843154 }, // 34

                new People { Men = 794692, Women = 846962 }, // 35
                new People { Men = 762864, Women = 808471 }, // 36
                new People { Men = 742902, Women = 789343 }, // 37
                new People { Men = 740831, Women = 789352 }, // 38
                new People { Men = 710049, Women = 755435 }, // 39

                new People { Men = 736114, Women = 780302 }, // 40
                new People { Men = 645220, Women = 700293 }, // 41
                new People { Men = 626757, Women = 686040 }, // 42
                new People { Men = 616946, Women = 684267 }, // 43
                new People { Men = 630446, Women = 710390 }, // 44

                new People { Men = 664569, Women = 755643 }, // 45
                new People { Men = 677783, Women = 780617 }, // 46
                new People { Men = 720066, Women = 836247 }, // 47
                new People { Men = 744140, Women = 879646 }, // 48
                new People { Men = 772883, Women = 921421 }, // 49

                new People { Men = 818498, Women = 984021 }, // 50
                new People { Men = 755327, Women = 937405 }, // 51
                new People { Men = 737565, Women = 928235 }, // 52
                new People { Men = 710525, Women = 906032 }, // 53
                new People { Men = 688569, Women = 896014 }, // 54
                
                new People { Men = 690701, Women = 919062 }, // 55
                new People { Men = 660454, Women = 894079 }, // 56
                new People { Men = 605240, Women = 830909 }, // 57
                new People { Men = 609735, Women = 847599 }, // 58
                new People { Men = 576448, Women = 808484 }, // 59

                new People { Men = 580024, Women = 821478 }, // 60 
                new People { Men = 570611, Women = 836126 }, // 61
                new People { Men = 436799, Women = 638112 }, // 62
                new People { Men = 473043, Women = 709522 }, // 63
                new People { Men = 359552, Women = 548060 }, // 64 

                new People { Men = 230886, Women = 359797 }, // 65
                new People { Men = 170299, Women = 271165 }, // 66
                new People { Men = 151435, Women = 250539 }, // 67
                new People { Men = 242542, Women = 434626 }, // 68
                new People { Men = 311072, Women = 568743 }, // 69

                new People { Men = 339706, Women = 635395 }, // 70
                new People { Men = 344724, Women = 680958 }, // 71
                new People { Men = 319688, Women = 649519 }, // 72 
                new People { Men = 315298, Women = 644720 }, // 73
                new People { Men = 234271, Women = 497098 }, // 74

                new People { Men = 188758, Women = 414217 }, // 75
                new People { Men = 136688, Women = 314924 }, // 76
                new People { Men = 130473, Women = 318016 }, // 77
                new People { Men = 142984, Women = 360935 }, // 78
                new People { Men = 133209, Women = 346266 }, // 79

                new People { Men = 136344, Women = 366054 }, // 80
                new People { Men = 112331, Women = 322656 }, // 81
                new People { Men = 106373, Women = 318198 }, // 82
                new People { Men = 89417, Women = 266968 }, // 83
                new People { Men = 70397, Women = 233434 }, // 84

                new People { Men = 50240, Women = 193926 }, // 85
                new People { Men = 35880, Women = 156235 }, // 86 
                new People { Men = 25233, Women = 117650 }, // 87
                new People { Men = 18516, Women = 83676 }, // 88
                new People { Men = 14165, Women = 61449 }, // 89

                new People { Men = 10840, Women = 45502 }, // 90
                new People { Men = 8025, Women = 34809 }, // 91
                new People { Men = 6215, Women = 27984 }, // 92
                new People { Men = 3481, Women = 16359 }, // 93
                new People { Men = 2854, Women = 13585 }, // 94

                new People { Men = 2506, Women = 12244 }, // 95
                new People { Men = 1900, Women = 9514 }, // 96
                new People { Men = 1357, Women = 6211 }, // 97
                new People { Men = 902, Women = 4212 }, // 98
                new People { Men = 563, Women = 2429 }, // 99

                new People { Men = 1186, Women = 3945 } // 100


                // 9802454
                };
            public int DeltaCityMen = 16134;
            public int DeltaCityWoman = 17057;


            double populationCity = 9894.0;
            double populationRegions = 57579.0;
            int year = 1897;

            private double GetStepPopulationCity()
            {
                // 1926
                // по переписи на 17 декабря в границах до 17 сентября 1939 г.
                if (year < 1926)
                {
                    // сколько родилось и умерло
                    return (16455.0 - (double)populationCity) / (1926.0 - (double)year);

                }
                // 1937
                // оценка по предварительным итогам переписи на 6 января в границах 1937 г. без Крымской АССР
                else if (year < 1937)
                {
                    return (34923.0 - (double)populationCity) / (1937.0 - (double)year);
                }
                // 1939
                // оценка с учетом территорий, вошедших в состав СССР после 17 сентября 1939 г.
                else if (year < 1939)
                {
                    return (36296.0 - (double)populationCity) / (1939.0 - (double)year);
                }

                // 1959	
                // по переписи на 15 января
                else if (year < 1959)
                {
                    return (61143.0 - (double)populationCity) / (1959.0 - (double)year);
                }

                // 1970	
                // по переписи на 15 января
                else if (year < 1970)
                {
                    return (80631.0 - (double)populationCity) / (1970.0 - (double)year);
                }
                // 1979
                // по переписи на 17 января
                else if (year < 1979)
                {
                    return (94942.0 - (double)populationCity) / (1979.0 - (double)year);
                }
                // 1989	
                // по переписи на 12 января
                else if (year < 1989)
                {
                    return (107959.0 - (double)populationCity) / (1989.0 - (double)year);
                }
                // 2002	
                // по переписи на 9 октября
                else if (year < 2002)
                {
                    return (106429.0 - (double)populationCity) / (2002.0 - (double)year);
                }
                // 2010
                // по переписи на 14 октября
                else if (year < 2010)
                {
                    return (105313.773 - (double)populationCity) / (2010.0 - (double)year);
                }
                throw new Exception("test");
            }

            private double GetStepPopulationRegions()
            {
                // 1926
                // по переписи на 17 декабря в границах до 17 сентября 1939 г.
                if (year < 1926)
                {
                    return (76280.0 - (double)populationRegions) / (1926.0 - (double)year);
                }
                // 1937
                // оценка по предварительным итогам переписи на 6 января в границах 1937 г. без Крымской АССР
                else if (year < 1937)
                {
                    return (70009.0 - (double)populationRegions) / (1937.0 - (double)year);
                }
                // 1939
                // оценка с учетом территорий, вошедших в состав СССР после 17 сентября 1939 г.
                else if (year < 1939)
                {
                    return (72081.0 - (double)populationRegions) / (1939.0 - (double)year);
                }
                // 1959	
                // по переписи на 15 января
                else if (year < 1959)
                {
                    return (56097.0 - (double)populationRegions) / (1959.0 - (double)year);
                }
                // 1970	
                // по переписи на 15 января
                else if (year < 1970)
                {
                    return (49310.0 - (double)populationRegions) / (1970.0 - (double)year);
                }
                // 1979
                // по переписи на 17 января
                else if (year < 1979)
                {
                    return (42468.0 - (double)populationRegions) / (1979.0 - (double)year);
                }
                // 1989	
                // по переписи на 12 января
                else if (year < 1989)
                {
                    return (39063.0 - (double)populationRegions) / (1989.0 - (double)year);
                }
                // 2002	
                // по переписи на 9 октября
                else if (year < 2002)
                {
                    return (38738.0 - (double)populationRegions) / (2002.0 - (double)year);
                }
                // 2010
                // по переписи на 14 октября
                else if (year < 2010)
                {
                    return (37543.0 - (double)populationRegions) / (2010.0 - (double)year);
                }
                throw new Exception("test");
            }

            public double GetPopulation(int targetYear)
            {
                populationCity = 9894.0;
                populationRegions = 57579.0;

                double stepPopulationCity = 0.0;
                double stepPopulationRegions = 0.0;
                for (year = 1897; year < targetYear; year++)
                {
                    //if ((int)stepPopulationCity != (int)GetStepPopulationCity())
                    //{
                    //    Console.WriteLine(GetStepPopulationCity());
                    //}
                    stepPopulationCity = GetStepPopulationCity();
                    if (double.IsNaN(stepPopulationCity))
                    {
                        throw new Exception("-");
                    }
                    stepPopulationRegions = GetStepPopulationRegions();
                    //if ((int)stepPopulationRegions != (int)GetStepPopulationRegions())
                    //{
                    //    Console.WriteLine(GetStepPopulationRegions());
                    //}
                    if (double.IsNaN(stepPopulationRegions))
                    {
                        throw new Exception("-");
                    }
                    populationCity = populationCity + stepPopulationCity;
                    if (double.IsNaN(populationCity))
                    {
                        throw new Exception("-");
                    }
                    populationRegions = populationRegions + stepPopulationRegions;
                    if (double.IsNaN(populationRegions))
                    {
                        throw new Exception("-");
                    }
                }
                //Console.WriteLine("{0} in year", Math.Round(stepPopulationCity, 0));
                //Console.WriteLine("{0} in year", Math.Round(stepPopulationRegions, 0));

                double population = populationCity + populationRegions;

                return Math.Round(population, 0);
            }
        }

        static void Main(string[] args)
        {
            Country country = new Country();
            //Console.WriteLine("{0} - {1}", country.GetPopulation(1897), 67473.0);
            //Console.WriteLine("{0} - {1}", country.GetPopulation(1926), 92735.0);
            //Console.WriteLine("{0} - {1}", country.GetPopulation(1937), 104932.0);
            //Console.WriteLine("{0} - {1}", country.GetPopulation(1939), 108377.0);
            //Console.WriteLine("{0} - {1}", country.GetPopulation(1959), 117240.0);
            //Console.WriteLine("{0} - {1}", country.GetPopulation(1970), 129941.0);
            //Console.WriteLine("{0} - {1}", country.GetPopulation(1979), 137410.0);
            //Console.WriteLine("{0} - {1}", country.GetPopulation(1989), 147022.0);
            //Console.WriteLine("{0} - {1}", country.GetPopulation(2002), 145167.0);
            //Console.WriteLine("{0} - {1}", country.GetPopulation(2010), 142857.0);
             
            int men = 0;
            int women = 0;
            int year = 1989;
            for (int i = 2010 - year; i < 101; i++)
            {
                men += country.peoples[i].Men;
                women += country.peoples[i].Women;
            }
            men += country.DeltaCityMen;
            women += country.DeltaCityWoman;

            //Console.WriteLine("{0} {1} {2} {3}", men, 48117546, women, 57196227);
            Console.WriteLine("{0} {1}", men + women, 107959000);
            Console.ReadLine();
        }
    }
}

/*
 "1897
"	по переписи на 9 февраля в современных границах	67473	67473	67473	9894	9894	9894	57579	57579	57579
"1926
"	по переписи на 17 декабря в границах до 17 сентября 1939 г.	92735	92735	92735	16455	16455	16455	76280	76280	76280
"1937

"	"оценка по предварительным итогам
переписи на 6 января в границах
1937 г. без Крымской АССР"	104932	104932	104932	34923	34923	34923	70009	70009	70009
"1939

"	"оценка с учетом территорий, 
вошедших в состав СССР после 
17 сентября 1939 г."	108377	108377	108377	36296	36296	36296	72081	72081	72081

1959	по переписи на 15 января	117240	117240	117240	
61143	61143	61143	56097	56097	56097

1970	по переписи на 15 января	129941	129941	129941	
80631	80631	80631	49310	49310	49310

1979	по переписи на 17 января	137410	137410	137410	
94942	94942	94942	42468	42468	42468

1989	по переписи на 12 января	147022	147022	147022	
107959	107959	107959	39063	39063	39063

2002	по переписи на 9 октября	145167	145167	145167	
106429	106429	106429	38738	38738	38738

2010	по переписи на 14 октября	142857	142857	142857
105314	105314	105314	
37543	37543	37543

     
     */
