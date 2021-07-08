using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mailer
{
    public class Model:INotifyPropertyChanged
    {
<<<<<<< HEAD
      
        //Add something
=======
        static int Counter { get; set; } = 0;
>>>>>>> b6d8cf8acfdc4e24dfa78ed21d0e602e7afe7d3f
        public string Login { get; set; }
        public string Password { get; set; }


        #region Comment
        //public int Value1
        //{
        //    get
        //    {
        //        return value1;
        //    }
        //    set
        //    {
        //        System.Diagnostics.Debug.WriteLine("Value1 is changed!");
        //        if (value1 != value)
        //        {
        //            value1 = value;
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value1"));
        //        }
        //    }
        //}
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
