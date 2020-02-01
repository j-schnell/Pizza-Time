using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Time
{
	public partial class frmMain : Form
	{
		private List<string>[] toppings = new List<string>[3];
        private Dictionary<string, int>[] toppingSizes = new Dictionary<string, int>[3];
        private bool[] portions = new bool[3];
        private string[] toppingsList = { "Pepperoni", "Fromage mozzarella", "Sauce à Pizza", "Champignon", "Bacon", "Oignon", "Ail",
            "Poivron Rouge", "Tomate", "Basilic", "Olives noires", "Anana", "Jambon", "Poivron Vert", "Fromage parmigiano reggiano",
            "Origan", "Oignon rouge", "Poulet", "Jalapeno", "Salami", "Salami piquante", "Prosciutto"};
        private string[] premium = { "Basilic", "Jambon", "Fromage parmigiano reggiano", "Poulet", "Salami", "Salami piquante", "Prosciutto" };
        private string[] free = { "Pepperoni", "Fromage mozzarella", "Sauce à Pizza" };
        private double[] prices = { 13.49, 14.99, 21.49, 22.99 };
        private Control[] dontDelete = { };
        private List<string[]> pizzas = new List<string[]>();
        private List<double> pizzaPrices = new List<double>();

        /* 0: Whole thing
         * 1: Left half
         * 2: Right half*/

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
            rebuildPizza(true);
            updateReceipt();
        }

        private void addTopping(string text, int index)
        {
            if (toppings[index].Contains(text) == false)
            {
                toppings[index].Add(text);
                rebuildPizza();
            }
        }

        private void buildTopping(string text, int index, int size=-1)
        {
            if (toppings[index].Contains(text) == false)
            {
                toppings[index].Add(text);
            } else
            {
                return;
            }
            int startingY = 100;
            int addition = 0;
            for (int i = 0; i < toppings.Length; i++)
            {
                if (i == index)
                {
                    startingY += 25;
                    startingY += (toppings[i].Count() - 1) * 65;
                    break;
                }
                addition = 0;
                addition += 30;
                addition += toppings[i].Count() * 65;
                if (portions[i] == true)
                {
                    startingY += Math.Max(addition, 75);
                }
            }
            GroupBox grp = new GroupBox();
            grp.Location = new Point(20, startingY);
            grp.Text = text;
            grp.Size = new Size(180, 55);
            grp.AccessibleDescription = index.ToString();
            ttpInfo.SetToolTip(grp, string.Format("La quantité de {0} d'ajouter à la pizza", grp.Text));
            RadioButton[] rads = new RadioButton[3];
            for (int i = 0; i < rads.Length; i++) { rads[i] = new RadioButton(); }
            rads[0].Text = "Peu";
            rads[1].Text = "Normal";
            rads[2].Text = "Extra";
            int X = grp.Location.X;
            int Y = grp.Location.Y;
            rads[0].Location = new Point(5, 25);
            rads[1].Location = new Point(55, 25);
            rads[2].Location = new Point(125, 25);
            rads[0].AutoSize = true;
            rads[1].AutoSize = true;
            rads[2].AutoSize = true;
            rads[0].TabIndex = 0;
            rads[1].TabIndex = 1;
            rads[2].TabIndex = 2;
            rads[0].CheckedChanged += RadioButton_CheckedChanged;
            rads[1].CheckedChanged += RadioButton_CheckedChanged;
            rads[2].CheckedChanged += RadioButton_CheckedChanged;
            for (int i = 0; i < rads.Length; i++)
            {
                grp.Controls.Add(rads[i]);
            }
            rads[1].Checked = true;
            if (size > -1)
            {
                rads[size].Checked = true;
            }
            Button btn = new Button();
            btn.Text = "X";
            btn.Location = new Point(185, startingY);
            btn.Size = new Size(20, 20);
            btn.AccessibleDescription = index.ToString() + text;
            btn.Click += BtnClose_Click;
            ttpInfo.SetToolTip(btn, string.Format("Enlever {0} de la pizza", grp.Text));
            this.Controls.Add(btn);
            this.Controls.Add(grp);
        }

        private void buildPortion(int index)
        {
            int startingY = 100;
            int addition = 0;
            for (int i = 0; i < toppings.Length; i++)
            {
                if (i == index) { break;  }
                addition = 0;
                addition += 30;
                addition += toppings[i].Count() * 65;
                if (toppings[i].Count() > 0)
                {
                    startingY += Math.Max(addition, 75);
                }
            }
            portions[index] = true;
            string s;
            if (index >= 1)
            {
                s = "Moitié ";
                s += index.ToString();
            }
            else 
            {
                s = "Pizza";
            } 
            Label lbl = new Label();
            lbl.Location = new Point(15, startingY);
            lbl.Text = s;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
            Button btn = new Button();
            btn.Location = new Point(215, startingY + 27);
            btn.Text = "Ajoute la garniture";
            btn.Size = new Size(120, 23);
            btn.AccessibleDescription = index.ToString();
            btn.Click += BtnAddTopping_Click;
            ttpInfo.SetToolTip(btn, "Pour ajouter la garniture choisi dans la boite à la pizza");
            this.Controls.Add(btn);
            ComboBox cmb = new ComboBox();
            cmb.Location = new Point(215, startingY);
            cmb.Text = "Garniture";
            cmb.Size = new Size(120, 21);
            cmb.AccessibleDescription = index.ToString();
            cmb.KeyPress += ComboBox_KeyPress;
            ttpInfo.SetToolTip(cmb, "La garniture pour ajouter à la pizza");
            foreach (string i in toppingsList) { cmb.Items.Add(i); }
            this.Controls.Add(cmb);
        }

        private void rebuildPizza(bool reset=false)
        {
            dontDelete = new Control[] { grpSize, grpCrust, grpCooked, lblInfo, lblReceipt, btnSplit, btnOrder, btnAdd, btnCancel, updQuantity, txtReceipt };
            for (int i = this.Controls.Count - 1; i > 0; i--)
            {
                if (!(dontDelete.Contains(this.Controls[i])))
                {
                    this.Controls.RemoveAt(i);
                }
            }
            if (reset == false)
            {
                for (int i = 0; i < toppings.Length; i++)
                {
                    List<string> temp_toppings = toppings[i];
                    toppings[i] = new List<string>();
                    if (portions[i])
                    {
                        buildPortion(i);
                        foreach (string k in temp_toppings)
                        {
                            buildTopping(k, i, toppingSizes[i][k]);
                        }
                    }
                }
            } else
            {
                for (int i = 0; i < toppings.Length; i++)
                {
                    toppings[i] = new List<string>();
                    toppingSizes[i] = new Dictionary<string, int>();
                }
                radCrust2.Checked = true;
                radCooked3.Checked = true;
                radSize2.Checked = true;
                if (portions[0] == false) { btnSplit.PerformClick(); }
                buildPortion(0);
                buildTopping("Pepperoni", 0);
                buildTopping("Fromage mozzarella", 0);
                buildTopping("Sauce à Pizza", 0);

            }
            int startingY = 100;
            int addition = 0;
            for (int i = 0; i < toppings.Length; i++)
            {
                addition = 0;
                addition += 30;
                addition += toppings[i].Count() * 65;
                if (portions[i] == true)
                {
                    startingY += Math.Max(addition, 75);
                }
            }
            startingY = Math.Max(this.Size.Height - 40, startingY);
            btnAdd.Location = new Point(245, startingY - 40);
            updQuantity.Location = new Point(245, startingY - 66);
            lblInfo.Location = new Point(245, startingY - 119);
        }

        private void updateReceipt()
        {
            string receipt = "Baba Jon Pizza\n" +
                "2200 Brock Road\n" +
                "Pickering, ON L1V 2P8\n" +
                "------------------------------------------\n";
            string s;
            for (int i = 0; i < pizzas.Count(); i++)
            {
                s = "";
                s += string.Format("Pizza {0} ({1}):\n", i+1, pizzaPrices[i].ToString("c"));
                s += "Pizza " + pizzas[i][2].ToString() + "\n";
                if (pizzas[i][0] != "Normal") { s += "Croûte " + pizzas[i][0] + "\n"; }
                if (pizzas[i][1] != "Normal") { s += pizzas[i][1] + "\n"; }
                if (!pizzas[i].Contains("#"))
                {
                    s += "Garnitures:\n";
                    for (int k = 3; k < pizzas[i].Count(); k++)
                    {
                        s += "    " + pizzas[i][k] + "\n";
                    }
                } else
                {
                    s += "Garnitures de la première moitié:\n";
                    int index = 0;
                    for (int k = 3; k < pizzas[i].Count(); k++)
                    {
                        if (pizzas[i][k] == "#")
                        {
                            index = k;
                            break;
                        }
                        s += "    " + pizzas[i][k] + "\n";
                    }
                    s += "Garnitures de la deuxième moitié:\n";
                    for (int k = index + 1; k < pizzas[i].Count(); k++)
                    {
                        s += "    " + pizzas[i][k] + "\n";
                    }
                }
                receipt += s + "\n";
            }
            receipt += "\n";
            receipt += "Sous Totale: " + (pizzaPrices.Sum()).ToString("c") + "\n";
            receipt += "Taxe: " + (pizzaPrices.Sum() * 0.13).ToString("c") + "\n";
            receipt += "Totale: " + (pizzaPrices.Sum() * 1.13).ToString("c");
            txtReceipt.Text = receipt;
            txtReceipt.Text = txtReceipt.Text.Replace("\n", Environment.NewLine);
        }

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RadioButton rb = (RadioButton)sender;
                int index = int.Parse(rb.Parent.AccessibleDescription);
                if (toppingSizes[index].ContainsKey(rb.Parent.Text))
                {
                    toppingSizes[index][rb.Parent.Text] = rb.TabIndex;
                } else
                {
                    toppingSizes[index].Add(rb.Parent.Text, rb.TabIndex);
                }
                double price = 0;
                string realText = "";
                if (rb.Parent.Text.Contains('(')) { realText = rb.Parent.Text.Substring(0, rb.Parent.Text.IndexOf('(') - 1); } else { realText = rb.Parent.Text; }
                if (free.Contains(realText) == false)
                {
                    if (premium.Contains(realText)) { price += 1; }
                    price += 0.5 * (rb.TabIndex + 1);
                    if (!portions[0]) { price /= 2; }
                    rb.Parent.Text = realText + string.Format(" (+{0})", price.ToString("c"));
                }
            }
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            if (portions[0])
            {
                portions[0] = false;
                portions[1] = true;
                portions[2] = true;
                toppings[1] = toppings[0];
                toppings[2] = toppings[0];
                toppingSizes[1] = toppingSizes[0];
                toppingSizes[2] = toppingSizes[0];
                toppings[0] = new List<string>();
                toppingSizes[0] = new Dictionary<string, int>();
                btnSplit.Text = "Combiner la pizza";
            }
            else
            {
                portions[0] = true;
                portions[1] = false;
                portions[2] = false;
                toppings[0] = toppings[1];
                toppingSizes[0] = toppingSizes[1];
                foreach (string i in toppings[2])
                {
                    if (toppings[0].Contains(i) == false)
                    {
                        toppings[0].Add(i);
                        toppingSizes[0].Add(i, toppingSizes[2][i]);
                    }
                }
                toppings[1] = new List<string>();
                toppings[2] = new List<string>();
                toppingSizes[1] = new Dictionary<string, int>();
                toppingSizes[2] = new Dictionary<string, int>();
                btnSplit.Text = "Diviser la pizza";
            }
            rebuildPizza();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            int index = int.Parse((sender as Button).AccessibleDescription.Substring(0, 1));
            string topping = (sender as Button).AccessibleDescription.Substring(1);
            toppings[index].Remove(topping);
            rebuildPizza();
        }

        private void BtnAddTopping_Click(object sender, EventArgs e)
        {
            foreach (Control i in this.Controls)
            {
                if (i.GetType() == typeof(ComboBox) && i.AccessibleDescription == (sender as Button).AccessibleDescription && ((i as ComboBox).SelectedIndex >= 0))
                {
                    int index = int.Parse(i.AccessibleDescription);
                    if (toppings[index].Contains((i as ComboBox).SelectedItem.ToString()) == false) 
                    {
                        toppingSizes[index].Add((i as ComboBox).SelectedItem.ToString(), 1);
                        addTopping((i as ComboBox).SelectedItem.ToString(), index);
                    }
                }
            }
        }

        private void RadCrust4_CheckedChanged(object sender, EventArgs e)
        {
            if (radCrust4.Checked) { grpCrust.Text = "Croûte (+$2.00)"; } else { grpCrust.Text = "Croûte"; }
        }

        private void RadSize_CheckedChanged(object sender, EventArgs e)
        {
            grpSize.Text = string.Format("Largeur ({0})", prices[(sender as RadioButton).TabIndex].ToString("c"));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < updQuantity.Value; n++)
            {
                double price = 0.00;
                List<string> newToppings = new List<string>();
                foreach (RadioButton i in grpCrust.Controls) { if (i.Checked) { newToppings.Add(i.Text); } }
                if (grpCrust.Text.Contains('(')) { price += double.Parse(grpCrust.Text.Substring(grpCrust.Text.IndexOf('(') + 3, grpCrust.Text.Length - grpCrust.Text.IndexOf('(') - 4)); }
                foreach (RadioButton i in grpCooked.Controls) { if (i.Checked) { newToppings.Add(i.Text); } }
                foreach (RadioButton i in grpSize.Controls) { if (i.Checked) { newToppings.Add(i.Text); } }
                price += double.Parse(grpSize.Text.Substring(grpSize.Text.IndexOf('(') + 2, grpSize.Text.Length - grpSize.Text.IndexOf('(') - 3));
                if (portions[0])
                {
                    foreach (string i in toppings[0])
                    {
                        if (toppingSizes[0][i] == 0)
                        {
                            newToppings.Add("Peu de " + i);
                        }
                        else if (toppingSizes[0][i] == 2)
                        {
                            newToppings.Add(i + " en extra");
                        }
                        else
                        {
                            newToppings.Add(i);
                        }
                        if (!free.Contains(i))
                        {
                            price += 0.5 * toppingSizes[0][i] + 0.5;
                            if (premium.Contains(i)) { price += 1; }
                        }
                    }
                }
                else
                {
                    foreach (string i in toppings[1])
                    {
                        if (toppingSizes[1][i] == 0)
                        {
                            newToppings.Add("Peu de " + i);
                        }
                        else if (toppingSizes[1][i] == 2)
                        {
                            newToppings.Add(i + " en extra");
                        }
                        else
                        {
                            newToppings.Add(i);
                        }
                        if (!free.Contains(i))
                        {
                            price += 0.25 * toppingSizes[1][i] + 0.25;
                            if (premium.Contains(i)) { price += 0.5; }
                        }
                    }
                    newToppings.Add("#");
                    foreach (string i in toppings[2])
                    {
                        if (toppingSizes[2][i] == 0)
                        {
                            newToppings.Add("Peu de " + i);
                        }
                        else if (toppingSizes[2][i] == 2)
                        {
                            newToppings.Add(i + " en extra");
                        }
                        else
                        {
                            newToppings.Add(i);
                        }
                        if (!free.Contains(i))
                        {
                            price += 0.25 * toppingSizes[2][i] + 0.25;
                            if (premium.Contains(i)) { price += 0.5; }
                        }
                    }
                }
                pizzas.Add(newToppings.ToArray());
                pizzaPrices.Add(price);
            }
            rebuildPizza(true);
            updQuantity.Value = 1;
            updateReceipt();
            btnOrder.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            pizzas = new List<string[]>();
            pizzaPrices = new List<double>();
            rebuildPizza(true);
            updateReceipt();
            btnOrder.Enabled = false;
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            DialogResult delivery = MessageBox.Show("Veux tu la livraison?", "Livraison", MessageBoxButtons.YesNo);
            if (delivery == DialogResult.Yes)
            {
                frmDelivery deliveryForm = new frmDelivery();
                if (deliveryForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Ta pizza a été commandé et va être livré bientôt!");
                    btnCancel.PerformClick();
                }
            } else
            {
                MessageBox.Show("Ta pizza a été commandé et peux recueilli bientôt!");
                btnCancel.PerformClick();
            }
        }

        private void FrmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Ce programme a été crée par Jacob Schnell le 10 mai 2019.\n" +
                "\n" +
                "Le programme permet à l'utilisateur de commander une pizza de Baba Jon à travers l'interface visuelle du programme.\n" +
                "Le programme accompli cette tâche en ajoutant des contrôles dynamiquement pour les garnitures.\n" +
                "Finallement l'utilisateur peut choisir d'avoir leur pizza(s) livré chez eux.".Replace("\n", Environment.NewLine), "Crédit");
        }
    }
}
