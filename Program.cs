Console.WriteLine("---------------------------");
            Console.WriteLine("   CALCULADORA DE MÈDIA    ");
            Console.WriteLine("---------------------------");

            string novamente = "vazia";

            do
            {
                Console.Write("DIGITE QUANTAS NOTAS VOCÊ DESEJA CALCULAR: ");
                int numeroNotas = int.Parse(Console.ReadLine());

                while ((numeroNotas > 20) | (numeroNotas < 0))
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                    Console.WriteLine("---------------------------");
                    Console.Write("POR FAVOR DIGITE UMA QUANTIA DE NOTAS VALIDAS: ");
                    numeroNotas = int.Parse(Console.ReadLine());
                }

                
                double[] notas = new double[numeroNotas];

                for (int i = 0; i < numeroNotas; i++)
                {

                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                    Console.WriteLine("---------------------------");
                  

                    Console.Write("DIGITE A " + (i + 1) + "° NOTA: ");

                    notas[i] = double.Parse(Console.ReadLine());

                    while ((notas[i] > 10) | (notas[i] < 0))
                    {
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                        Console.WriteLine("---------------------------");
                        Console.Write("DIGITE UMA NOTA VALIDA POR FAVOR: ");
                        notas[i] = double.Parse(Console.ReadLine());

                    }

                }

                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                Console.WriteLine("---------------------------");
                Console.WriteLine("AS NOTAS POSSUEM PESO? s/n ");
                char respostas;
                respostas = Convert.ToChar(Console.ReadLine());
                Boolean vdd = respostas == 's' | respostas == 'n';

                while (vdd == false)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                    Console.WriteLine("---------------------------");
                    Console.Write("POR FAVOR  DIGITE UMA RESPOSTA VALIDA: ");
                    respostas = Convert.ToChar(Console.ReadLine());
                    vdd = respostas == 's' | respostas == 'n';
                }


                double[] pesos = new double[numeroNotas];
                double somaPesos = 0;
                double somaNotas = 0;
                double media = 0;
                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                Console.WriteLine("---------------------------");

                if (respostas == 's')
                {
                    for (int p = 0; p < numeroNotas; p++)
                    {

                        Console.WriteLine("DIGITE O PESO DA " + (p + 1) + "° NOTA");
                        pesos[p] = double.Parse(Console.ReadLine());

                        while ((pesos[p] > 20) | (pesos[p] < 0))
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                            Console.WriteLine("---------------------------");
                            Console.Write("POR FAVOR  DIGITE UMA RESPOSTA VALIDA: ");
                            pesos[p] = double.Parse(Console.ReadLine());

                        }

                    }

                    for (int c = 0; c < numeroNotas; c++)
                    {

                        notas[c] = notas[c] * pesos[c];
                        somaPesos = somaPesos + pesos[c];

                    }

                    for (int s = 0; s < numeroNotas; s++)
                    {

                        somaNotas = somaNotas + notas[s];

                    }

                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                    Console.WriteLine("---------------------------");
                    media = somaNotas / somaPesos;

                    Console.WriteLine("SUA MÈDIA È IGUAL A: " + media);

                }
                else
                {

                    for (int s = 0; s < numeroNotas; s++)
                    {

                        somaNotas = somaNotas + notas[s];

                    }

                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                    Console.WriteLine("---------------------------");
                    media = somaNotas / numeroNotas;

                    Console.WriteLine("SUA MÈDIA È IGUAL A: " + media);

                }

                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("   CALCULADORA DE MÈDIA    ");
                Console.WriteLine("---------------------------");

                Console.WriteLine("DIGITE *sim* PARA USAR O PROGRAMA NOVAMENTE");
                Console.WriteLine("OU DIGITE QUALQUER OUTRA COISA PARA SAIR");
                novamente = Console.ReadLine();

            } while (novamente == "sim");