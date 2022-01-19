using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Map_Sample
{
    public class ViewModel
    {
        public ObservableCollection<ElectionData> Data { get; set; }
        public ViewModel()
        {
            Data = new ObservableCollection<ElectionData>();
            Data.Add(new ElectionData("Alabama", "Romney", 9));
            Data.Add(new ElectionData("Alaska", "Romney", 3));
            Data.Add(new ElectionData("Arizona", "Romney", 11));
            Data.Add(new ElectionData("Arkansas", "Romney", 6));
            Data.Add(new ElectionData("California", "Romney", 55));
            Data.Add(new ElectionData("Colorado", "Obama", 9));
            Data.Add(new ElectionData("Connecticut", "Obama", 7));
            Data.Add(new ElectionData("Delaware", "Obama", 3));
            Data.Add(new ElectionData("District of Columbia", "Obama", 3));
            Data.Add(new ElectionData("Florida", "Obama", 29));
            Data.Add(new ElectionData("Georgia", "Obama", 16));
            Data.Add(new ElectionData("Hawaii", "Romney", 4));
            Data.Add(new ElectionData("Idaho", "Obama", 4));
            Data.Add(new ElectionData("Illinois", "Romney", 20));
            Data.Add(new ElectionData("Indiana", "Obama", 11));
            Data.Add(new ElectionData("Iowa", "Romney", 6));
            Data.Add(new ElectionData("Kansas", "Obama", 6));
            Data.Add(new ElectionData("Kentucky", "Romney", 8));
            Data.Add(new ElectionData("Louisiana", "Romney", 8));
            Data.Add(new ElectionData("Maine", "Romney", 4));
            Data.Add(new ElectionData("Maryland", "Obama", 10));
            Data.Add(new ElectionData("Massachusetts", "Obama", 11));
            Data.Add(new ElectionData("Michigan", "Obama", 16));
            Data.Add(new ElectionData("Minnesota", "Obama", 10));
            Data.Add(new ElectionData("Mississippi", "Obama", 6));
            Data.Add(new ElectionData("Missouri", "Obama", 10));
            Data.Add(new ElectionData("Montana", "Romney", 3));
            Data.Add(new ElectionData("Nebraska", "Romney", 5));
            Data.Add(new ElectionData("Nevada", "Romney", 6));
            Data.Add(new ElectionData("New Hampshire", "Obama", 4));
            Data.Add(new ElectionData("New Jersey", "Obama", 14));
            Data.Add(new ElectionData("New Mexico", "Obama", 5));
            Data.Add(new ElectionData("New York", "Obama", 29));
            Data.Add(new ElectionData("North Carolina", "Romney", 15));
            Data.Add(new ElectionData("North Dakota", "Romney", 3));
            Data.Add(new ElectionData("Ohio", "Obama", 18));
            Data.Add(new ElectionData("Oklahoma", "Romney", 7));
            Data.Add(new ElectionData("Oregon", "Obama", 7));
            Data.Add(new ElectionData("Pennsylvania", "Obama", 20));
            Data.Add(new ElectionData("Rhode Island", "Obama", 4));
            Data.Add(new ElectionData("South Carolina", "Romney", 9));
            Data.Add(new ElectionData("South Dakota", "Romney", 3));
            Data.Add(new ElectionData("Tennessee", "Romney", 11));
            Data.Add(new ElectionData("Texas", "Romney", 38));
            Data.Add(new ElectionData("Utah", "Romney", 6));
            Data.Add(new ElectionData("Vermont", "Obama", 3));
            Data.Add(new ElectionData("Virginia", "Obama", 13));
            Data.Add(new ElectionData("Washington", "Obama", 12));
            Data.Add(new ElectionData("West Virginia", "Romney", 5));
            Data.Add(new ElectionData("Wisconsin", "Obama", 10));
            Data.Add(new ElectionData("Wyoming", "Romney", 3));
        }
    }
}