using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppCadastroEventos.Models;

public class Evento
{
    public string Nome { get; set; } = "";
    public string Local { get; set; } = "";
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public int NumeroParticipantes { get; set; }
    public double CustoPorParticipante { get; set; }
    public double CustoTotal
    {
        get
        {
            return NumeroParticipantes * CustoPorParticipante;
        }
    }

    public int DuracaoDias
    {
        get
        {
            return (DataTermino - DataInicio).Days;
        }
    }
}
