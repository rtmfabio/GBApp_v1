
using GBApp.Components;
using GBApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GBApp.Views
{
    public partial class Pesquisa : ContentPage
    {
        private List<String> lista_categoriaskk = new List<string> { "Restauração", "Oficinas", "Farmácia", "Serviços" };
        private List<String> lista_sub_categoriaskk = new List<string> { "Opção1", "Opção2", "Opção3", "Opção4" };
        
        public Pesquisa()
        {
            PesquisaViewModel viewmodel = new PesquisaViewModel();

            InitializeComponent();
            BindingContext = viewmodel;
//chamada httprequest para obter categorias e subcategorias
            viewmodel.Lista_categorias = lista_categoriaskk;
            viewmodel.Lista_sub_categorias = lista_sub_categoriaskk;
            viewmodel.Raio = 50;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            categorias.SelectedIndexChanged += categoriaUpdate;
            subcategorias.SelectedIndexChanged += subCategoriaUpdate;
        }

        private void categoriaUpdate(object sender, EventArgs e)
        {
            var p = sender as BindablePicker;
            if (p.SelectedIndex >= 0)
                categoria.Text = p.SelectedIndex.ToString();
        }
        private void subCategoriaUpdate(object sender, EventArgs e)
        {
            var p = sender as BindablePicker;
            if (p.SelectedIndex >= 0)
                subcategoria.Text = p.SelectedIndex.ToString();
        }


        public void OnSearchButtonClick(object sender, EventArgs e)
        {
 

            if (mapasw.IsToggled)
            {
                Navigation.PushModalAsync(new Map());
            }
            else if (listsw.IsToggled)
            {
                this.Navigation.PushModalAsync(new ResultList());
            }

        }
    }
}
