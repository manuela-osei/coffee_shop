using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Coffee_Shop
{
    public partial class frmCoffeeShop : Form
    {
        //input variables of each item. Each item has it prize indicated in monetary.
        decimal filter = 2.10M;
        decimal Espresso = 2.25M;
        decimal Cappuccino = 2.70M;
        decimal Americano = 2.35M;
        decimal Latte = 2.80M;
        decimal Mocha = 2.95M;
        decimal HotChocolate = 2.95M;
        decimal IcedCoffee = 2.95M;
        decimal Caramel = 0.5M;
        decimal Vanilla = 0.50M;
        decimal HazelnutSyrup = 0.50M;
        decimal EnglishBreakfastRegular = 2.65M;
        decimal EnglishBreakfastDecaf = 2.95M;
        decimal EarlGrey = 2.65M;
        decimal Darjeeling = 2.65M;
        decimal Peppermint = 2.65M;
        decimal Chamomile = 2.70M;
        decimal JasmineDragonPearl = 2.95M;
        decimal Rooibos = 2.95M;
        decimal ChaiTea = 2.70M;
        decimal OrganicCarrotCake = 2.28M;
        decimal VictoriaSponge = 1.99M;
        decimal StickyAppleCaramel = 2.28M;
        decimal DutchChunkyAppleFlan = 2.18M;
        decimal ChocolateFudgeCake = 1.96M;
        decimal ChocolateAndCoconutSponge = 0.82M;

        //input the totalitems and show them to be "0" as long as the hasn't been a calculation. 
        decimal totalFilter = 0;
        decimal totalEspresso = 0;
        decimal totalCappuccino = 0;
        decimal totalAmericano = 0;
        decimal totalLatte = 0;
        decimal totalMocha = 0;
        decimal totalHotChocolate = 0;
        decimal totalIcedCoffee = 0;
        decimal totalCaramel = 0;
        decimal totalVanilla = 0;
        decimal totalHazelnutSyrup = 0;
        decimal totalEnglishBreakfastRegular = 0;
        decimal totalEnglishBreakfastDecaf = 0;
        decimal totalEarlGrey = 0;
        decimal totalDarjeeling = 0;
        decimal totalPeppermint = 0;
        decimal totalChamomile = 0;
        decimal totalJasmineDragonPearl = 0;
        decimal totalRooibos = 0;
        decimal totalChaiTea = 0;
        decimal totalOrganicCarrotCake = 0;
        decimal totalVictoriaSponge = 0;
        decimal totalStickyAppleCaramel = 0;
        decimal totalDutchChunkyAppleFlan = 0;
        decimal totalChocolateFudgeCake = 0;
        decimal totalChocolateAndCoconutSponge = 0;

        public frmCoffeeShop()
        {
            InitializeComponent();
        }


        private void numericUpDown27_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It multiplies the prize and the number of item.
            totalFilter = filter * nudFilter.Value;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this code is for closing up the app. 
            this.Close();
        }

        private void nudEspresso_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalEspresso = Espresso * nudEspresso.Value;
        }

        private void nudCappuccino_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalCappuccino = Cappuccino * nudCappuccino.Value;
        }

        private void nudAmericano_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalAmericano = Americano * nudAmericano.Value;
        }

        private void nudLatte_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalLatte = Latte * nudLatte.Value;
        }

        private void nudMocha_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalMocha = Mocha * nudMocha.Value;
        }

        private void nudHotChocolate_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalHotChocolate = HotChocolate * nudHotChocolate.Value;
        }

        private void nudIcedCoffee_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalIcedCoffee = IcedCoffee * nudIcedCoffee.Value;
        }

        private void nudCaramel_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalCaramel = Caramel * nudCaramel.Value;
        }

        private void nudVanilla_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalVanilla = Vanilla * nudVanilla.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalHazelnutSyrup = HazelnutSyrup * nudHazelnutSyrup.Value;
        }

        private void nudOrganicCarrotCake_ValueChanged(object sender, EventArgs e)
        {
            //this is code for the totalitem.it multiplies the prize and the number of the item.
            totalOrganicCarrotCake = OrganicCarrotCake * nudOrganicCarrotCake.Value;
        }

        private void nudVictoriaSponge_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalVictoriaSponge = VictoriaSponge * nudVictoriaSponge.Value;
        }

        private void nudStickyAppleCaramel_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalStickyAppleCaramel = StickyAppleCaramel * nudStickyAppleCaramel.Value;
        }

        private void nudDutchChunkyAppleFlan_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalDutchChunkyAppleFlan = DutchChunkyAppleFlan * nudDutchChunkyAppleFlan.Value;
        }

        private void nudChocolateFudgeCake_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalChocolateFudgeCake = ChocolateFudgeCake * nudChocolateFudgeCake.Value;
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalChocolateAndCoconutSponge = ChocolateAndCoconutSponge * nudChocolateAndCoconutSponge.Value;
        }

        private void nudEnglishBreakfastRegular_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalEnglishBreakfastRegular = EnglishBreakfastRegular * nudEnglishBreakfastRegular.Value;
        }

        private void nudEnglishBreakfastDecaf_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalEnglishBreakfastDecaf = EnglishBreakfastDecaf * nudEnglishBreakfastDecaf.Value;
        }

        private void nudEarlGrey_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalEarlGrey = EarlGrey * nudEarlGrey.Value;
        }

        private void nudDarjeeling_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalDarjeeling = Darjeeling * nudDarjeeling.Value;
        }

        private void nudPeppermint_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalPeppermint = Peppermint * nudPeppermint.Value;
        }

        private void nudChamomile_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalChamomile = Chamomile * nudChamomile.Value;
        }

        private void nudJasmineDragonPearl_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalJasmineDragonPearl = JasmineDragonPearl * nudJasmineDragonPearl.Value;
        }

        private void nudRooibos_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalRooibos = Rooibos * nudRooibos.Value;
        }

        private void nudChaiTea_ValueChanged(object sender, EventArgs e)
        {
            // this is the code for the totalitem. It mutiplies the prize and the number of item.
            totalChaiTea = ChaiTea * nudChaiTea.Value;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //this code adds up all the totalitems together to execute the answer
            decimal GrandTotal;
            GrandTotal = totalFilter + totalEspresso + totalCappuccino + totalAmericano + totalLatte
                        + totalMocha + totalHotChocolate + totalIcedCoffee + totalCaramel + totalVanilla
                        + totalHazelnutSyrup + totalOrganicCarrotCake + totalVictoriaSponge +
                        totalStickyAppleCaramel + totalDutchChunkyAppleFlan + totalChocolateFudgeCake
                        + totalChocolateAndCoconutSponge + totalEnglishBreakfastRegular
                        + totalEnglishBreakfastDecaf + totalEarlGrey + totalDarjeeling + totalPeppermint
                        + totalChamomile + totalJasmineDragonPearl + totalRooibos + totalChaiTea;
            //this code shows the grandtotal which is the result in the lblTotal and with a pound symbol in front of it. 
            lblTotal.Text = "£" + Convert.ToString(GrandTotal);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //this code is for all totalitems in the nub to set as 0 when the reset button is been clicked.
            totalFilter = 0;
            totalEspresso = 0;
            totalCappuccino = 0;
            totalAmericano = 0;
            totalLatte = 0;
            totalMocha = 0;
            totalHotChocolate = 0;
            totalIcedCoffee = 0;
            totalCaramel = 0;
            totalVanilla = 0;
            totalHazelnutSyrup = 0;
            totalEnglishBreakfastRegular = 0;
            totalEnglishBreakfastDecaf = 0;
            totalEarlGrey = 0;
            totalDarjeeling = 0;
            totalPeppermint = 0;
            totalChamomile = 0;
            totalJasmineDragonPearl = 0;
            totalRooibos = 0;
            totalChaiTea = 0;
            totalOrganicCarrotCake = 0;
            totalVictoriaSponge = 0;
            totalStickyAppleCaramel = 0;
            totalDutchChunkyAppleFlan = 0;
            totalChocolateFudgeCake = 0;
            totalChocolateAndCoconutSponge = 0;

            nudFilter.Value = 0;
            nudEspresso.Value = 0;
            nudCappuccino.Value = 0;
            nudAmericano.Value = 0;
            nudLatte.Value = 0;
            nudMocha.Value = 0;
            nudHotChocolate.Value = 0;
            nudIcedCoffee.Value = 0;
            nudCaramel.Value = 0;
            nudVanilla.Value = 0;
            nudHazelnutSyrup.Value = 0;
            nudOrganicCarrotCake.Value = 0;
            nudVictoriaSponge.Value = 0;
            nudStickyAppleCaramel.Value = 0;
            nudDutchChunkyAppleFlan.Value = 0;
            nudChocolateFudgeCake.Value = 0;
            nudChocolateAndCoconutSponge.Value = 0;
            nudEnglishBreakfastRegular.Value = 0;
            nudEnglishBreakfastDecaf.Value = 0;
            nudEarlGrey.Value = 0;
            nudDarjeeling.Value = 0;
            nudPeppermint.Value = 0;
            nudChamomile.Value = 0;
            nudJasmineDragonPearl.Value = 0;
            nudRooibos.Value = 0;
            nudChaiTea.Value = 0;
            //this is for the lbltotal is set at nothing when the reset button is been clicked on.
            lblTotal.Text = null;
        }

    }
}
