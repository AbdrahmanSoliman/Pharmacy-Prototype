using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pharmacy
{
    public partial class Form2 : Form
    {
        List l = new List();
        double _balance = 0;
        double total = 0;
        string cart = "Your Order: \n\n\t";
        class Node
        {
            string dataname;
            int dataqnt;
            double dataprice;
            Node next;

            public string DataN
            {
                set { dataname = value; }
                get { return dataname; }
            }

            public int DataQ
            {
                set { dataqnt = value; }
                get { return dataqnt; }
            }

            public double DataP
            {
                set { dataprice = value; }
                get { return dataprice; }
            }

            public Node Next
            {
                set { next = value; }
                get { return next; }
            }

            public Node(string datan, int dataq, double datap)
            {
                this.dataname = datan;
                this.dataqnt = dataq;
                this.dataprice = datap;
                next = null;
            }
        }

        class List
        {
            public Node start;
            public Node tail;

            public List()
            {
                start = tail = null;
            }

            public void add(string datan, int dataq, double datap, string loaderORNot)
            {
                if(dataq <= 0 && datap <= 0)
                {
                    MessageBox.Show("Invalid Quantity/Price");
                    return;
                }
                else if (dataq <= 0)
                {
                    MessageBox.Show("Invalid Quantity");
                    return;
                }
                else if (datap <= 0)
                {
                    MessageBox.Show("Invalid Price");
                    return;
                }

                Node tmp = new Node(datan, dataq, datap);
                
                if (start == null)
                {
                    start = tmp;
                    tail = tmp;
                    if (loaderORNot == "Not")
                        MessageBox.Show(dataq + " box(es) of medicine " + datan + " has been added");

                }
                else
                {
                    Node q = start;
                    while(q!=null)
                    {
                        if(q.DataN == datan)
                        {
                            q.DataQ += dataq;
                            q.DataP = datap;
                            if (loaderORNot == "Not")
                                MessageBox.Show(dataq + " box(es) of medicine " + datan + " has been supplied");
                            return;
                        }
                        q = q.Next;
                    }
                    tail.Next = tmp;
                    tail = tmp;
                    if (loaderORNot == "Not")
                        MessageBox.Show(dataq + " box(es) of medicine " + datan + " has been added");
                }
            }



            public void delete(string datan)
            {
                if (start == null)
                {
                    MessageBox.Show("The pharmacy is empty");
                    return;
                }
                if (start.DataN == datan)
                {
                    start = start.Next;
                    MessageBox.Show("The medicine " + datan + " is removed");
                    return;
                }

                Node prev = start;
                Node tmp = start.Next;

                while (tmp != null)
                {
                    if (tmp.DataN == datan)
                    {
                        prev.Next = tmp.Next;
                        MessageBox.Show("The medicine " + datan + " is removed");
                        return;
                    }
                    prev = prev.Next;
                    tmp = tmp.Next;
                }
                MessageBox.Show("The medicine " + datan + " doesn't exist");
            }

            public int noOfMed()
            {
                Node q = start;
                int noOfMed = 0;
                while (q != null)
                {
                    q = q.Next;
                    noOfMed++;
                }
                return noOfMed;
            }

            public double search(string datan, int dataq)
            {
                Node q = start;

                while (q != null)
                {
                    if (q.DataN == datan)
                    {
                        if (q.DataQ == 0)
                        {
                            return -5; // Out of stock
                        }
                        else if (q.DataQ < dataq)
                        {
                            return 0; // There is only x Boxes available
                        }
                        else if (q.DataQ >= dataq)
                        {
                            q.DataQ = q.DataQ - dataq;
                            return q.DataP; // Returning the price
                        }
                    }
                    q = q.Next;

                }

                return -1; // Not Found

            }

            public void upgrade(string datan, double up)
            {
                Node q = start;

                while (q != null)
                {
                    if (q.DataN == datan)
                    {

                        MessageBox.Show("The medicine " + q.DataN + " price has changed from " + q.DataP + " to " + up);
                        q.DataP = up;
                        return;
                    }
                    q = q.Next;
                }
                MessageBox.Show("This medicine isn't found in the pharmacy");
            }

            public void display()
            {
                string stock = "";
                Node q = start;

                if (start == null)
                {
                    MessageBox.Show("Stock is empty");
                }
                else
                {
                    while (q != null)
                    {
                        stock += "\nMedicine: " + q.DataN + " || Quantity: " + q.DataQ + " || Price/box: " + q.DataP;
                        q = q.Next;
                    }
                    MessageBox.Show(stock);
                }
            }

            public void OnClosing()
            {
                    Node q = start;

                    using (FileStream fs = new FileStream("stock.txt", FileMode.Create, FileAccess.Write))
                    {
                        StreamWriter sr = new StreamWriter(fs);
                        while (q != null)
                        {
                            sr.WriteLine("/////");
                            sr.WriteLine(q.DataN);
                            sr.WriteLine(q.DataQ);
                            sr.WriteLine(q.DataP);
                            q = q.Next;
                        }
                        sr.Flush();
                    }
            }
            public void Loader()
            {
                Node q = start;
                try
                {


                    using (FileStream fs = new FileStream("stock.txt", FileMode.Open, FileAccess.Read))
                    {
                        StreamReader sr = new StreamReader(fs);
                        while (sr.ReadLine() == "/////")
                        {
                            string n = sr.ReadLine();
                            int qun = Convert.ToInt32(sr.ReadLine());
                            double p = Convert.ToDouble(sr.ReadLine());
                            add(n, qun, p, "");
                            
                        }
                    }
                }
                catch
                {
                }
            }
        }
        
        
        public Form2()
        {
            InitializeComponent();
            l.Loader();
        }

        private void hideALL()
        {
            ////////////////////////////////////////////////////////////
            medRemoval.Text = "";
            nameOfMed.Text = "";
            med.Text = "";
            qnt.Text = "";
            qntOfMed.Text = "";
            pri.Text = "";
            upgradeN.Text = "";
            upgradeP.Text = "";
            ////////////////////////////////////////////////////////////
        }

        private void checkbalance()
        {
            MessageBox.Show("Pharmacy balance: " + _balance);
        }

        private void removeMed_Click(object sender, EventArgs e)
        {
            if (medRemoval.Text != "")
            {
                try
                {
                    l.delete(medRemoval.Text);
                }
                catch
                {
                    MessageBox.Show("The medicine " + medRemoval.Text + " doesn't exist");
                }
            }
            else
                MessageBox.Show("Re-enter the name of expired medicine");

            hideALL();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (nameOfMed.Text != "")
            {
                try
                {
                    int qnt = Convert.ToInt32(qntOfMed.Text);
                    double price = Convert.ToDouble(pri.Text);
                    l.add(nameOfMed.Text, qnt, price,"Not");
                }
                catch
                {
                    MessageBox.Show("Invalid quantity/price");
                }
            }
            else
                MessageBox.Show("Enter the name of the medicine");

            hideALL();
        }

        private void check_Click(object sender, EventArgs e)
        {
            int counter = l.noOfMed();
            MessageBox.Show("The types of medicines " + counter);
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            if (med.Text != "")
            {
                try
                {
                    int Qnt = Convert.ToInt32(qnt.Text);
                    if (Qnt <= 0)
                    {
                        MessageBox.Show("Invalid Quantity");
                        return;
                    }
                    double x = l.search(med.Text, Qnt);
                    if (x == -1)
                    {
                        MessageBox.Show("This medicine is not found");
                    }
                    else if (x == -5)
                    {
                        MessageBox.Show("The medicine " + med.Text + " is OUT OF STOCK");
                    }
                    else if (x == 0)
                    {
                        MessageBox.Show("There is no enough " + med.Text + " IN STOCK");
                    }
                    else
                    {
                        total += (x * Qnt);
                        _balance = _balance + total;
                        MessageBox.Show("You have added " + Qnt + " box{es) of " + med.Text + " to the cart! \n\t\tPrice/Box: " + x);
                        cart += med.Text + "\n\tQnt: " + Qnt + "\n\tPrice/Box: " + x + "\n\n\t";
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Quantity");
                }
            }
            else
                MessageBox.Show("Enter the name of the med");

            hideALL();
        }
        private void orderButton_Click(object sender, EventArgs e)
        {
            if(cart == "Your Order: \n\n\t")
            {
                MessageBox.Show("Your cart is empty");
            }
            else
            {
                MessageBox.Show(cart += "\n\n\n\t  Total price: " + total);
            }
            total = 0;
            cart = "Your Order: \n\n\t";

            hideALL();
        }

        private void balance_Click(object sender, EventArgs e)
        {
            checkbalance();
        }

        private void thestock_Click(object sender, EventArgs e)
        {
            l.display();
        }

        private void upbutton_Click(object sender, EventArgs e)
        {
            if(upgradeN.Text != "")
            {
                try
                {
                    double newprice = Convert.ToDouble(upgradeP.Text);
                    l.upgrade(upgradeN.Text, newprice);
                }
                catch
                {
                    MessageBox.Show("Invalid price");
                }
            }
            else
            {
                MessageBox.Show("Enter the name of the medicine you want to upgrade");
            }
            hideALL();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.OnClosing();
            Program.f1.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            l.OnClosing();
            this.Hide();
            Program.f1.Show();
        }
    }
}
