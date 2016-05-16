using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using GBApp.Views;

namespace GBApp.ViewModels
{
    public class PesquisaViewModel : INotifyPropertyChanged
    {         
        private List<String> lista_categorias;
        private String selectedCategoria;
        private List<String> lista_sub_categorias;
        private String selectedSubCategoria;
        private Double raio;
        private Boolean map;
        private Boolean list;

        public List<string> Lista_categorias
        {
            get
            {
                return lista_categorias;
            }

            set
            {
                lista_categorias = value;
                OnPropertyChanged("Lista_categorias");
            }
        }
        public string SelectedCategoria
        {
            get
            {
                return selectedCategoria;
            }
            set
            {
                selectedCategoria = value;
                OnPropertyChanged("SelectedCategoria");
            }
        }
        public List<string> Lista_sub_categorias
        {
            get
            {
                return lista_sub_categorias;
            }

            set
            {
                lista_sub_categorias = value;
                OnPropertyChanged("Lista_sub_categorias");
            }
        }
        public string SelectedSubCategoria
        {
            get
            {
                return selectedSubCategoria;
            }

            set
            {
                selectedSubCategoria = value;
                OnPropertyChanged("SelectedSubCategoria");
            }
        }
        public double Raio
        {
            get
            {
                return raio;
            }

            set
            {
                raio = value;
                OnPropertyChanged("Raio");
            }
        }
        public bool Map
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
                list = !value;
                OnPropertyChanged("Map");
                OnPropertyChanged("List");

            }
        }
        public bool List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
                map = !value;
                OnPropertyChanged("Map");
                OnPropertyChanged("List");
            }
        }

        public PesquisaViewModel()
        {
            list = true;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

