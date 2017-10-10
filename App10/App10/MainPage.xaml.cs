using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App10
{
    public partial class MainPage : CarouselPage
    {
        private int count;
      
        public MainPage()
        {
            InitializeComponent();
        
      
            F1.Source = new UriImageSource
            {
                Uri = new Uri("https://img.vvlcdn.com/pp/http://www.airstar.es/wp-content/uploads/2010/09/GP-F1-Singapour-2010-wpp4_1280x1024.jpg")
            };
            F2.Source = new UriImageSource
            {
                Uri = new Uri("http://static.t13.cl/images/sizes/1200x675/1474124619-ros1.jpg")
            };
            F3.Source = new UriImageSource
            {
                Uri = new Uri("http://s.libertaddigital.com/2013/09/21/1280/720/fit/circuito-singapur.jpg")
            };
            F4.Source = new UriImageSource
            {
                Uri = new Uri("https://cdn-5.motorsport.com/static/img/mgl/11400000/11420000/11426000/11426600/11426665/s8/f1-abu-dhabi-gp-2016-second-placed-nico-rosberg-mercedes-amg-f1-w07-hybrid-celebrates-his.jpg")
            };
        }
           

            }


        }


    
