using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager.Extension
{
    public class RightClickThankingBehavior : DependencyObject, IBehavior
    {
        public string Title { get; set; }
        public DependencyObject AssociatedObject{ get; private set; }
        public string Message { get; set; }
        private void Page_RightTapped(object sender,RoutedEventArgs e)
        {
            new MessageDialog(this.Message,this.Title).ShowAsync();
        }

        public void Attach(DependencyObject associatedObject)
        {
            if(associatedObject is Page)
            {
                this.AssociatedObject = associatedObject;
                (this.AssociatedObject as Page).RightTapped += Page_RightTapped;

            }
        }

        public void Detach()
        {
            this.AssociatedObject = null;
            (this.AssociatedObject as Page).RightTapped -= Page_RightTapped;
        }
    }
}
