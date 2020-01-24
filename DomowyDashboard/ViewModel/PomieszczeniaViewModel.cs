using DomowyDashboard.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DomowyDashboard.ViewModel
{
    public class PomieszczeniaViewModel : BaseViewModel
    {
        private PomieszczeniaModel _pomieszczenie;
        public PomieszczeniaModel Pomieszczenie
        {
            get
            {
                return _pomieszczenie;
            }
            set
            {
                _pomieszczenie = value;
                RaisePropertyChanged(nameof(Pomieszczenie));
            }
        }
               

        #region Listy
        private ObservableCollection<PomieszczeniaModel> _pomieszczenieLista;
        public ObservableCollection<PomieszczeniaModel> PomieszczenieLista
        {
            get
            {
                return _pomieszczenieLista;
            }
            set
            {
                _pomieszczenieLista = value;
                RaisePropertyChanged(nameof(PomieszczenieLista));
            }
        }

        
        #endregion

        public PomieszczeniaViewModel()
        {
            Pomieszczenie = new PomieszczeniaModel();      
            PomieszczenieLista = new ObservableCollection<PomieszczeniaModel>();
           

            Pomieszczenie.Pomieszczenie = "";
            Pomieszczenie.Wilgotnosc = "0";
            Pomieszczenie.switchOswietlenie = false;
            Pomieszczenie.switchOgrzewanie = false;
            Pomieszczenie.switchKominek = false;
            Pomieszczenie.Temperatura = "0";
            Pomieszczenie.Kamera = "";
            Pomieszczenie.KameraVisible = true;
            Pomieszczenie.KlimatyzacjaVisible = false;
            Pomieszczenie.switchKominekVisible = false;
            Pomieszczenie.switchOgrzewanieVisible = false;
            Pomieszczenie.switchOswietlenieVisible = false;
            Pomieszczenie.TemperaturaVisible = false;
            Pomieszczenie.WilgotnoscVisible = false;


            DodajPomieszczenie();

        }

        private void DodajPomieszczenie()
        {
            try
            {
                PomieszczenieLista.Clear();

                PomieszczeniaModel pl = new PomieszczeniaModel                
                {                    
                    Pomieszczenie = "Pokój Gościnny",
                    Wilgotnosc = "21",
                    WilgotnoscVisible = true,
                    Temperatura = "24",
                    TemperaturaVisible = true,
                    KlimatyzacjaVisible = true,
                    Kamera = "https://img.noclegi-online.pl/pokoje-goscinne-centrum-krakow-41437m.jpg",
                    KameraVisible = true,
                    switchKominek = false,
                    switchKominekVisible = true,
                    switchOgrzewanie = false,
                    switchOgrzewanieVisible = true,
                    switchOswietlenie = false,
                    switchOswietlenieVisible = true,
                    ilp = PomieszczenieLista.Count()
                };
                pl.WypelnijSlownikElementow();
                PomieszczenieLista.Add(pl);

                pl = new PomieszczeniaModel
                {                    
                    Pomieszczenie = "Sypialnia",
                    Wilgotnosc = "25",
                    WilgotnoscVisible = true,
                    Temperatura = "22",
                    TemperaturaVisible = true,
                    KlimatyzacjaVisible = true,
                    Kamera = "https://kochamyzwierzaki.pl/wp-content/uploads/2019/08/3-4.jpg.webp",
                    KameraVisible = true,
                    switchKominek = false,
                    switchKominekVisible = false,
                    switchOgrzewanie = true,
                    switchOgrzewanieVisible = true,
                    switchOswietlenie = false,
                    switchOswietlenieVisible = true,
                    ilp = PomieszczenieLista.Count()
                };
                pl.WypelnijSlownikElementow();
                PomieszczenieLista.Add(pl);
                pl = new PomieszczeniaModel
                {
                    Pomieszczenie = "Jadalnia",
                    Wilgotnosc = "35",
                    WilgotnoscVisible = true,
                    Temperatura = "21",
                    TemperaturaVisible = true,
                    KlimatyzacjaVisible = false,
                    Kamera = "http://www.ekspertbudowlany.pl/images/photos/24/5236/__b_meble-drewno-jadalnia.jpg",
                    KameraVisible = true,
                    switchKominek = false,
                    switchKominekVisible = false,
                    switchOgrzewanie = true,
                    switchOgrzewanieVisible = false,
                    switchOswietlenie = false,
                    switchOswietlenieVisible = true,
                    ilp = PomieszczenieLista.Count()
                };
                pl.WypelnijSlownikElementow();
                PomieszczenieLista.Add(pl);
               
            }
            catch (Exception err)
            {

                Device.BeginInvokeOnMainThread(() => { Application.Current.MainPage.DisplayAlert("Błąd", err.ToString(), "OK"); });
            }
           

        }

        #region Komendy

        Command _cmdBtnZwiekszTemp;
        Command _cmdBtnZmniejszTemp;

        public Command cmdBtnZwiekszTemp
        {
            get
            {
                return _cmdBtnZwiekszTemp ?? (_cmdBtnZwiekszTemp = new Command(async () => UstawienieNowychWartosci(1)));
            }
        }  
        public Command cmdBtnZmniejszTemp
        {
            get
            {
                return _cmdBtnZmniejszTemp ?? (_cmdBtnZmniejszTemp = new Command(async () => UstawienieNowychWartosci(-1)));
            }
        }

        
        private void UstawienieNowychWartosci(int iParametr)
        {
           
        }           

        
        #endregion

    }
}
