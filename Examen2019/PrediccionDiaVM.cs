using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2019
{
    class PrediccionDiaVM : ObservableObject
    {
        private ObservableCollection<PrediccionDia> listaPredicciones;

        public ObservableCollection<PrediccionDia> ListaPredicciones
        {
            get { return listaPredicciones; }
            set { SetProperty(ref listaPredicciones, value); }
        }
        public ObservableCollection<PrediccionDia> GetSamples()
        {
            ObservableCollection<PrediccionDia> resultado = new ObservableCollection<PrediccionDia>();
            resultado.Add(new PrediccionDia("Lunes", "sol", 44, 60));
            resultado.Add(new PrediccionDia("Martes", "nubes", 55, 70));
            resultado.Add(new PrediccionDia("Miércoles", "sol", 35, 55));
            resultado.Add(new PrediccionDia("Jueves", "nubes", 48, 65));
            resultado.Add(new PrediccionDia("Viernes", "lluvia", 37, 50));
            resultado.Add(new PrediccionDia("Sábado", "nubes", 30, 50));
            resultado.Add(new PrediccionDia("Domingo", "nieve", 28, 40));

            return resultado;
        }
        public PrediccionDiaVM()
        {
            ListaPredicciones = GetSamples();
        }

    }
}
