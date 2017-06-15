using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMetrProj
{
    public partial class From1 : Form
    {
        Auto objTruck;
        Auto objCar;
        Auto objBus;
        Auto objMotorcycle;
        Auto obj;

        public From1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objTruck = new Auto("truck");
            objCar = new Auto("car");
            objBus = new Auto("bus");
            objMotorcycle = new Auto("motorcycle");
        }

        public void ToRange()
        {
            if (Convert.ToInt32(carryingTextBox.Text) > 10) carryingTextBox.Text = "10";
            if (Convert.ToInt32(carryingTextBox.Text) < 0) carryingTextBox.Text = "0";
            if (Convert.ToInt32(speedTextBox.Text) > 10) speedTextBox.Text = "10";
            if (Convert.ToInt32(speedTextBox.Text) < 0) speedTextBox.Text = "0";
            if (Convert.ToInt32(costTextBox.Text) > 10) costTextBox.Text = "10";
            if (Convert.ToInt32(costTextBox.Text) < 0) costTextBox.Text = "0";
            if (Convert.ToInt32(capaTextBox.Text) > 10) capaTextBox.Text = "10";
            if (Convert.ToInt32(capaTextBox.Text) < 0) capaTextBox.Text = "0";
        }

        public void rezOut(int rez)
        {
            switch (rez)
            {
                case (0):
                    obj.kind = objTruck.kind;
                    //Console.WriteLine("This is " + obj.kind);
                    answerLabel.Text = "This is " + obj.kind;
                    break;
                case (1):
                    obj.kind = objCar.kind;
                    //Console.WriteLine("This is " + obj.kind);
                    answerLabel.Text = "This is " + obj.kind;
                    break;
                case (2):
                    obj.kind = objBus.kind;
                    //Console.WriteLine("This is " + obj.kind);
                    answerLabel.Text = "This is " + obj.kind;
                    break;
                case (3):
                    obj.kind = objMotorcycle.kind;
                    //Console.WriteLine("This is " + obj.kind);
                    answerLabel.Text = "This is " + obj.kind;
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((carryingTextBox.Text != "") & (speedTextBox.Text != "") &
                (costTextBox.Text != "") & (capaTextBox.Text != ""))
            {
                ToRange();

                double[] arr = new double[4];

                obj = new Auto(Convert.ToInt32(carryingTextBox.Text),
                    Convert.ToInt32(speedTextBox.Text),
                    Convert.ToInt32(costTextBox.Text),
                    Convert.ToInt32(capaTextBox.Text));

                arr[0] = Auto.SortEvklid(objTruck, obj);
                arr[1] = Auto.SortEvklid(objCar, obj);
                arr[2] = Auto.SortEvklid(objBus, obj);
                arr[3] = Auto.SortEvklid(objMotorcycle, obj);

                double min = double.MaxValue;

                foreach (double z in arr)
                {
                    if (min > z) min = z;
                }

                int rez = 10;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == min) rez = i;
                }

                rezOut(rez);
            }
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            if ((carryingTextBox.Text!= "")& (speedTextBox.Text != "")&
                (costTextBox.Text != "")& (capaTextBox.Text != "")) {
                double[] arr = new double[4];

                ToRange();

                obj = new Auto(Convert.ToInt32(carryingTextBox.Text),
                    Convert.ToInt32(speedTextBox.Text),
                    Convert.ToInt32(costTextBox.Text),
                    Convert.ToInt32(capaTextBox.Text));

                arr[0] = Auto.MetKanberra(objTruck, obj);
                arr[1] = Auto.MetKanberra(objCar, obj);
                arr[2] = Auto.MetKanberra(objBus, obj);
                arr[3] = Auto.MetKanberra(objMotorcycle, obj);

                double min = double.MaxValue;

                foreach (double z in arr)
                {
                    if (min > z) min = z;
                }

                int rez = 10;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == min) rez = i;
                }

                rezOut(rez);
            }
        }

        private void kanButton_Click(object sender, EventArgs e)
        {
            if ((carryingTextBox.Text != "") & (speedTextBox.Text != "") &
                (costTextBox.Text != "") & (capaTextBox.Text != ""))
            {
                ToRange();

                double[] arr = new double[4];

                obj = new Auto(Convert.ToInt32(carryingTextBox.Text),
                    Convert.ToInt32(speedTextBox.Text),
                    Convert.ToInt32(costTextBox.Text),
                    Convert.ToInt32(capaTextBox.Text));

                arr[0] = Auto.SumModRaz(objTruck, obj);
                arr[1] = Auto.SumModRaz(objCar, obj);
                arr[2] = Auto.SumModRaz(objBus, obj);
                arr[3] = Auto.SumModRaz(objMotorcycle, obj);

                double min = double.MaxValue;

                foreach (double z in arr)
                {
                    if (min > z) min = z;
                }

                int rez = 10;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == min) rez = i;
                }

                rezOut(rez);
            }
        }
    }
}
