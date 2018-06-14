using System;
using Xamarin.Forms;
using MyLittleBeaconOpgave.ViewModel;
using MyLittleBeaconOpgave.Pages;
using MyLittleBeaconOpgave.Models;

namespace MyLittleBeaconOpgave
{
    //public class customer
    //{
    //    public string id { get; set;  }
    //
    //    public string name { get; set;  }
    //}
    //var sql = $"select {nameof(customer.name)} from {nameof(customer)}";
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new CustomerViewModel();
            //BindingContext = new SalesOrderViewModel();
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new SelectedCustomer(e.SelectedItem as Customer));
        }
    }
}




#region old code
//string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "opgave.gz");
//string filePathdb = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "opgave.db");


//public async void Handle_Clicked(object sender, System.EventArgs e)
//{
//    // WebClient client = new WebClient();

//    if (File.Exists(filePath))
//    {
//        var finfo = new FileInfo(filePath);

//        if (!File.Exists(filePathdb))
//            Decompress(finfo);


//        var c = new DatabaseController();
//        c.GetCustomers();

//        return;
//    }


//    //client.DownloadFile("http://poopeiko.dk/opgave.gz", Directorypath);
//    try
//    {
//        string url = @"http://poopeiko.dk/opgave.gz";
//        // Create an instance of WebClient
//        WebClient client = new WebClient();

//        client.DownloadFileCompleted += Client_DownloadFileCompleted;


//        client.DownloadFileAsync(new Uri(url), filePath);

//    }
//    catch (Exception ex)
//    {
//        throw ex;
//    }

//}


//public void Decompress(FileInfo fileToDecompress)
//{
//    using (FileStream originalFileStream = fileToDecompress.OpenRead())
//    {
//        string currentFileName = fileToDecompress.FullName;
//        string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

//        using (FileStream decompressedFileStream = File.Create(filePathdb))
//        {
//            using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
//            {
//                decompressionStream.CopyTo(decompressedFileStream);
//                Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
//            }
//        }
//    }
//}



//// List<Customer> cuss = App.CustomerController.GetCustomer();
////hej.ItemsSource = cuss;


//void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
//{
//    if (!File.Exists(filePath))
//    {
//        // No file
//        return;
//    }

//    // Extract
//    var finfo = new FileInfo(filePath);

//    Decompress(finfo);
//}
#endregion
