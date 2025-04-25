using System.ComponentModel;

namespace Week_3_Assignment_3._4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            List<Beverage>beverage = new List<Beverage>();
            beverage.Add(new Beverage() { BevName = "Starbucks"});
            beverage.Add(new Beverage() { PackageType = "Boxes" });
            beverage.Add(new Beverage() { Price = 5 });
            beverage.Add(new Beverage() { SizeOz = 16 });
            beverage.Add(new Beverage() { TemperaturedegF = 60 });
            var list1 = new BindingList<Beverage>(beverage);
            dataGridView1.DataSource = list1;

            List<Coffee>coffee = new List<Coffee>();
            coffee.Add(new Coffee() { IsDecaf = false});
            coffee.Add(new Coffee() { Variety = "Strong" });
            var list= new BindingList<Coffee>(coffee);
            dataGridView1.DataSource = list;
        }
    }
}
