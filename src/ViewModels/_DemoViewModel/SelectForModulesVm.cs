using _DemoViewModel.DTO;
using BaseData.DataProviders.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ViewModelBase;

namespace _DemoViewModel
{
    public class SelectForModulesVm : ViewModel
    {
        private readonly DataContext _model;
        SqlConnection connection;
        public SelectForModulesVm(DataContext model) 
        {
            _model = model;

            connection = (SqlConnection)_model.Database.GetDbConnection();

            PollutionData = new(_model.PollutionFields
                .Select(m =>
                new PollutionDto()
                {
                    Id = m.ID,
                    LinkFile = m.LinkFile
                }));
            

        }
        public ObservableCollection<WeatherDataDto> WeatherData { private get; set; }
        public ObservableCollection<PollutionDto> PollutionData {  get; set;}

      
        public object SelectWeatherData(DateTime date)
        {
            if(connection.State != ConnectionState.Open) 
                connection.Open();
            var command = new SqlCommand("Select * from WeatherData Where Date = @Date", connection);
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Date",
                Value = date
            });
           
           var read = command.ExecuteReader();
           read.Read();
           var result = read.GetValue(10000000);
           connection.Close();

           return result;
        }
    }
}
