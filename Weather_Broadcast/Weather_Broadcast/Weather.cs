﻿using System;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public class Weather
    {
        
        private string selectedCity;

        // Fields to hold View Controls reference
        public Label LabelCityName { get; private set; }
        public Label LabelCurrentDate { get; private set; }
        public Label LabelCurrentTemperature { get; private set; }
        public Label LabelDescription { get; private set; }
        public PictureBox PictureBoxIcon { get; private set; }

        // Fields to hold weather data
        private double temp { get; set; }
        private string condition { get; set; }
        private double humidity { get; set; }
        private double rainChance { get; set; }
        private DateTime sunrise { get; set; }
        private DateTime sunset { get; set; }
        private double windspeed { get; set; }
        private double precipitation { get; set; }
        private string icon { get; set; }

        API apiWeather;

        public Weather(string city, Label labelCityName, Label labelDate, Label labelCurrentTemp, Label labelDescription, PictureBox weatherIcon)
        {
            // init weather data
            selectedCity = city;
            apiWeather = new API(selectedCity);
            temp = apiWeather.GetTempC();
            condition = apiWeather.GetWeatherCondition();
            humidity = apiWeather.GetHumidity();
            rainChance = apiWeather.GetRainChance();
            sunrise = apiWeather.GetSunRiseDayTime();
            sunset = apiWeather.GetSunSetDayTime();
            windspeed = apiWeather.GetWindSpeed();

            // Init view control reference
            LabelCityName = labelCityName;
            LabelCurrentDate = labelDate;
            LabelCurrentTemperature = labelCurrentTemp;
            LabelDescription = labelDescription;
            PictureBoxIcon = weatherIcon;

        }

        public static void DisplayWeather()
        {
            
        }

        public static void DisplayTemp()
        {

        }

        public static void DisplayBackground()
        {

        }

        public static void DisplayHumidity()
        {

        }

        public static void DisplayRainChance()
        {

        }

        public static void DisplayDayNight()
        {

        }

        public static void DisplayWindSpeed()
        {

        }

        public static void DisplayIcon()
        {

        }
    }

}
