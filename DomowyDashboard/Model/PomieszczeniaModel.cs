﻿using DomowyDashboard.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomowyDashboard.Model
{
    public class PomieszczeniaModel : BaseViewModel
    {
        private ObservableCollection<DostepneUrzadzeniaModel> _DostepneUrzadzenia;
        public PomieszczeniaModel()
        {
            DostepneUrzadzenia = new ObservableCollection<DostepneUrzadzeniaModel>();
        }
        public int ilp { get; set; }

        
        public string Pomieszczenie { get; set; }
        public bool WilgotnoscVisible { get; set; }
        public string Wilgotnosc { get; set; }
        public bool TemperaturaVisible { get; set; }
        
        private string temperatura;
        public string Temperatura 
        {
            get 
            {
                return temperatura;
            }

            set
            {
                temperatura = value;
                RaisePropertyChanged(nameof(Temperatura));
            } 
        
        }        
        
        public bool KameraVisible { get; set; }
        public string Kamera { get; set; }
        public bool KlimatyzacjaVisible { get; set; }
        public bool switchOswietlenieVisible { get; set; }
        public bool switchOswietlenie { get; set; }
        public bool switchOgrzewanieVisible { get; set; }
        public bool switchOgrzewanie { get; set; }
        public bool switchKominekVisible { get; set; }
        public bool switchKominek { get; set; }


        public ObservableCollection<DostepneUrzadzeniaModel> DostepneUrzadzenia
        {
            get
            {
                return _DostepneUrzadzenia;
            }
            set
            {
                _DostepneUrzadzenia = value;
                RaisePropertyChanged(nameof(DostepneUrzadzenia));
            }
        }

        public void WypelnijSlownikElementow()
        {
            DostepneUrzadzenia.Clear();

            
                DostepneUrzadzenia.Add(new DostepneUrzadzeniaModel() { Nazwa = "Ogrzewanie", Id = 0 });
                DostepneUrzadzenia.Add(new DostepneUrzadzeniaModel() { Nazwa = "Klimatyzacja", Id = 1 });
                DostepneUrzadzenia.Add(new DostepneUrzadzeniaModel() { Nazwa = "Oświetlenie", Id = 2 });
                DostepneUrzadzenia.Add(new DostepneUrzadzeniaModel() { Nazwa = "Kominek", Id = 3 });
           
        }

    }
}
