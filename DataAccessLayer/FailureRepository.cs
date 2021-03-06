﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FailureRepository
    {
        string connectionString = @"Server = 193.198.57.183; Database = PIS_TEST; User Id = student; Password = student";

        public List<Failure> _failures = new List<Failure>();
        public List<Failure> _historyOffailures = new List<Failure>();
        public List<County> _counties = new List<County>();
        public List<City> _cities = new List<City>();
        public List<TypeOfFailureCodebook> _typesOfFailure = new List<TypeOfFailureCodebook>();
        public List<User> _users = new List<User>();

        public FailureRepository()
        {
            _failures = GetFailures();
            _historyOffailures = GetHistoryOfFailures();
            _counties = GetCounties();
            _cities = GetCities();
            _typesOfFailure = GetTypesOfFailure();
            _users = GetUsers();
        }
        //Dohvacanje lista podataka iz baze
        public List<Failure> GetFailures()
        {
            var failures = new List<Failure>();
            string urlFailures = "http://student.vsmti.hr/dpersic/PIS_KV/json.php?action=prikazi_ispade";
            string json = CallRestMethod(urlFailures);
            JArray jsonArray = JArray.Parse(json);

            foreach (JObject item in jsonArray)
            {
                failures.Add(new Failure
                {
                    Id = (int)item.GetValue("id_ispad"),
                    Id_Username = (int)item.GetValue("id_korisnik"),
                    Id_TypeOfFailure = (int)item.GetValue("id_vrsta_ispada"),
                    Id_City = (int)item.GetValue("id_grad"),
                    BeginOfFailure = (DateTime)item.GetValue("pocetak_ispada"),
                    EndOfFailure = (DateTime?)item.GetValue("kraj_ispada"),
                    AdditionalDescription = (string)item.GetValue("opis")
                });
            }
            return failures;
        }
        public List<Failure> GetHistoryOfFailures()
        {
            var historyOffailures = new List<Failure>();
            string urlFailures = "http://student.vsmti.hr/dpersic/PIS_KV/json.php?action=prikazi_povijest_ispada";
            string json = CallRestMethod(urlFailures);
            JArray jsonArray = JArray.Parse(json);

            foreach (JObject item in jsonArray)
            {
                historyOffailures.Add(new Failure
                {
                    Id = (int)item.GetValue("id_ispad"),
                    Id_Username = (int)item.GetValue("id_korisnik"),
                    Id_TypeOfFailure = (int)item.GetValue("id_vrsta_ispada"),
                    Id_City = (int)item.GetValue("id_grad"),
                    BeginOfFailure = (DateTime)item.GetValue("pocetak_ispada"),
                    EndOfFailure = (DateTime)item.GetValue("kraj_ispada"),
                    AdditionalDescription = (string)item.GetValue("opis")
                });
            }
            return historyOffailures;
        }
        public List<County> GetCounties()
        {
            var counties = new List<County>();
            string urlCounties = "http://student.vsmti.hr/dpersic/PIS_KV/json.php?action=prikazi_zupanije";
            string json = CallRestMethod(urlCounties);

            JArray jsonArray = JArray.Parse(json);
            foreach (JObject item in jsonArray)
            {
                counties.Add(new County
                {
                    Id = (int)item.GetValue("id_zupanija"),
                    Name = (string)item.GetValue("naziv_zupanije")
                });
            }
            return counties;
        }


        public List<City> GetCities()
        {
            var cities = new List<City>();
            string urlCities = "http://student.vsmti.hr/dpersic/PIS_KV/json.php?action=prikazi_gradove";
            string json = CallRestMethod(urlCities);

            JArray jsonArray = JArray.Parse(json);

            foreach (JObject item in jsonArray)
            {
                cities.Add(new City
                {
                    Id = (int)item.GetValue("id_grad"),
                    Id_County = (int)item.GetValue("id_zupanija"),
                    Name = (string)item.GetValue("naziv"),
                    Latitude = (double)item.GetValue("lat"),
                    Longitude = (double)item.GetValue("lng")
                });
            }
            return cities;
        }

        public List<TypeOfFailureCodebook> GetTypesOfFailure()
        {
            var typesOfFailure = new List<TypeOfFailureCodebook>();
            string urlTypesOfFailure = "http://student.vsmti.hr/dpersic/PIS_KV/json.php?action=prikazi_vrste_ispada";
            string json = CallRestMethod(urlTypesOfFailure);
            JArray jsonArray = JArray.Parse(json);

            foreach (JObject item in jsonArray)
            {
                typesOfFailure.Add(new TypeOfFailureCodebook
                {
                    Id = (int)item.GetValue("id_vrsta_ispada"),
                    TypeOfFailure = (string)item.GetValue("vrsta_ispada")
                });
            }
            return typesOfFailure;
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            string urlUsers = "http://student.vsmti.hr/dpersic/PIS_KV/json.php?action=prikazi_korisnike";
            string json = CallRestMethod(urlUsers);
            JArray jsonArray = JArray.Parse(json);

            foreach (JObject item in jsonArray)
            {
                users.Add(new User
                {
                    Id = (int)item.GetValue("id_korisnik"),
                    Username = (string)item.GetValue("korisnicko_ime"),
                    Password = (string)item.GetValue("lozinka"),
                    FirstName = (string)item.GetValue("ime"),
                    LastName = (string)item.GetValue("prezime")
                });
            }
            return users;
        }

        //Popunjavanje padajućih izbornika
        public List<string> GetComboBoxCounties()
        {
            var comboBoxCounties = _counties.Where(x => !string.IsNullOrEmpty(x.Name)).Select(x => x.Name).ToList();
            comboBoxCounties.Insert(0, "-");
            return comboBoxCounties;
        }
        public List<string> GetCitiesByCounty(string countyName)
        {
            var comboBoxCities = _cities.Where(a => _counties.Any(b => b.Id == a.Id_County && b.Name == countyName)).Select(a => a.Name).ToList();
            comboBoxCities.Insert(0, "-");
            return comboBoxCities;
        }

        public List<string> GetComboBoxTypesOfFailure()
        {
            var comboBoxTypesOfFailure = _typesOfFailure.Where(x => !string.IsNullOrEmpty(x.TypeOfFailure)).Select(x => x.TypeOfFailure).ToList();
            comboBoxTypesOfFailure.Insert(0, "-");
            return comboBoxTypesOfFailure;
        }


        //Dohvaćanje objekta preko stringa
        public User GetUserByUsername(string username)
        {
            var user = _users.Where(u => u.Username == username).Select(u => new User
            {
                Id = u.Id,
                Username = u.Username,
                Password = u.Password,
                FirstName = u.FirstName,
                LastName = u.LastName,
            }).FirstOrDefault();
            return user;
        }


        public County GetCountyComboBoxValue(string countyName)
        {
            var county = _counties.Where(u => u.Name == countyName).Select(u => new County
            {
                Id = u.Id,
                Name = u.Name
            }).FirstOrDefault();
            return county;
        }

        public City GetCityComboBoxValue(string cityName)
        {
            var city = _cities.Where(u => u.Name == cityName).Select(u => new City
            {
                Id = u.Id,
                Name = u.Name
            }).FirstOrDefault();
            return city;
        }

        public TypeOfFailureCodebook GetTypeOfFailureComboBoxValue(string type)
        {
            var typeOfFailure = _typesOfFailure.Where(u => u.TypeOfFailure == type).Select(u => new TypeOfFailureCodebook
            {
                Id = u.Id,
                TypeOfFailure = u.TypeOfFailure
            }).FirstOrDefault();
            return typeOfFailure;
        }


        //Dohvaćanje vrijednosti u Edit formi
        public string GetTypeOfFailureById(int typeOfFailureId)
        {
            var typeOfFailure = _typesOfFailure.Where(u => u.Id == typeOfFailureId).Select(u => u.TypeOfFailure).First().ToString();
            return typeOfFailure;
        }
        public string GetUserById(int userId)
        {
            var user = _users.Where(u => u.Id == userId).Select(u => u.Username).First().ToString();
            return user;
        }

        public string GetCityById(int cityId)
        {
            var city = _cities.Where(u => u.Id == cityId).Select(u => u.Name).First().ToString();
            return city;
        }

        public int GetTypeOfFailureIdByString(string typeOfFailure)
        {
            var failureId = _typesOfFailure.Where(u => u.TypeOfFailure == typeOfFailure).Select(u => u.Id).First();
            return failureId;
        }

        public int GetUserIdByString(string username)
        {
            var userId = _users.Where(u => u.Username == username).Select(u => u.Id).First();
            return userId;
        }

        public int GetCityIdByString(string city)
        {
            var cityId = _cities.Where(u => u.Name == city).Select(u => u.Id).First();
            return cityId;
        }

        //Dodavanje u bazu
        public void AddFailure(Failure failure)
        {
            using (DbConnection oConnection = new SqlConnection(connectionString)) using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO [03_Ispad] (ID_korisnik, ID_vrsta_ispada, ID_grad, Datum_vrijeme_pocetka_ispada, Dodatan_opis) VALUES('" + failure.Id_Username + "', '" + failure.Id_TypeOfFailure + "', '" + failure.Id_City + "', '" + failure.BeginOfFailure.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + failure.AdditionalDescription + "')";           
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        //Azuriranje ispada s datumom zavrsetka
        public void UpdateFailure(Failure failure)
        {
            using (DbConnection oConnection = new SqlConnection(connectionString)) using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE [03_Ispad] SET ID_korisnik = '" + failure.Id_Username + "', ID_vrsta_ispada = '" + failure.Id_TypeOfFailure + "', ID_grad = '" + failure.Id_City + "', Datum_vrijeme_pocetka_ispada = '" + failure.BeginOfFailure.ToString("yyyy-MM-dd HH:mm:ss") + "', Datum_vrijeme_zavrsetka_ispada = '" + failure.EndOfFailure?.ToString("yyyy-MM-dd HH:mm:ss") + "', Dodatan_opis = '" + failure.AdditionalDescription + "'WHERE ID_ispad = " + failure.Id; oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

        }

        //Azuriranje ispada bez datuma zavrsetka
        public void UpdateFailureWithoutDate(Failure failure)
        {
            using (DbConnection oConnection = new SqlConnection(connectionString)) using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE [03_Ispad] SET ID_korisnik = '" + failure.Id_Username + "', ID_vrsta_ispada = '" + failure.Id_TypeOfFailure + "', ID_grad = '" + failure.Id_City + "', Datum_vrijeme_pocetka_ispada = '" + failure.BeginOfFailure.ToString("yyyy-MM-dd HH:mm:ss") + "', Dodatan_opis = '" + failure.AdditionalDescription + "'WHERE ID_ispad = " + failure.Id; oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

        }


        //Brisanje ispada
        public void DeleteFailure(Failure failure)
        {
            using (DbConnection oConnection = new SqlConnection(connectionString)) using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM [03_Ispad] WHERE ID_ispad = '" + failure.Id + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.MaximumAutomaticRedirections = 5;
            webrequest.MaximumResponseHeadersLength = 5;
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
    }
}
