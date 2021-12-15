using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2019
{
    class PrediccionDia : ObservableObject
    {
        private String dia;

        public String Dia
        {
            get { return dia; }
            set { SetProperty(ref dia, value); }
        }

        private String prediccion;

        public String Prediccion
        {
            get { return prediccion; }
            set { SetProperty(ref prediccion, value); }
        }

        private int minimaFarenheit;

        public int MinimaFarenheit
        {
            get { return minimaFarenheit; }
            set { SetProperty(ref minimaFarenheit, value); }
        }

        private int maximaFarenheit;

        public int MaximaFarenheit
        {
            get { return maximaFarenheit; }
            set { SetProperty(ref maximaFarenheit, value); }
        }

        public PrediccionDia(string dia, string prediccion, int minimaFarenheit, int maximaFarenheit)
        {
            this.dia = dia;
            this.prediccion = prediccion;
            this.minimaFarenheit = minimaFarenheit;
            this.maximaFarenheit = maximaFarenheit;
        }
    }
}
