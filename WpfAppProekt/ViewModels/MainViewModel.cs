using System.Collections.ObjectModel;
using WpfAppProekt.Models;

namespace WpfAppProekt.ViewModels;

public class MainViewModel : BindableBase
{
    private Product? _selected;
    private Product? _model;
    private string _title = "????? ???????";

    public ObservableCollection<Product> Items { get; } = new ObservableCollection<Product>();

    public Product? Selected
    {
        get => _selected;
        set => SetProperty(ref _selected, value);
    }

    public Product? Model
    {
        get => _model;
        set => SetProperty(ref _model, value);
    }

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    public RelayCommand AddCommand => new RelayCommand(_ =>
    {
        Model = new Product();
        Title = "???????? ???????";
    });

    public RelayCommand EditCommand => new RelayCommand(_ =>
    {
        if (Selected != null)
        {
            // create an editable copy so cancel can revert
            Model = new Product { Name = Selected.Name, Price = Selected.Price };
            Title = "????????????? ???????";
        }
    });

    public RelayCommand DeleteCommand => new RelayCommand(_ =>
    {
        if (Selected != null)
        {
            Items.Remove(Selected);
            Selected = null;
        }
    });

    public RelayCommand SaveCommand => new RelayCommand(_ =>
    {
        if (Model == null) return;

        if (Title.Contains("????????"))
        {
            Items.Add(Model);
        }
        else if (Title.Contains("?????????????") && Selected != null)
        {
            // apply edits to the selected item
            Selected.Name = Model.Name;
            Selected.Price = Model.Price;
        }

        Model = null;
    });

    public RelayCommand CancelCommand => new RelayCommand(_ =>
    {
        Model = null;
    });

    public MainViewModel()
    {
        // sample data
        Items.Add(new Product { Name = "??????", Price = 1.2m });
        Items.Add(new Product { Name = "?????", Price = 0.8m });
    }
}