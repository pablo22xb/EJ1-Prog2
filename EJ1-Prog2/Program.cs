class ej1
{
    static void Main()
    {
        int dd, mm, aaaa;

        Console.Write("Dime una dia: ");
        dd = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime un mes: ");
        mm = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime un Año: ");
        aaaa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        //Febrero (29 dias Bisiesto y dias 28 no Bisiesto)

        //Bisiesto: año divible entre 4 y sin resto & año dividible entre 100 o es divisible entre 400

        //Meses con 30 dias: abril, junio, septiembre y noviembre.
        //Meses con 31 dias: enero, marzo, mayo, julio, agosto, octubre y diciembre.


        switch (mm)
        {
            case 1:
                dd++;
                if (dd >= 1 && dd <= 31)
                {
                    Console.Write(dd);
                    Console.Write(" de Enero de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 2:
                if (aaaa %4 == 0 && aaaa % 100 != 0 || aaaa % 400 == 0)
                {
                    dd++;
                    if (dd >= 1 && dd <= 29)
                    {
                        Console.Write(dd);
                        Console.Write(" de Febrero de ");
                        Console.Write(aaaa);
                        Console.Write(" y es año Bisiesto");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fecha incorrecta");
                        break;
                    }
                }       
                else
                {
                    dd++;
                    if (dd >= 1 && dd <= 28)
                    {
                        Console.Write(dd);
                        Console.Write(" de Febrero de ");
                        Console.Write(aaaa);
                        Console.Write(" y NO es año Bisiesto");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fecha incorrecta");
                        break;
                    }

                }
            case 3:
                dd++;
                if (dd >= 1 && dd <= 31)
                {
                    Console.Write(dd);
                    Console.Write(" de Marzo de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 4:
                dd++;
                if (dd >= 1 && dd <= 30)
                {
                    Console.Write(dd);
                    Console.Write(" de Abril de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 5:
                dd++;
                if (dd >= 1 && dd <= 31)
                {
                    Console.Write(dd);
                    Console.Write(" de Mayo de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 6:
                dd++;
                if (dd >= 1 && dd <= 30)
                {
                    Console.Write(dd);
                    Console.Write(" de Junio de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 7:
                dd++;
                if (dd >= 1 && dd <= 31)
                {
                    Console.Write(dd);
                    Console.Write(" de Julio de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 8:
                dd++;
                if (dd >= 1 && dd <= 31)
                {
                    Console.Write(dd);
                    Console.Write(" de Agosto de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 9:
                dd++;
                if (dd >= 1 && dd <= 30)
                {
                    Console.Write(dd);
                    Console.Write(" de Septiembre de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 10:
                dd++;
                if (dd >= 1 && dd <= 31)
                {
                    Console.Write(dd);
                    Console.Write(" de Octubre de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 11:
                dd++;
                if (dd >= 1 && dd <= 30)
                {
                    Console.Write(dd);
                    Console.Write(" de Noviembre de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            case 12:
                dd++;
                if (dd >= 1 && dd <= 31)
                {
                    Console.Write(dd);
                    Console.Write(" de Diciembre de ");
                    Console.Write(aaaa);
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                    break;
                }
            default:
                Console.WriteLine("Fecha incorrecta");
                break;

        }
        Console.ReadLine();
    }
}