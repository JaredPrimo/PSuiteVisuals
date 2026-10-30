using System.Collections.ObjectModel;
using System.Data.Common;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CsvHelper;

namespace P_SuiteVisual.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string LandingPageTxt { get; set; } = @"
                                                    $$$$$$$\         $$$$$$\  $$\   $$\ $$$$$$\ $$$$$$$$\ $$$$$$$$\ 
                                                    $$  __$$\       $$  __$$\ $$ |  $$ |\_$$  _|\__$$  __|$$  _____|
                                                    $$$ |  $$| ____ $$ /  \__|$$ |  $$ |  $$ |     $$ |   $$ |      
                                                    $$$$$$$$$|      \$$$$$$\  $$ |  $$ |  $$ |     $$ |   $$$$$\    
                                                    $$  ____/        \____$$\ $$ |  $$ |  $$ |     $$ |   $$  __|   
                                                    $$ |            $$\   $$ |$$ |  $$ |  $$ |     $$ |   $$ |      
                                                    $$ |            \$$$$$$  |\$$$$$$  |$$$$$$\    $$ |   $$$$$$$$\ 
                                                    \__|             \______/  \______/ \______|   \__|   \________|
            ";

   
    public ObservableCollection<Sku> inventory{get; set;} = new Sku().RetrieveSkuInfo();
    
    
}
