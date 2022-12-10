using System;

namespace Datas
{
  class Program
    {
      static void Main(string[] args)
      {
        Console.WriteLine("...Obtendo data do Sistema");
        DateTime DataSistema = DateTime.Now;
        Console.WriteLine($"Data do Sistema: {DataSistema}");
   

        Console.WriteLine("...Iniciando uma data especifica");
        DateTime DataAdmissao = new DateTime(2021, 01, 19, 08, 30, 00);
        string stringData = "23/01/2021 08:30:00";
        DateTime inicioTreinamento = Convert.ToDateTime(stringData);
        Console.WriteLine($"Data de Admissao: {DataAdmissao}");
        Console.WriteLine($"Primeiro Dia Treinamento: {inicioTreinamento}");

        Console.WriteLine("...Exibindo Data/Hora, Curta e Longa");
        string dataCurta = DataSistema.ToShortDateString();
        string dataLonga = DataSistema.ToLongDateString();
        string horaCurta = DataSistema.ToShortTimeString();
        string horaLonga = DataSistema.ToLongTimeString();
        Console.WriteLine($"Data Curta: {dataCurta}");
        Console.WriteLine($"Data Longa: {dataLonga}");
        Console.WriteLine($"Hora Curta: {horaCurta}");
        Console.WriteLine($"Hora Longa: {horaLonga}");

        Console.WriteLine("...Obtendo partes de uma data");
        int ano = DataSistema.Year;
        DateTime dataSemHora = DataSistema.Date;
        int diaDaSemanaNumero = Convert.ToInt32(DataSistema.DayOfWeek);
        string diaDaSemanaTexto = DataSistema.ToString("dddd");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Data sem a hora: {dataSemHora}");
        Console.WriteLine($"Dia da Semana: {diaDaSemanaNumero} => {diaDaSemanaTexto}");

        Console.WriteLine("...Alterando uma Data");
        DateTime pagamento = DataSistema.AddMonths(1).AddDays(16).Date;
        DateTime duasHorasAtras = DataSistema.AddHours(-2);
        Console.WriteLine($"Pagamento: {pagamento}");
        Console.WriteLine($"Duas horas Atras: {duasHorasAtras}");

        Console.WriteLine("...Intervalos de Tempo Fixo");
        TimeSpan TresHorasEquinze = new TimeSpan(3, 15, 0);
        DateTime daquiHaPouco = DataSistema + TresHorasEquinze;
        Console.WriteLine($"Daqui há Pouco: {daquiHaPouco}");

        Console.WriteLine("...Calculando Intervalo entre Duas Datas");
        TimeSpan IntervaloDesdeMeiaNoite = DataSistema.TimeOfDay;
        int horasDecorridas = IntervaloDesdeMeiaNoite.Hours;
        TimeSpan tempoTrabalho = inicioTreinamento - DataAdmissao; 
        int diasTrabalho = tempoTrabalho.Days;
        Console.WriteLine($"Horas Desde 0h: {horasDecorridas} horas");
        Console.WriteLine($"Quantos dias levou inicio do treinamento: {diasTrabalho} dias");
     }
  }
}
