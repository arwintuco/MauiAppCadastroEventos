using System;
using Microsoft.Maui.Controls;
using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos.Views;

public partial class CadastroEvento : ContentPage
{
	public CadastroEvento()
	{
		InitializeComponent();

        dtp_inicio.MinimumDate = DateTime.Now;
        dtp_inicio.MaximumDate = DateTime.Now.AddMonths(1);

        dtp_termino.MinimumDate = ((DateTime)dtp_inicio.Date).AddDays(1);
        dtp_termino.MaximumDate = ((DateTime)dtp_inicio.Date).AddMonths(6);
    }

    private void dtp_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        dtp_termino.MinimumDate = ((DateTime)dtp_inicio.Date).AddDays(1);
        dtp_termino.MaximumDate = ((DateTime)dtp_inicio.Date).AddMonths(6);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Evento evento = new Evento
            {
                Nome = txtNome.Text,
                Local = txtLocal.Text,
                DataInicio = ((DateTime)dtp_inicio.Date),
                DataTermino = ((DateTime)dtp_termino.Date),
                NumeroParticipantes = (int)stp_participantes.Value,
                CustoPorParticipante = Convert.ToDouble(txtCusto.Text)
            };

            await Navigation.PushAsync(new ResumoEvento()
            { BindingContext = evento });
        }
        catch
        {
            await DisplayAlert(
                "Erro", "Preencha todos os campos corretamente.", "OK");
        }
    }

}