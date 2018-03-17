using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculo;

namespace APIPaypal.Controllers
{
    [Route("api/[controller]")]
    public class CalculaTaxaController : Controller
    {
        // GET api/calculataxa/valorpago/$valor/$moeda
        [HttpGet("ValorPago/{valor}/{moeda}")]
        public object Get(double valor, string moeda)
        {

            return new 
            {
                Resposta = CalculaTaxa.PaypalParm(valor, moeda),
                Moeda = moeda
            };
            
        }


        // GET api/calculataxa/valorpago/$valor
        [HttpGet("ValorPago/{valor}")]
        public object GetUSD(double valor)
        {
            string moeda = "USD";

            return new
            {
                Resposta = CalculaTaxa.PaypalParm(valor, moeda),
                Moeda = moeda
            };

        }

        // GET api/calculataxa/valorpago/
        [HttpGet("ValorPago")]
        public object GetNull()
        {

            return new
            {
                Resposta = "Parêmetros insuficientes."
            };

        }







    }
}
