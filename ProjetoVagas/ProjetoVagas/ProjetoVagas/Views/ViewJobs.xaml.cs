﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoVagas.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewJobs : ContentPage
	{
		public ViewJobs ()
		{
			InitializeComponent ();
		}

        public void CreateNewJob(Object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new RegisterJobs());
            
        }

    }
}