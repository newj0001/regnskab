using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RegnskabsApp
{
    class Aktiver : INotifyPropertyChanged
    {
        private double immaterielleAktiver;

        public double ImmaterielleAktiver
        {
            get { return immaterielleAktiver; }
            set
            {
                immaterielleAktiver = value;
                NotifyPropertyChanged();
            }
        }
        private double materielle;

        public double Materielle
        {
            get { return materielle; }
            set
            {
                materielle = value;
                NotifyPropertyChanged();
            }
        }
        private double finansielle;

        public double Finansielle
        {
            get { return finansielle; }
            set
            {
                finansielle = value;
                NotifyPropertyChanged();
            }
        }

        private double anlaegsAktiverIAlt;
  
        public double AnlaegsAktiverIAlt
        {
            get { return anlaegsAktiverIAlt; }
            set
            {
                anlaegsAktiverIAlt = ImmaterielleAktiver + Materielle + Finansielle;
                NotifyPropertyChanged();
            }
        }

        private double varebeholdning;

        public double VareBeholdning
        {
            get { return varebeholdning; }
            set
            {
                varebeholdning = value;
                NotifyPropertyChanged();
            }
        }

        private double tilgodehavendeFraSalg;

        public double TilgodehavendeFraSalg
        {
            get { return tilgodehavendeFraSalg; }
            set
            {
                tilgodehavendeFraSalg = value;
                NotifyPropertyChanged();
            }
        }
        private double oevrigeTilgodehavende;

        public double OevrigeTilgodehavende
        {
            get { return oevrigeTilgodehavende; }
            set
            {
                oevrigeTilgodehavende = value;
                NotifyPropertyChanged();
            }
        }

        private double likvideBeholdninger;

        public double LikvideBeholdninger
        {
            get { return likvideBeholdninger; }
            set
            {
                likvideBeholdninger = value;
                NotifyPropertyChanged();
            }
        }

        private double omsaetningsaktiverIAlt;

        public double OmsaetningsAktiverIAlt
        {
            get { return omsaetningsaktiverIAlt; }
            set
            {
                omsaetningsaktiverIAlt = VareBeholdning + TilgodehavendeFraSalg + OevrigeTilgodehavende + LikvideBeholdninger;
                NotifyPropertyChanged();
            }
        }
        private double aktiverIAlt;

        public double AktiverIAlt
        {
            get { return aktiverIAlt; }
            set { aktiverIAlt = AnlaegsAktiverIAlt + OmsaetningsAktiverIAlt; NotifyPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
