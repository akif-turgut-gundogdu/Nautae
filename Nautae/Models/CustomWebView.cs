using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Nautae.Views
{
        public class CustomWebView : WebView
        {
            public static readonly BindableProperty UriProperty = BindableProperty.Create(propertyName: "cenoasailingSunum.pdf",
                    returnType: typeof(string),
                    declaringType: typeof(CustomWebView),
                    defaultValue: default(string));

            public string Uri
            {
                get { return (string)GetValue(UriProperty); }
                set { SetValue(UriProperty, value); }
            }
        }
    }

