using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RegnskabsApp
{
    class Passiver : INotifyPropertyChanged
    {
        private double aktieKapital;

        public double AktieKapital
        {
            get { return aktieKapital; }
            set { aktieKapital = value; NotifyPropertyChanged(); }
        }
        private double forslagTilAeretsUdbytte;

        public double ForslagTilAeretsUdbytte
        {
            get { return forslagTilAeretsUdbytte; }
            set { forslagTilAeretsUdbytte = value; NotifyPropertyChanged(); }
        }
        private double overfoertResultat;

        public double OverfoertResultat
        {
            get { return overfoertResultat; }
            set { overfoertResultat = value; NotifyPropertyChanged(); }
        }
        private double egenKapitalIAlt;

        public double EgenKapitalIAlt
        {
            get { return egenKapitalIAlt; }
            set { egenKapitalIAlt = AktieKapital + ForslagTilAeretsUdbytte + OverfoertResultat; NotifyPropertyChanged(); }
        }

        private double langfristedeGaeldEtc;

        public double LangfristedeGaeldEtc
        {
            get { return langfristedeGaeldEtc; }
            set { langfristedeGaeldEtc = value; NotifyPropertyChanged(); }
        }
        private double levarandoerGaeld;

        public double LevarandoerGaeld
        {
            get { return levarandoerGaeld; }
            set { levarandoerGaeld = value; NotifyPropertyChanged(); }
        }

        private double andenKortfristetGaeld;

        public double AndenKortfristetGaeld
        {
            get { return andenKortfristetGaeld; }
            set { andenKortfristetGaeld = value; NotifyPropertyChanged(); }
        }

        private double kortfristetGaeldIAlt;

        public double KortfristetGaeldIAlt
        {
            get { return kortfristetGaeldIAlt; }
            set { kortfristetGaeldIAlt = value; NotifyPropertyChanged(); }
        }

        private double gaeldIAlt;

        public double GaeldIAlt
        {
            get { return gaeldIAlt; }
            set { gaeldIAlt = LangfristedeGaeldEtc + LevarandoerGaeld + AndenKortfristetGaeld + KortfristetGaeldIAlt; NotifyPropertyChanged(); }
        }
        private double passiverIAlt;

        public double PassiverIAlt
        {
            get { return passiverIAlt; }
            set { passiverIAlt = GaeldIAlt + EgenKapitalIAlt; NotifyPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
