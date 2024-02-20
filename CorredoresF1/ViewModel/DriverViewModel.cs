using CorredoresF1.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CorredoresF1.ViewModel
{
    public class DriverViewModel : BaseViewModel
    {
        #region VARIABLES
        string _Id;
        string _Name;
        int _Number;
        string _Team;
        #endregion
        #region CONTRUCTOR
        public DriverViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }
        public string Name
        {
            get { return _Name; }
            set { SetValue(ref _Name, value); }
        }
        public int Number
        {
            get { return _Number; }
            set { SetValue(ref _Number, value); }
        }
        public string Team
        {
            get { return _Team; }
            set { SetValue(ref _Team, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Insertar()
        {
            DriverModel model = new DriverModel
            {
                
                Name = Name,
                Number = Number,
                Team = Team
            };
            Uri RequestUri = new Uri("http://www.practicaapi.somee.com/api/drivers");
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(model);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json"); 
            var response = await client.PostAsync(RequestUri, contentJson);
            if(response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                await DisplayAlert("Mensaje", "Registrado", "Ok");
            }
            else
            {
                await DisplayAlert("Mensaje", "No se ha Registrado", "Ok");
            }
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand InsertarCommand => new Command(async () => await Insertar());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
